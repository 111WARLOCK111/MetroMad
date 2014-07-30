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
    
    
    public class cleanup {
        
        // <realm>Server</realm>
        // <summary>Adds an entity to a player's cleanup list.</summary>
        // <param name="pl">Who's cleanup list to add the entity to.</param>
        // <param name="type">The type of cleanup.</param>
        // <param name="ent">The entity to add to the player's cleanup list.</param>
        public static void Add(Player pl, string type, Entity ent) {
        }
        
        // <realm>Server</realm>
        // <summary>An internal function that is called by the "gmod_admin_cleanup" console command. Allows admins to clean up the server</summary>
        public static void CC_AdminCleanup() {
        }
        
        // <realm>Server</realm>
        // <summary>An internal function that is called by the "gmod_cleanup" console command. Allows players to cleanup their own props.</summary>
        public static void CC_Cleanup() {
        }
        
        // <realm>Server</realm>
        // <summary>Gets the cleanup list.</summary>
        public static void GetList() {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the table of cleanup types.</summary>
        public static void GetTable() {
        }
        
        // <realm>Shared</realm>
        // <summary>Registers a new cleanup type.</summary>
        // <param name="type">Name of type.</param>
        public static void Register(string type) {
        }
        
        // <realm>Server</realm>
        // <summary>Replaces one entity in the cleanup module with another</summary>
        // <param name="from">Old entity.</param>
        // <param name="to">New entity.</param>
        public static void ReplaceEntity(Entity from, Entity to) {
        }
        
        // <realm>Client</realm>
        // <summary>Repopulates the clients cleanup menu</summary>
        public static void UpdateUI() {
        }
    }
}