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
    
    
    public class dragndrop {
        
        // <realm>Client</realm>
        public virtual void CallReceiverFunction() {
        }
        
        // <realm>Client</realm>
        public virtual void Clear() {
        }
        
        // <realm>Client</realm>
        public virtual void Drop() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns a table of currently dragged panels.</summary>
        // <param name="name">If set, the function will return only the panels with this {{ClassFunction|Panel|Droppable}} name.</param>
        // <return>table|A table of all panels that are being currently dragged, if any.</return>
        public virtual table GetDroppable(string name) {
            return new table();
        }
        
        // <realm>Client</realm>
        public virtual void HandleDroppedInGame() {
        }
        
        // <realm>Client</realm>
        public virtual void HoverThink() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whether the user is dragging something with the drag'n'drop system.</summary>
        // <return>boolean|True if the user is dragging something with the drag'n'drop system.</return>
        public virtual bool IsDragging() {
            return true;
        }
        
        // <realm>Client</realm>
        public virtual void StartDragging() {
        }
        
        // <realm>Client</realm>
        public virtual void StopDragging() {
        }
        
        // <realm>Client</realm>
        public virtual void Think() {
        }
        
        // <realm>Client</realm>
        public virtual void UpdateReceiver() {
        }
    }
}
