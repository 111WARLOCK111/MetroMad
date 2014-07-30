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
        public static void ActivateGameUI() {
        }
        
        // <realm>Client</realm>
        // <summary>Enables the mouse cursor without restricting player movement, like using Sandbox's Context Menu</summary>
        // <param name="enabled">Whether the cursor should be enabled or not. (true.</param>
        public static void EnableScreenClicker(boolean enabled) {
        }
        
        // <realm>Client</realm>
        // <summary>Hides the game menu overlay.</summary>
        public static void HideGameUI() {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse move with the given deltas.</summary>
        // <param name="deltaX">The movement delta on the x axis.</param>
        // <param name="deltaY">The movement delta on the y axis.</param>
        public static void InternalCursorMoved(float deltaX, float deltaY) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key press for the given key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public static void InternalKeyCodePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key release for the given key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public static void InternalKeyCodeReleased(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a key type typing to the specified key.</summary>
        // <param name="key">The key, see {{Enum|KEY}}.</param>
        public static void InternalKeyCodeTyped(float key) {
        }
        
        // <realm>Client</realm>
        public static void InternalKeyTyped() {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a double mouse key press for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public static void InternalMouseDoublePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse key press for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public static void InternalMousePressed(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse key release for the given mouse key.</summary>
        // <param name="key">The key, see {{Enum|MOUSE}}.</param>
        public static void InternalMouseReleased(float key) {
        }
        
        // <realm>Client</realm>
        // <summary>Simulates a mouse wheel scroll with the given delta.</summary>
        // <param name="delta">The amount of scrolling to simulate.</param>
        public static void InternalMouseWheeled(float delta) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the console is visible.</summary>
        public static void IsConsoleVisible() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the game menu overlay ( main menu ) is open or not.</summary>
        public static void IsGameUIVisible() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the cursor's position on the screen</summary>
        public static void MousePos() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns x component of the mouse position.</summary>
        public static void MouseX() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns y component of the mouse position.</summary>
        public static void MouseY() {
        }
        
        // <realm>Client</realm>
        // <summary>Opens specified URL in the steam overlay browser. The URL has to start with either http:// or https://</summary>
        // <param name="url">URL to open.</param>
        public static void OpenURL(string url) {
        }
        
        // <realm>Client</realm>
        // <summary>Converts the specified screen position to a direction vector local to the player's view.</summary>
        // <param name="x">X coordinate on the screen.</param>
        // <param name="y">Y coordinate on the screen.</param>
        public static void ScreenToVector(float x, float y) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the cursor's position on the screen, relative to the topleft corner of the window</summary>
        // <param name="mouseX">The X coordinate to move the cursor to.</param>
        // <param name="mouseY">The Y coordinate to move the cursor to.</param>
        public static void SetMousePos(float mouseX, float mouseY) {
        }
    }
}
