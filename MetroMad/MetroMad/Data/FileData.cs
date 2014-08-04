/*  FileData.cs - Data object for each loaded file.

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

using System.IO;

namespace MetroMad.Data
{
    public class FileData : IDisposable
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string LastContent { get; set; }

        public string Content { get; set; }

        public bool Changed { get { return LastContent == Content; } }

        ~FileData()
        {
            Dispose();
            GC.Collect();
        }

        public void Save()
        {
            if (File.Exists(Path + Name))
                File.Delete(Path + Name);

            using (var sw = new StreamWriter(Path + Name))
            {
                sw.Write(Content);
            }

            LastContent = Content;
        }

        public void Reload()
        {
            if (!File.Exists(Path + Name))
            {
                LastContent = "";
                return;
            }

            using (var sr = new StreamReader(Path + Name))
            {
                string total = "";
                string tline = ""; // Temp line.
                while ((tline = sr.ReadLine()) != null)
                {
                    // Current line is not null? Then change the total ;)
                    total += tline;
                }
                LastContent = Content = total;
            }
        }

        public void Dispose()
        {
            Name = Path = LastContent = Content = null;
        }

        public static void CreateFrom(string path)
        {
            if (!File.Exists(path)) return;
            var db = new FileData();
            using (var sr = new StreamReader(path))
            {
                string total = "";
                string tline = ""; // Temp line.
                while ((tline = sr.ReadLine()) != null)
                {
                    // Current line is not null? Then change the total ;)
                    total += tline + '\r'.ToString() + '\n'.ToString();
                }
                db.LastContent = db.Content = total;
            }
            var sp = path.Split('\\');
            db.Path = "";
            for (int i = 0; i < sp.Length; i++)
            {
                if (i == sp.Length - 1)
                    db.Name = sp[i];
                else
                    db.Path += sp[i] + '\\'.ToString();
            }
            Core.Store.Add(db);
            Core.ChoosedData = db;
            Core.RefreshFiles();
        }
    }
}
