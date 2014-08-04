/*  MM.Designer.cs - Private members of the designer/UI.

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

namespace MetroMad
{
    partial class mm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up object resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mm));
            this.devmad = new DigitalRune.Windows.TextEditor.TextEditorControl();
            this.filelist = new MetroFramework.Controls.MetroTabControl();
            this.save = new System.Windows.Forms.Button();
            this.saveas = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.github = new System.Windows.Forms.Button();
            this.clipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // devmad
            // 
            this.devmad.IndentStyle = DigitalRune.Windows.TextEditor.Properties.IndentStyle.Auto;
            this.devmad.Location = new System.Drawing.Point(24, 106);
            this.devmad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.devmad.Name = "devmad";
            this.devmad.ShowVRuler = false;
            this.devmad.Size = new System.Drawing.Size(888, 492);
            this.devmad.TabIndex = 4;
            this.devmad.Text = resources.GetString("devmad.Text");
            this.devmad.CompletionRequest += new System.EventHandler<DigitalRune.Windows.TextEditor.Completion.CompletionEventArgs>(this.OnRequesting);
            this.devmad.InsightRequest += new System.EventHandler<DigitalRune.Windows.TextEditor.Insight.InsightEventArgs>(this.OnSight);
            this.devmad.DocumentChanged += new System.EventHandler<DigitalRune.Windows.TextEditor.Document.DocumentEventArgs>(this.OnFolding);
            // 
            // filelist
            // 
            this.filelist.Location = new System.Drawing.Point(24, 63);
            this.filelist.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.filelist.Name = "filelist";
            this.filelist.Size = new System.Drawing.Size(888, 39);
            this.filelist.TabIndex = 5;
            this.filelist.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnSelect);
            // 
            // save
            // 
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Image = global::MetroMad.Properties.Resources.save;
            this.save.Location = new System.Drawing.Point(298, 20);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(37, 38);
            this.save.TabIndex = 21;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.OnSave);
            // 
            // saveas
            // 
            this.saveas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveas.FlatAppearance.BorderSize = 0;
            this.saveas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveas.Image = global::MetroMad.Properties.Resources.saveas;
            this.saveas.Location = new System.Drawing.Point(341, 20);
            this.saveas.Name = "saveas";
            this.saveas.Size = new System.Drawing.Size(37, 38);
            this.saveas.TabIndex = 20;
            this.saveas.UseVisualStyleBackColor = true;
            this.saveas.Click += new System.EventHandler(this.OnSaveas);
            // 
            // load
            // 
            this.load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Image = global::MetroMad.Properties.Resources.load;
            this.load.Location = new System.Drawing.Point(384, 20);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(37, 38);
            this.load.TabIndex = 19;
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.OnLoad);
            // 
            // delete
            // 
            this.delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Image = global::MetroMad.Properties.Resources.delete;
            this.delete.Location = new System.Drawing.Point(427, 20);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(37, 38);
            this.delete.TabIndex = 18;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.OnDelete);
            // 
            // debug
            // 
            this.debug.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.debug.FlatAppearance.BorderSize = 0;
            this.debug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.debug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debug.Image = global::MetroMad.Properties.Resources.debug;
            this.debug.Location = new System.Drawing.Point(470, 20);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(37, 38);
            this.debug.TabIndex = 17;
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.OnDebug);
            // 
            // copy
            // 
            this.copy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.copy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Image = global::MetroMad.Properties.Resources.copy;
            this.copy.Location = new System.Drawing.Point(556, 20);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(37, 38);
            this.copy.TabIndex = 16;
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.OnCopy);
            // 
            // cut
            // 
            this.cut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cut.FlatAppearance.BorderSize = 0;
            this.cut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Image = global::MetroMad.Properties.Resources.cut;
            this.cut.Location = new System.Drawing.Point(599, 20);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(37, 38);
            this.cut.TabIndex = 15;
            this.cut.UseVisualStyleBackColor = true;
            this.cut.Click += new System.EventHandler(this.OnCut);
            // 
            // github
            // 
            this.github.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.github.FlatAppearance.BorderSize = 0;
            this.github.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.github.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.github.Image = global::MetroMad.Properties.Resources.github;
            this.github.Location = new System.Drawing.Point(642, 20);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(37, 38);
            this.github.TabIndex = 14;
            this.github.UseVisualStyleBackColor = true;
            this.github.Click += new System.EventHandler(this.OnGithub);
            // 
            // clipboard
            // 
            this.clipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clipboard.FlatAppearance.BorderSize = 0;
            this.clipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clipboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clipboard.Image = global::MetroMad.Properties.Resources.clipboard;
            this.clipboard.Location = new System.Drawing.Point(513, 20);
            this.clipboard.Name = "clipboard";
            this.clipboard.Size = new System.Drawing.Size(37, 38);
            this.clipboard.TabIndex = 11;
            this.clipboard.UseVisualStyleBackColor = true;
            this.clipboard.Click += new System.EventHandler(this.OnCopyboard);
            // 
            // mm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 624);
            this.Controls.Add(this.save);
            this.Controls.Add(this.saveas);
            this.Controls.Add(this.load);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.cut);
            this.Controls.Add(this.github);
            this.Controls.Add(this.clipboard);
            this.Controls.Add(this.filelist);
            this.Controls.Add(this.devmad);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "mm";
            this.Padding = new System.Windows.Forms.Padding(20, 61, 20, 20);
            this.ShowIcon = false;
            this.Text = "MetroMad - GLua Editor";
            this.Load += new System.EventHandler(this.Init);
            this.Resize += new System.EventHandler(this.OnResize);
            this.ResumeLayout(false);

        }

        #endregion

        public DigitalRune.Windows.TextEditor.TextEditorControl devmad;
        public MetroFramework.Controls.MetroTabControl filelist;
        private System.Windows.Forms.Button clipboard;
        private System.Windows.Forms.Button github;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button saveas;
        private System.Windows.Forms.Button save;

    }
}