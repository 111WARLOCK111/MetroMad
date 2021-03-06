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
    
    
    public class Weapon {
        
        // <realm>Shared</realm>
        // <summary>Calls a SWEP function on client.</summary>
        // <param name="FunctionName">Name of function to call. If you want to call SWEP:MyFunc() on client, you type in "MyFunc".</param>
        // <param name="Arguments">Arguments for the function, separated by spaces.<br/>.</param>
        public virtual void CallOnClient(string FunctionName, string Arguments) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns how much primary ammo is in the magazine.</summary>
        // <return>number|The amount of primary ammo in the magazine.</return>
        public virtual int Clip1() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns how much secondary ammo is in magazine.</summary>
        // <return>number|The amount of secondary ammo in the magazine.</return>
        public virtual int Clip2() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Forces the weapon to reload while playing given animation.</summary>
        // <param name="act">Sequence to use as reload animation. Uses the {{Enum|ACT}}.</param>
        // <return>boolean|Did reloading actually take place</return>
        public virtual bool DefaultReload(float act) {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the sequence enumeration number that the weapon is playing. Must be used on a view model.</summary>
        // <return>number|Current activity, see {{Enum|ACT}}. Returns 0 if the weapon doesn't have active sequence.</return>
        public virtual int GetActivity() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the hold type of the weapon.</summary>
        // <return>string|The hold type of the weapon. You can find a list of default hold types [[Hold_Types|here]].</return>
        public virtual string GetHoldType() {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the next time the weapon can primary fire. ( Can call {{HookFunction|WEAPON|PrimaryAttack}} )</summary>
        // <return>number|The time, relative to {{GlobalFunction|CurTime}}</return>
        public virtual int GetNextPrimaryFire() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the next time the weapon can secondary fire. ( Can call {{HookFunction|WEAPON|SecondaryAttack}} )</summary>
        // <return>number|The time, relative to {{GlobalFunction|CurTime}}</return>
        public virtual int GetNextSecondaryFire() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the primary ammo type of the given weapon.</summary>
        // <return>number|The ammo type ID.</return>
        public virtual int GetPrimaryAmmoType() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns the non internal name of the weapon, that should be for displaying.</summary>
        // <return>string|The "nice" name of the weapon.</return>
        public virtual string GetPrintName() {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the ammo type of the given weapons secondary fire.</summary>
        // <return>number|The secondary ammo type ID.</return>
        public virtual int GetSecondaryAmmoType() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the weapon is carried by the local player.</summary>
        // <return>boolean|Is the weapon is carried by the local player or not</return>
        public virtual bool IsCarriedByLocalPlayer() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the entity is a NPC or not.</summary>
        // <return>boolean|Is the entity is a NPC or not.</return>
        public virtual bool IsNPC() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the entity is a player or not.</summary>
        // <return>boolean|Is the entity is a player or not.</return>
        public virtual bool IsPlayer() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the weapon is a SWEP or a built-in weapon.</summary>
        // <return>boolean|Returns true if weapon is scripted ( SWEP ), false if not ( A built-in HL2 weapon )</return>
        public virtual bool IsScripted() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the entity is a vehicle or not.</summary>
        // <return>boolean|Is the entity is a vehicle or not.</return>
        public virtual bool IsVehicle() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the entity is a weapon or not.</summary>
        // <return>boolean|Is the entity a weapon or not.</return>
        public virtual bool IsWeapon() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns whether the weapon is visible. The term visibility is not exactly what gets checked here, first it checks if the owner is a player, then checks if the active view model has EF_NODRAW flag NOT set.</summary>
        // <return>boolean|Is visible or not</return>
        public virtual bool IsWeaponVisible() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the time since a weapon was last fired at a float variable. Always returns 0.</summary>
        public virtual void LastShootTime() {
        }
        
        // <realm>Shared</realm>
        // <summary>Forces weapon to play activity/animation.</summary>
        // <param name="act">Activity to play. See the {{Enum|ACT}} (specifically ACT_VM_).</param>
        public virtual void SendWeaponAnim(float act) {
        }
        
        // <realm>Shared</realm>
        // <summary>Lets you change the number of bullets in the given weapons primary clip.</summary>
        // <param name="ammo">The amount of bullets the clip should contain.</param>
        public virtual void SetClip1(float ammo) {
        }
        
        // <realm>Shared</realm>
        // <summary>Lets you change the number of bullets in the given weapons secondary clip.</summary>
        // <param name="ammo">The amount of bullets the clip should contain.</param>
        public virtual void SetClip2(float ammo) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the hold type of the weapon. This function also calls {{HookFunction|WEAPON|SetWeaponHoldType}} and properly networks it to all clients.</summary>
        // <param name="name">Name of the hold type. You can find all default hold types [[Hold_Types|here]].</param>
        public virtual void SetHoldType(string name) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets when the weapon can fire again. Time should be based on {{GlobalFunction|CurTime}}.</summary>
        // <param name="time">Time when player should be able to use primary fire again.</param>
        public virtual void SetNextPrimaryFire(float time) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets when the weapon can alt-fire again. Time should be based on {{GlobalFunction|CurTime}}.</summary>
        // <param name="time">Time when player should be able to use secondary fire again.</param>
        public virtual void SetNextSecondaryFire(float time) {
        }
    }
}
