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
    
    
    public class usermessage {
        
        // <realm>Shared</realm>
        // <summary>Returns a table of every usermessage hook</summary>
        // <return>table|hooks</return>
        public virtual table GetTable() {
            return new table();
        }
        
        // <realm>Shared</realm>
        // <summary>Sets a hook for the specified to be called when a usermessage with the specified name arrives</summary>
        // <param name="name">The message name to hook to.</param>
        // <param name="callback">The function to be called if the specified message was received.</param>
        public virtual void Hook(string name, function callback) {
        }
        
        // <realm>Shared</realm>
        // <summary>Called by the engine when a usermessage arrives, this method calls the hook function specified by {{LibraryFunction|usermessage|Hook}} if any.</summary>
        // <param name="name">The message name.</param>
        // <param name="msg">The message.</param>
        public virtual void IncomingMessage(string name, bf_read msg) {
        }
    }
}
