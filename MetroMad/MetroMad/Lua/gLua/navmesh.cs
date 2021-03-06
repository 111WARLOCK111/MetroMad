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
    
    
    public class navmesh {
        
        // <realm>Server</realm>
        // <summary>Add this position and normal to the list of walkable positions, used before map generation with {{LibraryFunction|navmesh|BeginGeneration}}</summary>
        // <param name="pos">The terrain position.</param>
        // <param name="dir">The normal of this terrain position.</param>
        public virtual void AddWalkableSeed(Vector pos, Vector dir) {
        }
        
        // <realm>Server</realm>
        // <summary>Starts the generation of a new navmesh.</summary>
        public virtual void BeginGeneration() {
        }
        
        // <realm>Server</realm>
        // <summary>Clears all the walkable positions, used before calling {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        public virtual void ClearWalkableSeeds() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns a bunch of areas within distance, used to find hiding spots by {{Type|NextBot}}s for example.</summary>
        // <param name="pos">The position to search around.</param>
        // <param name="radius">Radius to search within.</param>
        // <param name="stepdown">Maximum stepdown( fall distance ) allowed.</param>
        // <param name="stepup">Maximum stepup( jump height ) allowed.</param>
        // <return>table|A table of {{Type|CNavArea}}s</return>
        public virtual table Find(Vector pos, float radius, float stepdown, float stepup) {
            return new table();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the Nav Area contained in this position that also satisfies the elevation limit.</summary>
        // <param name="pos">The position to search for.</param>
        // <param name="beneathLimit">The elevation limit at which the Nav Area will be searched.</param>
        // <return>CNavArea|The nav area.</return>
        public virtual CNavArea GetNavArea(Vector pos, float beneathLimit) {
            return new CNavArea();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the Nav Area by the given ID.</summary>
        // <return>CNavArea|The returned Nav Area.</return>
        public virtual CNavArea GetNavAreaByID() {
            return new CNavArea();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the count of how many Nav Areas are currently loaded in the map.</summary>
        // <return>number|Nav Area count.</return>
        public virtual int GetNavAreaCount() {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Returns the classname of the player spawn entity.</summary>
        // <return>string|The classname of the spawn point entity. By default returns "info_player_start"</return>
        public virtual string GetPlayerSpawnName() {
            return "String";
        }
        
        // <realm>Server</realm>
        // <summary>Whether we're currently generating a new navmesh with {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        // <return>boolean|Whether we're generating a nav mesh or not.</return>
        public virtual bool IsGenerating() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Sets the classname of the default spawn point entity, used before generating a new navmesh with {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        // <param name="spawnPointClass">The classname of what the player uses to spawn, automatically adds it to the walkable positions during map generation.</param>
        public virtual void SetPlayerSpawnName(string spawnPointClass) {
        }
    }
}
