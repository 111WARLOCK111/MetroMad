/*  GLuaFoldingStrategy.cs - A Folding Strategy for Gmod lua.

    Copyright (C) 2014  Ali Deym (https://github.com/111WARLOCK111/).

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) object later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License along
    with this program; if not, write to the Free Software Foundation, Inc.,
    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 */

using System;
using System.Collections.Generic;

using DigitalRune.Windows.TextEditor.Document;

using System.Linq;

using DigitalRune.Windows.TextEditor.Folding;
using DigitalRune.Windows.TextEditor;


namespace MetroMad.gLua
{
    /// <summary>
    /// A simple folding strategy for glua files.
    /// </summary>
    public class GLuaFoldingStrategy : IFoldingStrategy
    {
        /// <summary>
        /// Generates the fold markers.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="parseInformation">The parse information.</param>
        /// <returns>A list containing all foldings.</returns>
        public List<Fold> GenerateFolds(IDocument document, string fileName, object parseInformation)
        {
            List<Fold> folds = new List<Fold>();
            MarkBlocks(document, folds);
            MarkRegions(document, folds);
            return folds;
        }

        /// <summary>
        /// Marks all code blocks (namespaces, classes, methods, etc.) in the document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="foldMarkers">The fold markers.</param>
        private static void MarkBlocks(IDocument document, List<Fold> foldMarkers)
        {
            int offset = 0;
            while (offset < document.TextLength)
            {
                switch (document.GetCharAt(offset))
                {
                    case '[':
                    case '-':
                    case '/':
                        var word = document.GetCharAt(offset).ToString() + document.GetCharAt(offset + 1).ToString();

                        if (document.GetCharAt(offset) == '-' && document.GetCharAt(offset + 1) == '-' && document.GetCharAt(offset + 2) == '[' && document.GetCharAt(offset + 3) == '[')
                            word = word + document.GetCharAt(offset + 2).ToString() + document.GetCharAt(offset + 3).ToString();

                        if (word == "-n" || word == "[n" || word == "/n")
                        {
                            offset += 1;
                            continue;
                        }

                        if (word == "--" || word == "//")
                        {
                            offset = SkipComment(document, offset);
                            continue;
                        }

                        offset += word.Length - 1; MarkBlock(word, document, offset - (word.Length - 1), foldMarkers, true);
                        break;
                    case 'f':
                        offset += 7; MarkBlock("function", document, offset, foldMarkers);
                        break;
                    /*case 'e':
                        offset += 2; MarkBlock("end", document, offset, foldMarkers);
                        break;*/
                    case 'd':
                        offset += 1; MarkBlock("do", document, offset, foldMarkers);
                        break;
                    case 't':
                        offset += 3; MarkBlock("then", document, offset, foldMarkers);
                        break;
                    case '{':
                        offset = MarkMethod(document, offset, foldMarkers);
                        break;
                    /*case '\r':
                    case '\n':
                        offset += 1; MarkBlock(document.GetCharAt(offset).ToString(), document, offset, foldMarkers);
                        break;*/
                    default:
                        int endOfIdentifier = TextHelper.FindEndOfIdentifier(document, offset);
                        if (endOfIdentifier > 0)
                            offset = endOfIdentifier + 1;
                        else
                            ++offset;
                        break;
                }
            }
        }


        /// <summary>
        /// Skips object comments that start at the current offset.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="offset">The offset.</param>
        /// <returns>The index of the next character after the comments.</returns>
        private static int SkipComment(IDocument document, int offset)
        {
            if (offset >= document.TextLength - 1)
                return offset + 1;

            char current = document.GetCharAt(offset);
            char next = document.GetCharAt(offset + 1);

            if (current == '/' && next == '/')
            {
                // Skip line comment "//"
                LineSegment line = document.GetLineSegmentForOffset(offset);
                int offsetOfNextLine = line.Offset + line.TotalLength;
                return offsetOfNextLine;
            }
            else if (current == '-' && next == '-' && !(document.GetCharAt(offset + 2) == '[' && document.GetCharAt(offset + 3) == '['))
            {
                LineSegment line = document.GetLineSegmentForOffset(offset);
                int offsetOfNextLine = line.Offset + line.TotalLength;
                return offsetOfNextLine;
            }
            else if (current == '-' && next == '-' && document.GetCharAt(offset + 2) == '[' && document.GetCharAt(offset + 3) == '[')
            {
                offset += 4;
                while (offset + 1 < document.TextLength)
                {
                    if (document.GetCharAt(offset) == ']' && document.GetCharAt(offset + 1) == ']')
                    {
                        offset = offset + 2;
                        break;
                    }
                    offset++;
                }
                return offset;
            }
            else if (current == '/' && next == '*')
            {
                // Skip block comment "/* params object[] anything */"
                offset += 2;
                while (offset + 1 < document.TextLength)
                {
                    if (document.GetCharAt(offset) == '*' && document.GetCharAt(offset + 1) == '/')
                    {
                        offset = offset + 2;
                        break;
                    }
                    offset++;
                }
                return offset;
            }
            else
            {
                return offset + 1;
            }
        }


