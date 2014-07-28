/*  FileDialog.cs - Notifies whether the files need save or not while application is about to exit.

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

using MetroFramework.Forms;
using System.Threading;

namespace MetroMad
{
    public partial class FileDialog : MetroForm
    {

        public FileDialog()
        {
            InitializeComponent();
        }

        private void OnSave(object sender, EventArgs e)
        {
            Core.ChoosedData.Save();
            foreach (var db in Core.Store)
            {
                if (db.Changed)
                    db.Save();
            }
            new Thread(() => { Thread.Sleep(2000); Application.Exit(); }).Start();
        }

        private void OnNoSave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
