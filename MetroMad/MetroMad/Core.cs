/*  Core.cs - Mother of the program.

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
using System.Linq;
using System.Text;

using MetroMad.Data;
using MetroMad.Lua;

using System.Drawing;

using DigitalRune.Windows.TextEditor.Highlighting;

namespace MetroMad
{
    public static class Core
    {
        //public Dictionary<int, CoreData> CData { get; set; }

        public static gLuaInterface lua { get; set; }

        public static FileData ChoosedData { get; set; }

        public static List<CMethodInfo> Methods { get; set; }

        public static List<FileData> Store { get; set; }

        public static mm form { get; set; }

        public static void ChangeTheme(int id) // LUA ACCESS TO THEME CHANGING
        {
            if (id == 0)
                form.Theme = MetroFramework.MetroThemeStyle.Default;
            else if (id == 1)
                form.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                form.Theme = MetroFramework.MetroThemeStyle.Dark;

            form.devmad.ActiveTextAreaControl.VScrollBar.Theme = form.devmad.ActiveTextAreaControl.HScrollBar.Theme = form.Theme;
        }

        /// <summary>
        /// Called right after form is initialized and Core's form changed to existing one.
        /// </summary>
        public static void Init()
        {
            Store = new List<FileData>();
            Methods = new List<CMethodInfo>();

            NETMethod.Init(Methods);

            var data = new FileData();
            data.Name = "default.lua";
            data.Path = System.Windows.Forms.Application.StartupPath + '\\'.ToString();
            data.LastContent = data.Content = form.devmad.Document.TextContent;
            ChoosedData = data;
            Store.Add(data);
            RefreshFiles();
        }

        public static void RefreshFiles()
        {
            form.filelist.TabPages.Clear();
            foreach (var db in Core.Store)
            {
                form.filelist.TabPages.Add(db.Path + db.Name, db.Name);
            }
        }

        public static void RefreshDocument()
        {
            if (ChoosedData == null)
            {
                form.devmad.Document.TextContent = "";
                return;
            }

            form.devmad.Document.TextContent = ChoosedData.Content;
        }

        /*public SerializableData GetSerializable()
        {
            var dt = new SerializableData();

            var dcolor = new Dictionary<int, Color>();
            var dkeyws = new Dictionary<int, string[]>();

            foreach (var db in CData)
            {
                dcolor[db.Key] = db.Value.Color;
                dkeyws[db.Key] = db.Value.GetKeywords();
            }

            return dt;
        }*/
    }
}
