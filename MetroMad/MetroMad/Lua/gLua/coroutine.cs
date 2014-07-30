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
    
    
    public class coroutine {
        
        // <realm>Shared</realm>
        // <summary>Creates a coroutine of the given function.</summary>
        // <param name="func">The function for the coroutine to use.</param>
        public static void create(function func) {
        }
        
        // <realm>Shared</realm>
        // <summary>Resumes the given coroutine and passes the given vararg to either the function arguments or the {{LibraryFunction|coroutine|yield}} that is inside that function and returns whatever yield is called with the next time or by the final return in the function.</summary>
        // <param name="coroutine">Coroutine to resume.</param>
        // <param name="args">Arguments to be returned by {{LibraryFunction|coroutine|yield}}.</param>
        public static void resume(thread coroutine, vararg args) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the active coroutine or nil if we are not within a coroutine.</summary>
        public static void running() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the status of the coroutine passed to it, the possible statuses are "suspended", "running", and "dead".</summary>
        // <param name="coroutine">Coroutine to check the status of.</param>
        public static void status(thread coroutine) {
        }
        
        // <realm>Shared</realm>
        // <summary>Yield's the coroutine for so many seconds before returning.</summary>
        // <param name="seconds">The number of seconds to wait.</param>
        public static void wait(float seconds) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a function which calling is equivalent with calling {{LibraryFunction|coroutine|resume}} with the coroutine and all extra parameters.</summary>
        // <param name="coroutine">Coroutine to resume.</param>
        public static void wrap(function coroutine) {
        }
        
        // <realm>Shared</realm>
        // <summary>Pauses the active coroutine and passes all additional variables to the call of {{LibraryFunction|coroutine|resume}} that resumed the coroutine last time, and returns all additional variables that were passed to the previous call of resume.</summary>
        public static void yield() {
        }
    }
}
