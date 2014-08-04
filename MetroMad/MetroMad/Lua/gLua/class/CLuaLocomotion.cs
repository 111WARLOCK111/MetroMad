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
    
    
    public class CLuaLocomotion {
        
        // <realm>Server</realm>
        // <summary>Sets the location we want to get to</summary>
        // <param name="goal">The vector we want to get to.</param>
        // <param name="goalweight">If unsure then set this to 1.</param>
        public virtual void Approach(Vector goal, float goalweight) {
        }
        
        // <realm>Server</realm>
        // <summary>Removes the stuck status from the bot</summary>
        public virtual void ClearStuck() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the direction we want to face</summary>
        // <param name="goal">The vector we want to face.</param>
        public virtual void FaceTowards(Vector goal) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the acceleration speed</summary>
        // <return>number|Current acceleration speed</return>
        public virtual int GetAcceleration() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the current acceleration as a vector</summary>
        // <return>Vector|Current acceleration</return>
        public virtual Vector GetCurrentAcceleration() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Gets the height the bot is scared to fall from</summary>
        // <return>number|Current death drop height</return>
        public virtual int GetDeathDropHeight() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Gets the deceleration speed</summary>
        // <return>number|Current deceleration speed</return>
        public virtual int GetDeceleration() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Return unit vector in XY plane describing our direction of motion - even if we are currently not moving</summary>
        // <return>Vector|A vector representing the X and Y movement</return>
        public virtual Vector GetGroundMotionVector() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Gets the height of the bot's jump</summary>
        // <return>number|Current jump height</return>
        public virtual int GetJumpHeight() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Gets the max height the bot can step up</summary>
        // <return>number|Current step height</return>
        public virtual int GetStepHeight() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the current movement velocity as a vector</summary>
        // <return>Vector|Current velocity</return>
        public virtual Vector GetVelocity() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Returns true if we're trying to move</summary>
        // <return>boolean|Whehter we're trying to move or not</return>
        public virtual bool IsAttemptingToMove() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Returns true of the locomotion engine is jumping or climbing</summary>
        // <return>boolean|Whether we're climbing or jumping or not</return>
        public virtual bool IsClimbingOrJumping() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Returns true if we're stuck</summary>
        // <return>boolean|Whether we're stuck or not</return>
        public virtual bool IsStuck() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Makes the bot jump</summary>
        public virtual void Jump() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the acceleration speed</summary>
        // <param name="speed">Speed acceleration (default is 400).</param>
        public virtual void SetAcceleration(float speed) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the height the bot is scared to fall from.</summary>
        // <param name="height">Height (default is 200).</param>
        public virtual void SetDeathDropHeight(float height) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the deceleration speed.</summary>
        // <param name="deceleration">New deceleration speed (default is 400).</param>
        public virtual void SetDeceleration(float deceleration) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets movement speed.</summary>
        // <param name="speed">The new desired speed.</param>
        public virtual void SetDesiredSpeed(float speed) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the height of the bot's jump</summary>
        // <param name="height">Height (default is 58).</param>
        public virtual void SetJumpHeight(float height) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the max height the bot can step up</summary>
        // <param name="height">Height (default is 18).</param>
        public virtual void SetStepHeight(float height) {
        }
    }
}
