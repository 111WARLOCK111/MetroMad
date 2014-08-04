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
    
    
    public class hook {
        
        // <realm>Shared</realm>
        // <summary>Add a hook to be called upon the given event occurring.</summary>
        // <param name="eventName">The event to hook on to.</param>
        // <param name="identifier">The unique identifier, usually a string. This can be used to replace or remove existing hooks.</param>
        // <param name="func">The function to be called, arguments given to it depend on the [[:Category:Hooks|hook]].</param>
        public virtual void Add(string eventName, any identifier, function func) {
        }
        
        // <realm>Shared</realm>
        // <summary>Calls hooks associated with the given event<br /></summary>
        // <param name="eventName">The event to call hooks for.</param>
        // <param name="gamemodeTable">If the gamemode is specified, the gamemode hook within will be called, otherwise not.</param>
        // <param name="args">The arguments to be passed to the hooks.</param>
        // <return>any|Return data from called hooks</return>
        public virtual any Call(string eventName, table gamemodeTable, @object args) {
            return new any();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a table containing subtables which contain all hooks.</summary>
        // <return>table|hooks</return>
        public virtual table GetTable() {
            return new table();
        }
        
        // <realm>Shared</realm>
        // <summary>Removes the hook with the supplied identifier from the given event.</summary>
        // <param name="eventName">The event name.</param>
        // <param name="identifier">The unique identifier of the hook to remove, usually a string.</param>
        public virtual void Remove(string eventName, any identifier) {
        }
        
        // <realm>Shared</realm>
        // <summary>Calls hooks associated with the given event<br /></summary>
        // <param name="eventName">The event to call hooks for.</param>
        // <param name="args">The arguments to be passed to the hooks.</param>
        // <return>any|Returned data from called hooks</return>
        public virtual any Run(string eventName, @object args) {
            return new any();
        }
    }
}
