//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// /*  AutoGeneratedCode.cs - This class Is autogenerated.
//
//    Copyright (C) 2014  Ali Deym (https://github.com/111WARLOCK111/).
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//*/
namespace MetroMad.Lua.gLua {
    using System;
    
    
    public class ai {
        
        // <realm>Server</realm>
        // <summary>{{Deprecated|The function is broken!}}</summary>
        // <param name="sched">Schedule, see {{Enum|SCHED}}.</param>
        // <return>number|The ID</return>
        public virtual int GetScheduleID(string sched) {
            return 1;
        }
        
        // <summary>Returns the task Id corresponding to the given task name.</summary>
        // <param name="taskName">The task name to get the ID of.</param>
        // <return>number|The ID</return>
        public virtual int GetTaskID(string taskName) {
            return 1;
        }
    }
}
