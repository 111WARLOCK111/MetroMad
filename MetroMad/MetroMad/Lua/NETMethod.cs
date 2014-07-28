/*  NETMethod.cs - Coverts C# functions to Quick search info.

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

using System.Reflection;

using JimBlackler.DocsByReflection;

namespace MetroMad.Lua
{
    public static class NETMethod
    {
        public static void Init(List<CMethodInfo> ms)
        {
            var assembly = Assembly.GetExecutingAssembly();

            foreach (var db in assembly.GetTypes())
            {
                if (db.Namespace != "MetroMad.Lua.gLua") continue;

                var meth = db.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

                foreach (var sb in meth)
                {
                    var cm = new CMethodInfo();

                    var tp = sb.DeclaringType.ToString().Split('.');

                    cm.Name = tp[tp.Length - 1] + "." + sb.Name;

                    var param = sb.GetParameters();

                    cm.Arguements = new MethodArgs[param.Length];

                    int count = 0;
                    foreach (var pm in param)
                    {
                        cm.Arguements[count] = new MethodArgs();

                        cm.Arguements[count].Name = pm.Name;

                        var ptype = pm.ParameterType.ToString().Split('.');

                        cm.Arguements[count].Type = ptype[ptype.Length - 1];

                        var xm = DocsByReflection.XMLFromMember(sb);

                        cm.Description = xm["summary"].InnerText.Trim();

                        var name = "//param[@name='" + pm.Name + "']";

                        cm.Arguements[count].Description = xm.SelectSingleNode(name).InnerText.Trim();

                        count++;
                    }

                    ms.Add(cm);
                }
            }
        }
    }
}
