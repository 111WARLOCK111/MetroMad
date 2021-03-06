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
    
    
    public class PathFollower {
        
        // <realm>Server</realm>
        // <summary>If you created your path with type "Chase" this functions should be used in place of {{ClassFunction|PathFollower|Update}} to cause the bot to chase the specified entity.</summary>
        // <param name="bot">The bot to update along the path.</param>
        // <param name="ent">The entity we want to chase.</param>
        public virtual void Chase(NextBot bot, Entity ent) {
        }
        
        // <realm>Server</realm>
        // <summary>Computes the path</summary>
        // <param name="from">The nextbot we're generating for.</param>
        // <param name="to">To point.</param>
        public virtual void Compute(NextBot from, Vector to) {
        }
        
        // <realm>Server</realm>
        // <summary>Draws the path. This is meant for debugging - and uses debug overlay.</summary>
        public virtual void Draw() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the age since the path was built</summary>
        // <return>number|Path age</return>
        public virtual int GetAge() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>The closest position along the path to a position</summary>
        // <param name="position">The point we're querying for.</param>
        // <return>Vector|The closest position on the path</return>
        public virtual Vector GetClosestPosition(Vector position) {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the current progress along the path</summary>
        // <return>number|The current progress</return>
        public virtual int GetCursorPosition() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the path end position</summary>
        // <return>Vector|The end position</return>
        public virtual Vector GetEnd() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the total length of the path</summary>
        // <return>number|The length of the path</return>
        public virtual int GetLength() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the vector position of distance along path</summary>
        // <param name="distance">The distance along the path to query.</param>
        // <return>Vector|The position</return>
        public virtual Vector GetPositionOnPath(float distance) {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the path start position</summary>
        // <return>Vector|The start position</return>
        public virtual Vector GetStart() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        // <summary>Invalidates the current path</summary>
        public virtual void Invalidate() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns true if the path is valid</summary>
        public virtual void IsValid() {
        }
        
        // <realm>Server</realm>
        // <summary>Moves the cursor by this much</summary>
        // <param name="distance">The distance to move the cursor (in world units).</param>
        public virtual void MoveCursor(float distance) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the cursor position to</summary>
        // <param name="distance">The distance to move the cursor (in world units).</param>
        public virtual void MoveCursorTo(float distance) {
        }
        
        // <realm>Server</realm>
        // <summary>Moves the cursor to the end of the path</summary>
        public virtual void MoveCursorToEnd() {
        }
        
        // <realm>Server</realm>
        // <summary>Moves the cursor to the end of the path</summary>
        public virtual void MoveCursorToStart() {
        }
        
        // <realm>Server</realm>
        // <summary>How close we can get to the goal to call it done</summary>
        // <param name="distance">The distance we're setting it to.</param>
        public virtual void SetGoalTolerance(float distance) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets minimum range movement goal must be along path</summary>
        // <param name="mindist">The minimum look ahead distance.</param>
        public virtual void SetMinLookAheadDistance(float mindist) {
        }
        
        // <realm>Server</realm>
        // <summary>Move the bot along the path.</summary>
        // <param name="bot">The bot to update along the path.</param>
        public virtual void Update(NextBot bot) {
        }
    }
}
