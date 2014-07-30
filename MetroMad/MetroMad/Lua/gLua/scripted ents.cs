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
    
    
    public class scripted ents {
        
        // <realm>Shared</realm>
        // <summary>Defines an alias string that can be used to refer to another classname</summary>
        // <param name="alias">A new string which can be used to refer to another classname.</param>
        // <param name="classname">The classname the alias should refer to.</param>
        public static void Alias(string alias, string classname) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a copy of the ENT table for a class, including functions defined by the base class</summary>
        // <param name="classname">The classname of the ENT table to return, can be an alias.</param>
        public static void Get(string classname) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a copy of the list of all ENT tables registered</summary>
        public static void GetList() {
        }
        
        // <realm>Shared</realm>
        // <summary>Retrieves a member of entity's table.</summary>
        // <param name="class">Entity's class name.</param>
        // <param name="name">Name of member to retrieve.</param>
        public static void GetMember(string @class, string name) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a list of all ENT tables which contain either ENT.Spawnable or ENT.AdminSpawnable</summary>
        public static void GetSpawnable() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the actual ENT table for a class. Modifying functions/variables in this table will change newly spawned entities</summary>
        // <param name="classname">The classname of the ENT table to return.</param>
        public static void GetStored(string classname) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the 'type' of a class, this will one of the following: 'anim', 'ai', 'brush', 'point'.</summary>
        // <param name="classname">The classname to check.</param>
        public static void GetType(string classname) {
        }
        
        // <realm>Shared</realm>
        // <summary>Runs {{LibraryFunction|baseclass|Set}} on every ENT in {{LibraryFunction|scripted_ents|GetList}}.</summary>
        public static void OnLoaded() {
        }
        
        // <realm>Shared</realm>
        // <summary>Registers an ENT table with a classname. Reregistering an existing classname will automatically update the functions of all existing entities of that class.</summary>
        // <param name="ENT">The ENT table to register.</param>
        // <param name="classname">The classname to register.</param>
        public static void Register(table ENT, string classname) {
        }
    }
}
