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
    
    
    public class CEffectData {
        
        // <realm>Shared</realm>
        // <summary>Returns the angles of the effect.</summary>
        // <return>Angle|The angles of the effect</return>
        public virtual Angle GetAngles() {
            return new Angle();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the attachment ID for the effect.</summary>
        // <return>number|The attachment ID of the effect.</return>
        public virtual int GetAttachment() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns byte which represents the color of the effect.</summary>
        // <return>number|The color of the effect</return>
        public virtual int GetColor() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the damage type of the effect</summary>
        // <return>number|Damage type of the effect, see {{Enum|DMG}}</return>
        public virtual int GetDamageType() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the entity index of the entity set for the effect.</summary>
        // <return>number|The entity index of the entity set for the effect.</return>
        public virtual int GetEntIndex() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the entity assigned to the effect.</summary>
        // <return>Entity|The entity assigned to the effect</return>
        public virtual Entity GetEntity() {
            return new Entity();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the flags of the effect.</summary>
        // <return>number|The flags of the effect.</return>
        public virtual int GetFlags() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the hit box ID of the effect.</summary>
        // <return>number|The hit box ID of the effect.</return>
        public virtual int GetHitBox() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the magnitude of the effect.</summary>
        // <return>number|The magnitude of the effect.</return>
        public virtual int GetMagnitude() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the material ID of the effect.</summary>
        // <return>number|The material ID of the effect.</return>
        public virtual int GetMaterialIndex() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the normalized direction vector of the effect.</summary>
        // <return>Vector|The normalized direction vector of the effect.</return>
        public virtual Vector GetNormal() {
            return new Vector();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the origin position of the effect.</summary>
        // <return>Vector|The origin position of the effect.</return>
        public virtual Vector GetOrigin() {
            return new Vector();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the radius of the effect.</summary>
        // <return>number|The radius of the effect.</return>
        public virtual int GetRadius() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the scale of the effect.</summary>
        // <return>number|The scale of the effect</return>
        public virtual int GetScale() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the start position of the effect.</summary>
        // <return>Vector|The start position of the effect</return>
        public virtual Vector GetStart() {
            return new Vector();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the surface property index of the effect.</summary>
        // <return>number|The surface property index of the effect</return>
        public virtual int GetSurfaceProp() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the angles of the effect.</summary>
        // <param name="ang">The new angles to be set.</param>
        public virtual void SetAngles(Angle ang) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the attachment id of the effect to be created with this effect data.</summary>
        // <param name="attachment">New attachment ID of the effect.</param>
        public virtual void SetAttachment(float attachment) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the color of the effect.</summary>
        // <param name="color">Color represented by a byte.</param>
        public virtual void SetColor(float color) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the damage type of the effect to be created with this effect data.</summary>
        // <param name="damageType">Damage type, see {{Enum|DMG}}.</param>
        public virtual void SetDamageType(float damageType) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the entity of the effect via its index.</summary>
        // <param name="entIndex">The entity index to be set.</param>
        public virtual void SetEntIndex(float entIndex) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the entity of the effect to be created with this effect data.</summary>
        // <param name="entity">Entity of the effect, mostly used for parenting.</param>
        public virtual void SetEntity(Entity entity) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the flags of the effect.</summary>
        // <param name="flags">The flags of the effect.</param>
        public virtual void SetFlags(float flags) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the hit box index of the effect.</summary>
        // <param name="hitBoxIndex">The hit box index of the effect.</param>
        public virtual void SetHitBox(float hitBoxIndex) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the magnitude of the effect.</summary>
        // <param name="magnitude">The magnitude of the effect.</param>
        public virtual void SetMagnitude(float magnitude) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the material index of the effect.</summary>
        // <param name="materialIndex">The material index of the effect.</param>
        public virtual void SetMaterialIndex(float materialIndex) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the normalized direction vector of the effect to be created with this effect data.</summary>
        // <param name="normal">The normalized direction vector of the effect.</param>
        public virtual void SetNormal(Vector normal) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the origin of the effect to be created with this effect data.</summary>
        // <param name="origin">Origin of the effect.</param>
        public virtual void SetOrigin(Vector origin) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the radius of the effect to be created with this effect data.</summary>
        // <param name="radius">Radius of the effect.</param>
        public virtual void SetRadius(float radius) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the scale of the effect to be created with this effect data.</summary>
        // <param name="scale">Scale of the effect.</param>
        public virtual void SetScale(float scale) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the start of the effect to be created with this effect data.</summary>
        // <param name="start">Start of the effect.</param>
        public virtual void SetStart(Vector start) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the surface property index of the effect.</summary>
        // <param name="surfaceProperties">The surface property index of the effect.</param>
        public virtual void SetSurfaceProp(float surfaceProperties) {
        }
    }
}
