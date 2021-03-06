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
    
    
    public class surface {
        
        // <realm>Client</realm>
        // <summary>Creates a new font.</summary>
        // <param name="fontName">The new font name.</param>
        // <param name="fontData">The font properties. See the {{Struct|FontData}}.</param>
        public virtual void CreateFont(string fontName, table fontData) {
        }
        
        // <realm>Client</realm>
        // <summary>Enables or disables the clipping used by the VGUI that limits the drawing operations to a panels bounds.</summary>
        // <param name="disable">True to disable, false to enable the clipping.</param>
        public virtual void DisableClipping(boolean disable) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a hollow circle, made of dots.</summary>
        // <param name="originX">The center x coordinate.</param>
        // <param name="originY">The center y coordinate.</param>
        // <param name="radius">The radius of the circle.</param>
        // <param name="color">The color of the circle. Uses the {{Struct|Color}}.</param>
        public virtual void DrawCircle(float originX, float originY, float radius, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a line from one point to another.</summary>
        // <param name="startX">The start x coordinate.</param>
        // <param name="startY">The start y coordinate.</param>
        // <param name="endX">The end x coordinate.</param>
        // <param name="endY">The end y coordinate.</param>
        public virtual void DrawLine(float startX, float startY, float endX, float endY) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a hollow box with a border width of 1 px.</summary>
        // <param name="x">The start x coordinate.</param>
        // <param name="y">The start y coordinate.</param>
        // <param name="w">The width.</param>
        // <param name="h">The height.</param>
        public virtual void DrawOutlinedRect(float x, float y, float w, float h) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a polygon with a maximum of 256 vertices.</summary>
        // <param name="vertices">A table containing vertices. See the {{Struct|PolygonVertex}}.</param>
        public virtual void DrawPoly(table vertices) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a solid rectangle on the screen.</summary>
        // <param name="x">The X co-ordinate.</param>
        // <param name="y">The Y co-ordinate.</param>
        // <param name="width">The width of the rectangle.</param>
        // <param name="height">The height of the rectangle.</param>
        public virtual void DrawRect(float x, float y, float width, float height) {
        }
        
        // <realm>Client</realm>
        // <summary>Draw the specified text on the screen, using the previously set position.</summary>
        // <param name="text">The text to be rendered.</param>
        public virtual void DrawText(string text) {
        }
        
        // <realm>Client</realm>
        // <summary>Draw a textured rectangle with the given position and dimensions on the screen, using the current active texture.</summary>
        // <param name="x">The X co-ordinate.</param>
        // <param name="y">The Y co-ordinate.</param>
        // <param name="width">The width of the rectangle.</param>
        // <param name="height">The height of the rectangle.</param>
        public virtual void DrawTexturedRect(float x, float y, float width, float height) {
        }
        
        // <realm>Client</realm>
        // <summary>Draw a textured rotated rectangle with the given position and dimensions and angle on the screen, using the current active texture.</summary>
        // <param name="x">The X co-ordinate, representing the center of the cube.</param>
        // <param name="y">The Y co-ordinate, representing the center of the cube.</param>
        // <param name="width">The width of the rectangle.</param>
        // <param name="height">The height of the rectangle.</param>
        // <param name="rotation">The rotation of the rectangle, in degrees.</param>
        public virtual void DrawTexturedRectRotated(float x, float y, float width, float height, float rotation) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a textured rectangle with a repeated or partial texture. U and V refer to texture coordinates. 0,0 is the bottom left corner of the texture, 1,0 is the bottom right, 1,1 is the top right and 0,1 is the top left.<br/></summary>
        // <param name="x">The X coordinate.</param>
        // <param name="y">The Y coordinate.</param>
        // <param name="width">The width of the rectangle.</param>
        // <param name="height">The height of the rectangle.</param>
        // <param name="startU">The U texture mapping of the rect origin.</param>
        // <param name="startV">The V texture mapping of the rect origin.</param>
        // <param name="endU">The U texture mapping of the rect end.</param>
        // <param name="endV">The V texture mapping of the rect end.</param>
        public virtual void DrawTexturedRectUV(float x, float y, float width, float height, float startU, float startV, float endU, float endV) {
        }
        
        // <realm>Client</realm>
        // <summary>Gets the HUD texture with the specified name.</summary>
        // <param name="name">The name of the texture.</param>
        // <return>ITexture|text</return>
        public virtual ITexture GetHUDTexture(string name) {
            return new ITexture();
        }
        
        // <realm>Client</realm>
        // <summary>Returns the width and height (in pixels) of the given text, but only if the font has been set with {{LibraryFunction|surface|SetFont}}.</summary>
        // <param name="text">The string to check the size of.</param>
        // <return>number|width</return>
        public virtual int GetTextSize(string text) {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the texture id of the texture with the given name/path.</summary>
        // <param name="name/path">Name or path of the texture.</param>
        // <return>number|textureID</return>
        public virtual int GetTextureID(string name/path) {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the size of the texture with the associated texture id.</summary>
        // <param name="textureID">The texture id.</param>
        // <return>number|width</return>
        public virtual int GetTextureSize(float textureID) {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Play a sound file directly on the client (such as UI sounds, etc).</summary>
        // <param name="soundfile">The path to the sound file.</param>
        public virtual void PlaySound(string soundfile) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the height of the current client's screen.</summary>
        // <return>number|screenHeight</return>
        public virtual int ScreenHeight() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the width of the current client's screen.</summary>
        // <return>number|screenWidth</return>
        public virtual int ScreenWidth() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Sets a multiplier that will influence all upcoming drawing operations.</summary>
        // <param name="multiplier">The multiplier ranging from 0 to 1.</param>
        public virtual void SetAlphaMultiplier(float multiplier) {
        }
        
        // <realm>Client</realm>
        // <summary>Set the color of any future shapes to be drawn, can be set by either using r, g, b, a as separate values or by a {{Struct|Color}}. Using a color structure is not recommended to be created procedurally.</summary>
        // <param name="r">The red value of color, or a {{Struct|Color}}.</param>
        // <param name="g">The green value of color.</param>
        // <param name="b">The blue value of color.</param>
        // <param name="a">The alpha value of color.</param>
        public virtual void SetDrawColor(float r, float g, float b, float a) {
        }
        
        // <realm>Client</realm>
        // <summary>Set the current font to be used for text operations later.</summary>
        // <param name="fontName">The name of the font to use.</param>
        public virtual void SetFont(string fontName) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the material to be used in all upcoming surface draw operations.</summary>
        // <param name="material">The material to be used.</param>
        public virtual void SetMaterial(IMaterial material) {
        }
        
        // <realm>Client</realm>
        // <summary>Set the color of any future text to be drawn, can be set by either using r, g, b, a as separate values or by a {{Struct|Color}}. Using a color structure is not recommended to be created procedurally.</summary>
        // <param name="r">The red value of color, or a {{Struct|Color}}.</param>
        // <param name="g">The green value of color.</param>
        // <param name="b">The blue value of color.</param>
        // <param name="a">The alpha value of color.</param>
        public virtual void SetTextColor(float r, float g, float b, float a) {
        }
        
        // <realm>Client</realm>
        // <summary>Set the position to draw any future text.</summary>
        // <param name="x">The X co-ordinate.</param>
        // <param name="y">The Y co-ordinate.</param>
        public virtual void SetTextPos(float x, float y) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the texture to be used in all upcoming surface draw operations.</summary>
        // <param name="textureID">The id of the texture to draw with.</param>
        public virtual void SetTexture(float textureID) {
        }
    }
}
