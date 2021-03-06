﻿/*  MethodInfo.cs - Method Information for lua functions.

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

namespace MetroMad.Lua
{
    public class CMethodInfo
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Realm { get; set; }

        public string Return { get; set; }

        public MethodArgs[] Arguements { get; set; }
    }

    public class MethodArgs
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }
    }
}
