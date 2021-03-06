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
    
    
    public class derma {
        
        // <realm>Client</realm>
        // <summary>Gets the color from a Derma skin of a panel and returns default color if not found</summary>
        // <param name="default">The default color in case of failure.</param>
        public virtual void Color(table @default) {
        }
        
        // <realm>Client</realm>
        // <summary>Defines a new Derma control with an optional base</summary>
        // <param name="name">Name of the newly created control.</param>
        // <param name="description">Description of the control.</param>
        // <param name="tab">Table containing control methods and properties.</param>
        // <param name="base">Derma control to base the new control off of.</param>
        // <return>table|A table containing the new control's methods and properties</return>
        public virtual table DefineControl(string name, string description, table tab, string @base) {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Defines a new skin so that it is usable by Derma. The default skin can be found in "garrysmod/lua/skins/default.lua"</summary>
        // <param name="name">Name of the skin.</param>
        // <param name="descriptions">Description of the skin.</param>
        // <param name="skin">Table containing skin data.</param>
        public virtual void DefineSkin(string name, string descriptions, table skin) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the [[derma/Controls|derma.Controls]] table.</summary>
        // <return>table|A listing of all available derma-based controls.</return>
        public virtual table GetControlList() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Returns the default skin table, which can be changed with the hook [[GM/ForceDermaSkin]]</summary>
        // <return>table|Skin table</return>
        public virtual table GetDefaultSkin() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Returns the skin table of the skin with the supplied name</summary>
        // <param name="name">Name of skin.</param>
        // <return>table|Skin table</return>
        public virtual table GetNamedSkin(string name) {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Returns a copy of the table containing every Derma skin</summary>
        // <return>table|Table of every DermaS skin</return>
        public virtual table GetSkinTable() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Clears all cached panels so that they reassess which skin they should be using.</summary>
        public virtual void RefreshSkins() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns how many times {{LibraryFunction|derma|RefreshSkins}} has been called.</summary>
        // <return>number|Amount of times {{LibraryFunction|derma|RefreshSkins}} has been called.</return>
        public virtual int SkinChangeIndex() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Calls the specified hook for the given panel</summary>
        // <param name="type">The type of hook to run.</param>
        // <param name="name">The name of the hook to run.</param>
        // <param name="panel">The panel to call the hook for.</param>
        // <param name="w">The width of the panel.</param>
        // <param name="h">The height of the panel.</param>
        // <return>any|The returned variable from the skin hook</return>
        public virtual any SkinHook(string type, string name, Panel panel, float w, float h) {
            return new any();
        }
        
        // <realm>Client</realm>
        // <summary>Returns a function to draw a specified texture of panels skin.</summary>
        // <param name="name">The identifier of the texture.</param>
        // <param name="pnl">Panel to get the skin of.</param>
        // <param name="fallback">What to return if we failed to retrieve the texture.</param>
        // <return>function|A function that is created with the {{Lib|GWEN}} library to draw a texture.</return>
        public virtual function SkinTexture(string name, Panel pnl, any fallback) {
            return new function();
        }
    }
}
