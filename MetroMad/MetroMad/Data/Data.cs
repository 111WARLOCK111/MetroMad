﻿/*  Data.cs - An unused data object.

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

using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MetroMad.Data
{
    [Serializable]
    public class SerializableData : IDeserializationCallback
    {
        public Dictionary<int, string[]> Keywords { get; set; }

        public Dictionary<int, Color> KeyColor { get; set; }

        public void OnDeserialization(object sender)
        {
            Keywords.OnDeserialization(sender);
            KeyColor.OnDeserialization(sender);
        }
    }

    public class CoreData
    {
        public List<string> Keywords { get; set; }

        public Color Color { get; set; }

        public string[] GetKeywords()
        {
            return Keywords.ToArray();
        }
    }
}
