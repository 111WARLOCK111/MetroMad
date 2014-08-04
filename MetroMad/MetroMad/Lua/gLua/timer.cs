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
    
    
    public class timer {
        
        // <realm>Shared</realm>
        // <summary>Adjusts the timer if the timer with the given identifier exists.</summary>
        // <param name="identifier">Identifier of the timer to adjust.</param>
        // <param name="delay">The delay interval in seconds.</param>
        // <param name="repetitions">Repetitions. Use 0 for infinite.</param>
        // <param name="func">The new function.</param>
        // <return>boolean|true if succeeded</return>
        public virtual bool Adjust(any identifier, float delay, float repetitions, function func) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Check all timers and complete any tasks needed. This should be run every frame.</summary>
        public virtual void Check() {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a new timer.</summary>
        // <param name="identifier">Identifier of the timer to adjust.</param>
        // <param name="delay">The delay interval in seconds.</param>
        // <param name="repetitions">The number of times to repeat the timer. (Enter 0 for infinite repetitions).</param>
        // <param name="func">Function called when timer has finished the countdown.</param>
        public virtual void Create(string identifier, float delay, float repetitions, function func) {
        }
        
        // <realm>Shared</realm>
        // <summary>Stops and destroys the given timer.</summary>
        // <param name="identifier">Identifier of the timer to destroy.</param>
        public virtual void Destroy(any identifier) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns whenever the given timer exists or not.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|Returns true if the timer exists, false if it doesn't</return>
        public virtual bool Exists(any identifier) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Pauses the given timer.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|false if the timer didn't exist or was already paused, true otherwise.</return>
        public virtual bool Pause(any identifier) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Removes the timer.</summary>
        // <param name="identifier">Identifier of the timer to stop.</param>
        public virtual void Remove(any identifier) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns amount of repetitions/executions left before the timer destroys itself.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>number|The amount of executions left.</return>
        public virtual int RepsLeft(any identifier) {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Runs the given function after a specified delay.</summary>
        // <param name="delay">How long until the function should be ran (in seconds).</param>
        // <param name="func">The function to run after the specified delay.</param>
        public virtual void Simple(float delay, function func) {
        }
        
        // <realm>Shared</realm>
        // <summary>Restarts the given timer.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|true if the timer exists, false if it doesn't.</return>
        public virtual bool Start(any identifier) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Stops the given timer.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|false if the timer didn't exist or was already stopped, true otherwise.</return>
        public virtual bool Stop(any identifier) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns amount of time left before the timer executes its function.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>number|The amount of time left.</return>
        public virtual int TimeLeft(any identifier) {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Runs either {{LibraryFunction|timer|Pause}} or {{LibraryFunction|timer|UnPause}} based on the timer's current status.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|status of the timer.</return>
        public virtual bool Toggle(any identifier) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Unpauses the timer.</summary>
        // <param name="identifier">Identifier of the timer.</param>
        // <return>boolean|false if the timer didn't exist or was already running, true otherwise.</return>
        public virtual bool UnPause(any identifier) {
            return true;
        }
    }
}
