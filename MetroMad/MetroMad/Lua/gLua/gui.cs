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
    
    
    public class gui {
        
        // <realm>Client</realm>
        // <summary>Opens the game menu overlay.</summary>
        public virtual void ActivateGameUI() {
        }
        
        // <realm>Client</realm>
        // <summary>Enables the mouse cursor without restricting player movement, like using Sandbox's Context Menu</summary>
        // <param name="enabled">Whether the cursor should be enabled or not. (true.</param>
        public virtual void EnableScreenClicker(boolean enabled) {
        }
        
        // <realm>Client</realm>
        // <summary>Hides the game menu overlay.</summary>
        public virtual void HideGameUI() {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse move with the given deltas.</summary>
        // <param name="deltaX">The movement delta on the x axis.</param>
        // <param name="deltaY">The movement delta on the y axis.</param>
        public virtual void InternalCursorMoved(float deltaX, float deltaY) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key press for the given key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public virtual void InternalKeyCodePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key release for the given key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public virtual void InternalKeyCodeReleased(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key type typing to the specified key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public virtual void InternalKeyCodeTyped(float key) {
        }
        
        // <realm>Client</realm>
        public virtual void InternalKeyTyped() {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a double mouse key press for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public virtual void InternalMouseDoublePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse key press for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public virtual void InternalMousePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse key release for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public virtual void InternalMouseReleased(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse wheel scroll with the given delta.</summary>
        // <param name="delta">The amount of scrolling to simulate.</param>
        public virtual void InternalMouseWheeled(float delta) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the console is visible.</summary>
        // <return>boolean|isVisible</return>
        public virtual bool IsConsoleVisible() {
            return true;
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the game menu overlay ( main menu ) is open or not.</summary>
        // <return>boolean|Whenever the game menu overlay ( main menu ) is open or not</return>
        public virtual bool IsGameUIVisible() {
            return true;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the cursor's position on the screen</summary>
        // <return>number|mouseX</return>
        public virtual int MousePos() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns x component of the mouse position.</summary>
        // <return>number|mouseX</return>
        public virtual int MouseX() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns y component of the mouse position.</summary>
        // <return>number|mouseY</return>
        public virtual int MouseY() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Opens specified URL in the steam overlay browser. The URL has to start with either http:// or https://</summary>
        // <param name="url">URL to open.</param>
        public virtual void OpenURL(string url) {
        }
        
        // <realm>Client</realm>
        // <summary>Converts the specified screen position to a direction vector local to the player's view.</summary>
        // <param name="x">X coordinate on the screen.</param>
        // <param name="y">Y coordinate on the screen.</param>
        // <return>Vector|Direction</return>
        public virtual Vector ScreenToVector(float x, float y) {
            return new Vector();
        }
        
        // <realm>Client</realm>
        // <summary>Sets the cursor's position on the screen, relative to the topleft corner of the window</summary>
        // <param name="mouseX">The X coordinate to move the cursor to.</param>
        // <param name="mouseY">The Y coordinate to move the cursor to.</param>
        public virtual void SetMousePos(float mouseX, float mouseY) {
        }
    }
}
