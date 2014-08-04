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
    
    
    public class numpad {
        
        // <realm>Server</realm>
        // <summary>Activates numpad key owned by the player</summary>
        // <param name="ply">The player whose numpad should be simulated.</param>
        // <param name="key">The key to press, see {{Enum|KEY}}.</param>
        // <param name="isButton">Should this keypress pretend to be a from a gmod_button? (causes {{LibraryFunction|numpad|FromButton}} to return true).</param>
        public virtual void Activate(Player ply, float key, boolean isButton) {
        }
        
        // <realm>Server</realm>
        // <summary>Deactivates numpad key owned by the player</summary>
        // <param name="ply">The player whose numpad should be simulated.</param>
        // <param name="key">The key to press, corresponding to {{Enum|KEY}}.</param>
        // <param name="isButton">Should this keypress pretend to be a from a gmod_button? (causes {{LibraryFunction|numpad|FromButton}} to return true).</param>
        public virtual void Deactivate(Player ply, float key, boolean isButton) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns true during a function added with {{LibraryFunction| numpad|Register}} when the third argument to {{LibraryFunction|numpad|Activate}} is true.</summary>
        // <return>boolean|wasButton</return>
        public virtual bool FromButton() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Adds a function to call when a player presses a key on the number pad</summary>
        // <param name="ply">The player whose numpad should be watched.</param>
        // <param name="key">The key, corresponding to {{Enum|KEY}}.</param>
        // <param name="name">The name of the function to run, corresponding with the one used in {{LibraryFunction|numpad|Register}}.</param>
        // <param name="args">Arguments to pass to the function.</param>
        // <return>number|impulseId</return>
        public virtual int OnDown(Player ply, float key, string name, any args) {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Adds a function to call when a player releases a key on the number pad</summary>
        // <param name="ply">The player whose numpad should be watched.</param>
        // <param name="key">The key, corresponding to {{Enum|KEY}}.</param>
        // <param name="name">The name of the function to run, corresponding with the one used in {{LibraryFunction|numpad|Register}}.</param>
        // <param name="params object[]">Arguments to pass to the function.</param>
        // <return>number|impulseId</return>
        public virtual int OnUp(Player ply, float key, string name, any params object[]) {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Registers a numpad library action for use with {{LibraryFunction|numpad|OnDown}} and {{LibraryFunction|numpad|OnUp}}</summary>
        // <param name="id">The unique id of your action.</param>
        // <param name="func">The function to be executed.</param>
        public virtual void Register(string id, function func) {
        }
        
        // <realm>Server</realm>
        // <summary>Removes a function added by either {{LibraryFunction|numpad|OnUp}} or {{LibraryFunction|numpad|OnDown}}</summary>
        // <param name="name">The name added via {{LibraryFunction|numpad|OnUp}} or {{LibraryFunction|numpad|OnDown}}.</param>
        public virtual void Remove(string name) {
        }
        
        // <realm>Server</realm>
        // <summary>Either runs {{LibraryFunction|numpad|Activate}} or {{LibraryFunction|numpad|Deactivate}} depending on the key's current state</summary>
        // <param name="ply">The player whose numpad should be simulated.</param>
        // <param name="key">The key to press, corresponding to {{Enum|KEY}}.</param>
        public virtual void Toggle(Player ply, float key) {
        }
    }
}
