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
    
    
    public class killicon {
        
        // <realm>Client</realm>
        // <summary>Creates new kill icon using a texture.</summary>
        // <param name="class">Weapon or entity class.</param>
        // <param name="texture">Path to the texture.</param>
        // <param name="color">Color of the kill icon.</param>
        public virtual void Add(string @class, string texture, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Creates kill icon from existing one.</summary>
        // <param name="new_class">New class of the kill icon.</param>
        // <param name="existing_class">Already existing kill icon class.</param>
        public virtual void AddAlias(string new_class, string existing_class) {
        }
        
        // <realm>Client</realm>
        // <summary>Adds kill icon for given weapon/entity class using special font.</summary>
        // <param name="class">Weapon or entity class.</param>
        // <param name="font">Font to be used.</param>
        // <param name="symbol">The symbol to be used.</param>
        // <param name="color">Color of the killicon.</param>
        public virtual void AddFont(string @class, string font, string symbol, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a kill icon.</summary>
        // <param name="x">X coordinate of the icon.</param>
        // <param name="y">Y coordinate of the icon.</param>
        // <param name="name">Classname of the kill icon.</param>
        // <param name="alpha">Alpha/transparency value ( 0 - 255 ) of the icon.</param>
        public virtual void Draw(float x, float y, string name, float alpha) {
        }
        
        // <realm>Client</realm>
        // <summary>Checks if kill icon exists for given class.</summary>
        // <param name="class">The class to test.</param>
        // <return>boolean|Returns true if kill icon exists</return>
        public virtual bool Exists(string @class) {
            return true;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the size of a kill icon.</summary>
        // <param name="name">Classname of the kill icon.</param>
        // <return>number|Width of the kill icon</return>
        public virtual int GetSize(string name) {
            return 1;
        }
    }
}
