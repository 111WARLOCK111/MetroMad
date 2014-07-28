/*  Util.cs - Data management system helper.

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

namespace MetroMad.Data
{
    public static class Util
    {
        public static void LoadFile(string[] loading)
        {
            foreach (var db in loading)
            {
                bool ToContinue = false;
                foreach (var mb in Core.Store)
                {
                    if (mb.Path + "/" + mb.Name == db)
                    {
                        mb.Reload();
                        ToContinue = true;
                    }
                }
                if (ToContinue) continue;
                FileData.CreateFrom(db);
            }
        }
    }
}
