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
    
    
    public class widgets {
        
        // <realm>Shared</realm>
        // <summary>Internal function automatically called to update all widgets. Normally you won't need to call this.</summary>
        // <param name="ply">The player.</param>
        // <param name="mv">Player move data.</param>
        public virtual void PlayerTick(Player ply, CMoveData mv) {
        }
        
        // <realm>Client</realm>
        // <summary>Renders a widget. Normally you won't need to call this.</summary>
        // <param name="ent">Widget entity to render.</param>
        public virtual void RenderMe(Entity ent) {
        }
    }
}
