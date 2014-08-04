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
    
    
    public class serverlist {
        
        // <realm>Menu</realm>
        // <summary>Queries a server for its player list.</summary>
        // <param name="ip">The IP address of the server, including the port.</param>
        // <param name="callback">The function to be called if and when the request finishes. Function has one argument, a table containing tables with player info.</param>
        public virtual void PlayerList(string ip, function callback) {
        }
        
        // <realm>Menu</realm>
        // <summary>Queries the master server for server list.</summary>
        // <param name="data">The information about what kind of servers we want. Has next fields:.</param>
        public virtual void Query(table data) {
        }
    }
}
