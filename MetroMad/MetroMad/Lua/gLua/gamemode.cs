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
    
    
    public class gamemode {
        
        // <realm>Shared</realm>
        // <summary>Called by the engine to call a hook within the loaded gamemode.</summary>
        // <param name="name">The name of the hook to call.</param>
        // <param name="arg">The arguements.</param>
        public static void Call(string name, any arg) {
        }
        
        // <realm>Shared</realm>
        // <summary>This returns the internally stored gamemode table.</summary>
        // <param name="name">The name of the gamemode you want to get.</param>
        public static void Get(string name) {
        }
        
        // <realm>Shared</realm>
        // <summary>Used to register your gamemode with the engine</summary>
        // <param name="gm">Your GM table.</param>
        // <param name="name">Name of your gamemode, lowercase, no spaces.</param>
        // <param name="derived">The gamemode name that your gamemode is derived from.</param>
        public static void Register(table gm, string name, string derived) {
        }
    }
}