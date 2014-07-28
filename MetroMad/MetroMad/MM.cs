/*  MM.cs - User Interface and the draw engine.

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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroMad.gLua;
using MetroMad.Data;

namespace MetroMad
{
    public partial class mm : MetroFramework.Forms.MetroForm
    {
        // LuaLexer lx { get; set; }

        public mm()
        {
            InitializeComponent();
        }

        private void Init(object sender, EventArgs e)
        {
            Core.form = this;

            Core.Init();

            devmad.SetHighlighting("GLua");
            devmad.Document.FormattingStrategy = new GLuaFormattingStrategy();
            devmad.Document.FoldingManager.FoldingStrategy = new GLuaFoldingStrategy();
            devmad.EnableFolding = true;
        }

        private void OnFolding(object sender, DigitalRune.Windows.TextEditor.Document.DocumentEventArgs e)
        {
            devmad.Document.FoldingManager.Folds = devmad.Document.FoldingManager.FoldingStrategy.GenerateFolds(devmad.Document, "default.lua", null);
        }

        private void OnResize(object sender, EventArgs e)
        {
            devmad.Size = new Size(this.Size.Width - 46, this.Size.Height - 132);
            filelist.Size = new Size(this.Size.Width - 46, 39);
        }

        private void OnSave(object sender, EventArgs e)
        {

        }

        private void OnSaveas(object sender, EventArgs e)
        {

        }

        private void OnLoad(object sender, EventArgs e)
        {
            var db = new OpenFileDialog();
            db.ShowDialog();
            Util.LoadFile(db.FileNames);
        }

        private void OnDelete(object sender, EventArgs e)
        {

        }

        private void OnDebug(object sender, EventArgs e)
        {

        }

        private void OnCopyboard(object sender, EventArgs e)
        {

        }

        private void OnCopy(object sender, EventArgs e)
        {

        }

        private void OnCut(object sender, EventArgs e)
        {

        }

        private void OnGithub(object sender, EventArgs e)
        {

        }

        private void OnRequesting(object sender, DigitalRune.Windows.TextEditor.Completion.CompletionEventArgs e)
        {

        }

        private void OnSight(object sender, DigitalRune.Windows.TextEditor.Insight.InsightEventArgs e)
        {

        }

        private void OnSelect(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == null) return;
            FileData dt = null;
            foreach (var db in Core.Store)
            {
                if (db.Path + db.Name == e.TabPage.Name)
                    dt = db;
            }
            Core.ChoosedData = dt;

            Core.RefreshDocument();
        }
    }
}
