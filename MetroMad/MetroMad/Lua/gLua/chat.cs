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
    
    
    public class chat {
        
        // <realm>Client</realm>
        // <summary>Adds text to the local player's chat box (which only they can read).</summary>
        // <param name="arguments">The arguments. Arguments can be:.</param>
        public virtual void AddText(@object arguments) {
        }
        
        // <realm>Client</realm>
        // <summary>Closes the chat window.</summary>
        public virtual void Close() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the chat box positions x and y.</summary>
        // <return>number|The X coordinate of the chat box's position.</return>
        public virtual int GetChatBoxPos() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Opens the chat window.</summary>
        // <param name="mode">If equals 1, opens public chat, otherwise opens team chat.</param>
        public virtual void Open(float mode) {
        }
        
        // <realm>Client</realm>
        // <summary>Plays the chat "tick" sound.</summary>
        public virtual void PlaySound() {
        }
    }
}