        /// <summary>
        /// Marks the block that starts at the current offset.
        /// </summary>
        /// <param name="name">The identifier of the block (e.g. "class", "struct").</param>
        /// <param name="document">The document.</param>
        /// <param name="offset">The offset of the identifier.</param>
        /// <param name="foldMarkers">The fold markers.</param>
        /// <returns>The index of the next character after the block.</returns>
        private static int MarkBlock(string name, IDocument document, int offset, List<Fold> foldMarkers, bool Brackets = false)
        {
            if (offset >= document.TextLength)
                return offset;

            string word = TextHelper.GetIdentifierAt(document, offset);
            /*if (word.Split(' ').Where(x => x == name) != null)
                word = name;*/
            if (Brackets) word = name;
            if (word == name || word == name + "()")
            {
                offset += word.Length;
                while (offset < document.TextLength)
                {
                    char c = document.GetCharAt(offset);
                    char n = document.GetCharAt(offset + 1);
                    char d = document.GetCharAt(offset + 2);
                    /*if (word == "end" || c == '\n' || c == '\r')
                    {
                        offset++;
                        break;
                    }*/
                    if (word == "--[[" || word == "[[" || word == "/*")
                    {
                        int startOffset = offset;
                        while (Char.IsWhiteSpace(document.GetCharAt(startOffset - 1)))
                            startOffset--;

                        int offsetOfClosingBracket = TextHelper.FindClosingWord(document, offset + 1, word, (word == "--[[" || word == "[[" ? "]]" : "*/"));
                        if (offsetOfClosingBracket > 0)
                        {
                            int length = offsetOfClosingBracket - startOffset + 1;
                            foldMarkers.Add(new Fold(document, startOffset, length + 2, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                        else
                        {
                            foldMarkers.Add(new Fold(document, startOffset, document.TextLength, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                    }
                    else if (word == "function" || word == name + "()")
                    {
                        int startOffset = offset;
                        while (Char.IsWhiteSpace(document.GetCharAt(startOffset - 1)))
                            startOffset--;

                        int offsetOfClosingBracket = TextHelper.FindClosingWord(document, offset, word, "end");
                        if (offsetOfClosingBracket > 0)
                        {
                            int length = offsetOfClosingBracket - startOffset + 1;
                            foldMarkers.Add(new Fold(document, startOffset, length + 2, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                        else
                        {
                            foldMarkers.Add(new Fold(document, startOffset, document.TextLength, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                    }
                    else if (word == "do")
                    {
                        int startOffset = offset;
                        while (Char.IsWhiteSpace(document.GetCharAt(startOffset - 1)))
                            startOffset--;

                        int offsetOfClosingBracket = TextHelper.FindClosingWord(document, offset + 1, "do", "end");
                        if (offsetOfClosingBracket > 0)
                        {
                            int length = (offsetOfClosingBracket) - startOffset + 1;
                            foldMarkers.Add(new Fold(document, startOffset, length, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                        else
                        {
                            foldMarkers.Add(new Fold(document, startOffset, document.TextLength, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                    }
                    else if (word == "then")
                    {
                        int startOffset = offset;
                        while (Char.IsWhiteSpace(document.GetCharAt(startOffset - 1)))
                            startOffset--;

                        int offsetOfClosingBracket = TextHelper.FindClosingWord(document, offset + 1, "then", "end");
                        if (offsetOfClosingBracket > 0)
                        {
                            int length = (offsetOfClosingBracket) - startOffset + 1;
                            foldMarkers.Add(new Fold(document, startOffset, length, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                        else
                        {
                            foldMarkers.Add(new Fold(document, startOffset, document.TextLength, "{params object[] anything}", false));

                            // Skip to offset after '{'.
                            offset++;
                            break;
                        }
                    }
                    offset++;
                }
            }
            else
            {
                // Skip to next word
                offset += word.Length;
            }
            return offset;
        }




        /// <summary>
        /// Marks the method whose block starts at the given offset.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="offset">The offset of the method body ('{').</param>
        /// <param name="folds">The fold markers.</param>
        /// <returns>The index of the next character after the method.</returns>
        /// 

        // USED FOR TABLES
        private static int MarkMethod(IDocument document, int offset, List<Fold> folds)
        {
            if (offset >= document.TextLength)
                return offset;

            int startOffset = offset;
            while (startOffset - 1 > 0 && Char.IsWhiteSpace(document.GetCharAt(startOffset - 1)))
                startOffset--;

            int offsetOfClosingBracket = TextHelper.FindClosingBracket(document, offset + 1, '{', '}');
            if (offsetOfClosingBracket > 0)
            {
                int offsetOfNextCharacter = TextHelper.FindFirstNonWhitespace(document, offsetOfClosingBracket + 1);
                if (offsetOfNextCharacter < document.TextLength && document.GetCharAt(offsetOfNextCharacter) == '\n')
                    return offset + 1;

                int length = offsetOfClosingBracket - startOffset + 1;
                folds.Add(new Fold(document, startOffset, length, "{params object[] anything}", false));

                // Skip to offset after '}'. (Ignore nested blocks.)
                offset = offsetOfClosingBracket + 1;
                return offset;
            }
            else
            {
                return offset + 1;
            }
        }


        /// <summary>
        /// Marks all regions ("#region") in the document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="folds">The fold markers.</param>
        private static void MarkRegions(IDocument document, List<Fold> folds)
        {
            FindAndMarkRegions(document, 0, folds);
        }


        /// <summary>
        /// Finds and marks all regions.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="offset">The offset where the search starts.</param>
        /// <param name="folds">The fold markers.</param>
        /// <returns>The index of the next character after the all regions.</returns>
        /// <remarks>
        /// This method returns when it finds a "#endregion" string that does not have
        /// a "#region" statement after <paramref name="offset"/>. In this case it 
        /// returns the index of the next character after the "#endregion" statement.
        /// </remarks>
        private static int FindAndMarkRegions(IDocument document, int offset, List<Fold> folds)
        {
            if (offset >= document.TextLength)
                return offset;

            while (offset < document.TextLength)
            {
                char c = document.GetCharAt(offset);
                switch (c)
                {
                    case '-':
                    case '/':
                        // Skip comments
                        offset = SkipComment(document, offset);
                        break;
                    case '#':
                        string word = TextHelper.GetIdentifierAt(document, offset + 1);
                        if (word == "region")
                        {
                            offset = MarkRegion(document, offset, folds);
                        }
                        else if (word == "endregion")
                        {
                            return offset + "endregion".Length + 1;
                        }
                        else
                        {
                            offset++;
                        }
                        break;
                    default:
                        // Skip to next word
                        int endOfIdentifier = TextHelper.FindEndOfIdentifier(document, offset);
                        if (endOfIdentifier > 0)
                            offset = endOfIdentifier + 1;
                        else
                            ++offset;
                        break;
                }
            }
            return offset;
        }


        /// <summary>
        /// Marks the region that starts at the given offset.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="folds">The fold markers.</param>
        /// <returns>The index of the next character after the region.</returns>
        private static int MarkRegion(IDocument document, int offset, List<Fold> folds)
        {
            if (offset >= document.TextLength)
                return offset;

            if (document.GetCharAt(offset) == '#')
            {
                int startOffset = offset;
                offset++;
                string word = TextHelper.GetIdentifierAt(document, offset);
                if (word == "region")
                {
                    offset += "region".Length;

                    // Find label
                    LineSegment line = document.GetLineSegmentForOffset(offset);
                    int lineEnd = line.Offset + line.Length;
                    int labelLength = lineEnd - offset;
                    string label = document.GetText(offset, labelLength);
                    label = label.Trim();
                    if (label.Length == 0)
                        label = "#region";

                    // Find and mark subregions
                    offset = FindAndMarkRegions(document, lineEnd, folds);

                    if (offset <= document.TextLength)
                    {
                        int length = offset - startOffset;
                        folds.Add(new Fold(document, startOffset, length, label, true));
                        offset++;
                    }
                }
            }
            else
            {
                offset++;
            }
            return offset;
        }
    }
}
