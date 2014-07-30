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
    
    
    public class player manager {
        
        // <realm>Shared</realm>
        // <summary>Assigns view model hands to player model.</summary>
        // <param name="name">Player model name.</param>
        // <param name="model">Hands model.</param>
        // <param name="skin">Skin to apply to the hands.</param>
        // <param name="bodygroups">Bodygroups to apply to the hands.</param>
        public static void AddValidHands(string name, string model, float skin, string bodygroups) {
        }
        
        // <realm>Shared</realm>
        // <summary>Associates a simplified name with a path to a valid player model.<br/></summary>
        // <param name="name">Simplified name.</param>
        // <param name="model">Valid PlayerModel path.</param>
        public static void AddValidModel(string name, string model) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the entire list of valid player models.</summary>
        public static void AllValidModels() {
        }
        
        // <realm>Shared</realm>
        // <summary>Clears a player's class association by setting their ClassID to 0</summary>
        // <param name="ply">Player to clear class from.</param>
        public static void ClearPlayerClass(Player ply) {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets a players class</summary>
        // <param name="ply">Player to get class.</param>
        public static void GetPlayerClass(Player ply) {
        }
        
        // <realm>Shared</realm>
        // <summary>Applies basic class variables when the player spawns.<br /></summary>
        // <param name="ply">Player to setup.</param>
        public static void OnPlayerSpawn(Player ply) {
        }
        
        // <realm>Shared</realm>
        // <summary>Register a class metatable to be assigned to players later</summary>
        // <param name="name">Class name.</param>
        // <param name="table">Class metatable.</param>
        // <param name="base">Base class name.</param>
        public static void RegisterClass(string name, table table, string @base) {
        }
        
        // <realm>Shared</realm>
        // <summary>Execute a named function within the player's set class</summary>
        // <param name="ply">Player to execute function on.</param>
        // <param name="funcName">Name of function.</param>
        // <param name="arguments">Optional arguments. Can be of any type.</param>
        public static void RunClass(Player ply, string funcName, vararg arguments) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets a player's class</summary>
        // <param name="ply">Player to set class.</param>
        // <param name="classname">Name of class to set.</param>
        public static void SetPlayerClass(Player ply, string classname) {
        }
        
        // <realm>Shared</realm>
        // <summary>Retrieves correct hands for given player model. By default returns citizen hands.</summary>
        // <param name="name">Player model name.</param>
        public static void TranslatePlayerHands(string name) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the valid model path for a simplified name.</summary>
        // <param name="shortName">The short name of the model.</param>
        public static void TranslatePlayerModel(string shortName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the simplified name for a valid model path of a player model.</summary>
        // <param name="model">The model path to a player model.</param>
        public static void TranslateToPlayerModelName(string model) {
        }
    }
}