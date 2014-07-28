/*  File.cs - glua file lib.

    Copyright (C) 2014  Ali Deym (https://github.com/111WARLOCK111/).

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

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
using System.Linq;
using System.Text;

using System.IO;

namespace MetroMad.Lua.gLua
{
    public static class file
    {
        /// <summary>
        /// Append into file.
        /// </summary>
        /// <param name="file">File name.</param>
        /// <param name="content">Content to write in file.</param>
        public static void Append(string file, string content) { }

        /// <summary>
        /// Creates a directory in data folder.
        /// </summary>
        /// <param name="dir">Name of directory.</param>
        public static void CreateDir(string dir) { }

        /// <summary>
        /// Deletes a file that is relative to the data folder. You can't remove any files outside of data folder.
        /// </summary>
        /// <param name="file"></param>
        public static void Delete(string file) { }


        /// <summary>
        /// Returns a boolean of whether the file or directory exists or not.
        /// </summary>
        /// <param name="file">The file or directory's name.</param>
        /// <param name="mod">The path of where to look for the file. Default: DATA</param>
        /// <returns>bool: whether the file or directory exists or not.</returns>
        public static bool Exists(string file, string mod) { return true; }


        /// <summary>
        /// Returns a table of files and directories.
        /// </summary>
        /// <param name="file">The directories/files to search for.</param>
        /// <param name="mod">The path to look for the files and directories in.</param>
        /// <param name="sorting">Optional: The sorting to be used, optional.</param>
        /// <returns>Table: Files. Table: Directories.</returns>
        public static bool Find(string file, string mod, string sorting = "nameasc") { return true; }


        /// <summary>
        /// Returns if the given file is a directory.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="mod"></param>
        /// <returns></returns>
        public static bool IsDir(string file, string mod) { return true; }

        public static StreamWriter Open(string file, string mod, string c) { return new StreamWriter(file); }
    }
}
