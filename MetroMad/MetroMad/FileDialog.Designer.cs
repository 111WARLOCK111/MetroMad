/*  FileDialog.Designer.cs - Design of file dialog.

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
    partial class FileDialog
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
            this.labone = new MetroFramework.Controls.MetroLabel();
            this.labtwo = new MetroFramework.Controls.MetroLabel();
            this.save = new MetroFramework.Controls.MetroButton();
            this.cancel = new MetroFramework.Controls.MetroButton();
            this.nosave = new MetroFramework.Controls.MetroButton();
            this.savefile = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // labone
            // 
            this.labone.AutoSize = true;
            this.labone.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labone.Location = new System.Drawing.Point(23, 39);
            this.labone.Name = "labone";
            this.labone.Size = new System.Drawing.Size(331, 25);
            this.labone.TabIndex = 0;
            this.labone.Text = "There are some modified files that aren\'t";
            // 
            // labtwo
            // 
            this.labtwo.AutoSize = true;
            this.labtwo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labtwo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labtwo.Location = new System.Drawing.Point(23, 75);
            this.labtwo.Name = "labtwo";
            this.labtwo.Size = new System.Drawing.Size(333, 25);
            this.labtwo.TabIndex = 1;
            this.labtwo.Text = "Saved yet, Would you like to save them?";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(23, 115);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 23);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.OnSave);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(268, 115);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 23);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // nosave
            // 
            this.nosave.Location = new System.Drawing.Point(146, 115);
            this.nosave.Name = "nosave";
            this.nosave.Size = new System.Drawing.Size(90, 23);
            this.nosave.TabIndex = 5;
            this.nosave.Text = "Don\'t save";
            this.nosave.Click += new System.EventHandler(this.OnNoSave);
            // 
            // savefile
            // 
            this.savefile.AutoSize = true;
            this.savefile.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.savefile.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.savefile.Location = new System.Drawing.Point(142, 14);
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(103, 25);
            this.savefile.TabIndex = 6;
            this.savefile.Text = "File Saving";
            // 
            // FileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 152);
            this.ControlBox = false;
            this.Controls.Add(this.savefile);
            this.Controls.Add(this.nosave);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.labtwo);
            this.Controls.Add(this.labone);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FileDialog";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labone;
        private MetroFramework.Controls.MetroLabel labtwo;
        private MetroFramework.Controls.MetroButton save;
        private MetroFramework.Controls.MetroButton cancel;
        private MetroFramework.Controls.MetroButton nosave;
        private MetroFramework.Controls.MetroLabel savefile;
    }
}