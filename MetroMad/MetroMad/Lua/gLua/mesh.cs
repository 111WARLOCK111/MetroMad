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
    
    
    public class mesh {
        
        // <realm>Client</realm>
        // <summary>Pushes the new vertex data onto the render stack.</summary>
        public static void AdvanceVertex() {
        }
        
        // <realm>Client</realm>
        // <summary>Starts a new dynamic mesh.</summary>
        // <param name="primitiveType">Primitive type, see {{Enum|MATERIAL}}.</param>
        // <param name="primiteCount">The amount of primitives.</param>
        public static void Begin(float primitiveType, float primiteCount) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the color to be used for the next vertex.</summary>
        // <param name="r">Red component.</param>
        // <param name="g">Green component.</param>
        // <param name="b">Blue component.</param>
        // <param name="a">Alpha component.</param>
        public static void Color(float r, float g, float b, float a) {
        }
        
        // <realm>Client</realm>
        // <summary>Ends the mesh and renders it.</summary>
        public static void End() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the normal to be used for the next vertex.</summary>
        // <param name="normal">The normal of the vertex.</param>
        public static void Normal(Vector normal) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the position to be used for the next vertex.</summary>
        // <param name="position">The position of the vertex.</param>
        public static void Position(Vector position) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a quad using 4 vertices.</summary>
        // <param name="vertex1">The first vertex.</param>
        // <param name="vertex2">The second vertex.</param>
        // <param name="vertex3">The third vertex.</param>
        // <param name="vertex4">The fourth vertex.</param>
        public static void Quad(Vector vertex1, Vector vertex2, Vector vertex3, Vector vertex4) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a quad using a position, a normal and the size.</summary>
        // <param name="position">The center of the quad.</param>
        // <param name="normal">The normal of the quad.</param>
        // <param name="sizeX">X size in pixels.</param>
        // <param name="sizeY">Y size in pixels.</param>
        public static void QuadEasy(Vector position, Vector normal, float sizeX, float sizeY) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the specular map values.</summary>
        // <param name="r">The red channel multiplier of the specular map.</param>
        // <param name="g">The green channel multiplier of the specular map.</param>
        // <param name="b">The blue channel multiplier of the specular map.</param>
        // <param name="a">The alpha channel multiplier of the specular map.</param>
        public static void Specular(float r, float g, float b, float a) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the s tangent to be used.</summary>
        // <param name="sTanger">The s tangent.</param>
        public static void TangentS(Vector sTanger) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the T tangent to be used.</summary>
        // <param name="tTanger">The t tangent.</param>
        public static void TangentT(Vector tTanger) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the texture coordinates for the next vertex.</summary>
        // <param name="stage">The stage of the texture coordinate.</param>
        // <param name="u">U coordinate.</param>
        // <param name="v">V coordinate.</param>
        public static void TexCoord(float stage, float u, float v) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the amount of vertex that have yet been pushes.</summary>
        public static void VertexCount() {
        }
    }
}
