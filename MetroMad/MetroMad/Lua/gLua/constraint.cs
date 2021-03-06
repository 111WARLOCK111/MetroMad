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
    
    
    public class constraint {
        
        // <realm>Server</realm>
        // <summary>Stores info about the constraints on the entity's table.</summary>
        // <param name="Ent2">Optional.</param>
        // <param name="Ent3">Optional.</param>
        // <param name="Ent4">Optional.</param>
        public virtual void AddConstraintTable(Entity Ent2, Entity Ent3, Entity Ent4) {
        }
        
        // <realm>Server</realm>
        // <summary>Stores info about the constraints on the entity's table. The only difference between this and {{LibraryFunction|constraint|AddConstraintTable}} is that the constraint does not get deleted when the entity is removed.</summary>
        // <param name="Ent2">Optional.</param>
        // <param name="Ent3">Optional.</param>
        // <param name="Ent4">Optional.</param>
        public virtual void AddConstraintTableNoDelete(Entity Ent2, Entity Ent3, Entity Ent4) {
        }
        
        // <realm>Server</realm>
        // <summary>Creates an advanced ballsocket (ragdoll) constraint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="torquelimit">Amount of torque (rotation speed) until it breaks (0.</param>
        // <param name="nocollide">Whether the entities should be no-collided.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity AdvBallsocket(Entity Ent1, Entity Ent2, float Bone1, float Bone2, float forcelimit, float torquelimit, float nocollide) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates an axis constraint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="torquelimit">Amount of torque (rotation speed) until it breaks (0.</param>
        // <param name="nocollide">Whether the entities should be no-collided.</param>
        // <param name="LocalAxis">If you include the LocalAxis then LPos2 will not be used in the final constraint. However, LPos2 is still a required argument.</param>
        // <param name="DontAddTable">Whether or not to add the constraint info on the entity table. See {{LibraryFunction|constraint|AddConstraintTable}}.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Axis(Entity Ent1, Entity Ent2, float Bone1, float Bone2, float forcelimit, float torquelimit, float nocollide, Vector LocalAxis, boolean DontAddTable) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a ballsocket joint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="LocalPos">Centerposition of the joint, relative to the <b>second</b> entity.</param>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="torquelimit">Amount of torque (rotation speed) until it breaks (0.</param>
        // <param name="nocollide">Whether the entities should be nocollided.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Ballsocket(Entity Ent1, Entity Ent2, float Bone1, float Bone2, Vector LocalPos, float forcelimit, float torquelimit, float nocollide) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Basic checks to make sure that the specified entity and bone are valid. Returns false if we should not be constraining the entity.</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="bone">The bone of the entity to check (use 0 for mono boned ents).</param>
        // <return>boolean|shouldConstrain</return>
        public virtual bool CanConstrain(Entity ent, float bone) {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Creates a rope without any constraint</summary>
        // <return>Entity|rope</return>
        public virtual Entity CreateKeyframeRope() {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates an invisible, non-moveable anchor point in the world to which things can be attached.</summary>
        // <param name="pos">The position to spawn the anchor at.</param>
        // <return>Entity|anchor</return>
        public virtual Entity CreateStaticAnchorPoint(Vector pos) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates an elastic constraint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="LPos1">Position of first end of the rope. Local to Ent1.</param>
        // <param name="LPos2">Position of second end of the rope. Local to Ent2.</param>
        // <param name="material">The material of the rope.</param>
        // <param name="width">Width of rope.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Elastic(Entity Ent1, Entity Ent2, float Bone1, float Bone2, Vector LPos1, Vector LPos2, string material, float width) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the constraint of a specified type between two entities, if it exists</summary>
        // <param name="ent1">The first entity to check.</param>
        // <param name="ent2">The second entity to check.</param>
        // <param name="type">The constraint type to look for (eg. "Weld", "Elastic", "NoCollide").</param>
        // <param name="bone1">The bone number for the first entity (0 for monoboned entities).</param>
        // <param name="bone2">The bone number for the second entity.</param>
        // <return>Entity|constraint</return>
        public virtual Entity Find(Entity ent1, Entity ent2, string type, float bone1, float bone2) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the first constraint of a specific type directly connected to the entity found</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="type">The type of constraint (eg. "Weld", "Elastic", "NoCollide").</param>
        // <return>table|The constraint table, set with {{LibraryFunction|constraint|AddConstraintTable}}</return>
        public virtual table FindConstraint(Entity ent, string type) {
            return new table();
        }
        
        // <realm>Server</realm>
        // <summary>Returns the other entity involved in the first constraint of a specific type directly connected to the entity</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="type">The type of constraint (eg. "Weld", "Elastic", "NoCollide").</param>
        // <return>Entity|The other entity.</return>
        public virtual Entity FindConstraintEntity(Entity ent, string type) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Returns a table of all constraints of a specific type directly connected to the entity</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="type">The type of constraint (eg. "Weld", "Elastic", "NoCollide").</param>
        // <return>table|All the constraints of this entity.</return>
        public virtual table FindConstraints(Entity ent, string type) {
            return new table();
        }
        
        // <realm>Server</realm>
        // <summary>Make this entity forget any constraints it knows about. Note that this will not actually remove the constraints.</summary>
        // <param name="ent">The entity that will forget its constraints.</param>
        public virtual void ForgetConstraints(Entity ent) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns a table of all entities recursively constrained to an entitiy.</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="ResultTable">Table used to return result. Optional.</param>
        // <return>table|A table containing all of the constrained entities. This includes all entities constrained to entities constrained to the supplied entity, etc.</return>
        public virtual table GetAllConstrainedEntities(Entity ent, table ResultTable) {
            return new table();
        }
        
        // <realm>Server</realm>
        // <summary>Returns a table of all constraints directly connected to the entity</summary>
        // <param name="ent">The entity to check.</param>
        // <return>table|A list of all constraints connected to the entity.</return>
        public virtual table GetTable(Entity ent) {
            return new table();
        }
        
        // <realm>Server</realm>
        // <summary>Returns true if the entity has constraints attached to it</summary>
        // <param name="ent">The entity to check.</param>
        // <return>boolean|Whether the entity has any constraints or not.</return>
        public virtual bool HasConstraints(Entity ent) {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Creates a Hydraulic constraint.</summary>
        // <param name="pl">The player that will be used to call {{LibraryFunction|numpad|OnDown}}.</param>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls),.</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="width">The width of the rope.</param>
        // <param name="key">The key binding, corresponding to an {{Enum|KEY}}.</param>
        // <param name="fixed">Whether the hydraulic is fixed.</param>
        // <param name="material">The material of the rope.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Hydraulic(Player pl, Entity Ent1, Entity Ent2, float Bone1, float Bone2, float width, float key, float @fixed, string material) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a keep upright constraint.</summary>
        // <param name="ent">The entity to keep upright.</param>
        // <param name="ang">The angle defined as "upright".</param>
        // <param name="bone">The bone of the entity to constrain (0 for boneless).</param>
        // <param name="angularLimit">Basically, the strength of the constraint.</param>
        // <return>Entity|The created constraint, if any</return>
        public virtual Entity Keepupright(Entity ent, Angle ang, float bone, float angularLimit) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a motor constraint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="nocollide">Whether the entities should be no-collided.</param>
        // <param name="toggle">Whether the constraint is on toggle.</param>
        // <param name="pl">The player that will be used to call {{LibraryFunction|numpad|OnDown}} and {{LibraryFunction|numpad|OnUp}}.</param>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="numpadkey_fwd">The key binding for "forward", corresponding to an {{Enum|KEY}}.</param>
        // <param name="numpadkey_bwd">The key binding for "backwards", corresponding to an {{Enum|KEY}}.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Motor(Entity Ent1, Entity Ent2, float Bone1, float Bone2, float nocollide, float toggle, Player pl, float forcelimit, float numpadkey_fwd, float numpadkey_bwd) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a muscle constraint.</summary>
        // <param name="pl">The player that will be used to call {{LibraryFunction|numpad|OnDown}}.</param>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="width">Width of the rope.</param>
        // <param name="key">The key binding, corresponding to an {{Enum|KEY}}.</param>
        // <param name="fixed">Whether the constraint is fixed.</param>
        // <param name="material">Material of the rope.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Muscle(Player pl, Entity Ent1, Entity Ent2, float Bone1, float Bone2, float width, float key, float @fixed, string material) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates an no-collide "constraint". Disables collision between two entities.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity NoCollide(Entity Ent1, Entity Ent2, float Bone1, float Bone2) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a pulley constraint.</summary>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="rigid">Whether the constraint is rigid.</param>
        // <param name="width">Width of the rope.</param>
        // <param name="material">Material of the rope.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Pulley(float forcelimit, boolean rigid, float width, string material) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Attempts to remove all constraints associated with an entity</summary>
        // <param name="ent">The entity to check.</param>
        // <return>boolean|removedConstraints</return>
        public virtual bool RemoveAll(Entity ent) {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Attempts to remove all constraints of a specified type associated with an entity</summary>
        // <param name="ent">The entity to check.</param>
        // <param name="type">The constraint type to remove (eg. "Weld", "Elastic", "NoCollide").</param>
        // <return>boolean|Whether we removed any constraints or not</return>
        public virtual bool RemoveConstraints(Entity ent, string type) {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Creates a rope constraint - with rope!</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls).</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="LPos1">Position of first end of the rope. Local to Ent1.</param>
        // <param name="LPos2">Position of second end of the rope. Local to Ent2.</param>
        // <param name="length">Length of the rope.</param>
        // <param name="addlength">Amount to add to the length of the rope. Works as it does in the Rope tool.</param>
        // <param name="forcelimit">Amount of force until it breaks (0.</param>
        // <param name="width">Width of the rope.</param>
        // <param name="material">Material of the rope.</param>
        // <param name="rigid">Whether the constraint is rigid.</param>
        // <return>Entity|Constraint. Will be a keyframe_rope if you roping to the same bone on the same entity. Will return false if the constraint could not be created.</return>
        public virtual Entity Rope(Entity Ent1, float Ent2, float Bone1, float Bone2, Vector LPos1, Vector LPos2, float length, float addlength, float forcelimit, float width, string material, boolean rigid) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a slider constraint.</summary>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls),.</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="width">The width of the rope.</param>
        // <param name="material">The material of the rope.</param>
        // <return>Entity|Constraint. Will return false if the constraint could not be created.</return>
        public virtual Entity Slider(Entity Ent1, Entity Ent2, float Bone1, float Bone2, float width, string material) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a weld constraint</summary>
        // <param name="ent1">The first entity.</param>
        // <param name="ent2">The second entity.</param>
        // <param name="bone1">The bonenumber of the first entity (0 for monoboned entities).</param>
        // <param name="bone2">The bonenumber of the second entity.</param>
        // <param name="forcelimit">The amount of force appliable to the constraint before it will break (0 is never).</param>
        // <param name="nocollide">Should ent1 be nocollided to ent2 via this constraint.</param>
        // <param name="deleteent1onbreak">If true, when ent2 is removed, ent1 will also be removed.</param>
        // <return>Entity|constraint</return>
        public virtual Entity Weld(Entity ent1, Entity ent2, float bone1, float bone2, float forcelimit, boolean nocollide, boolean deleteent1onbreak) {
            return new Entity();
        }
        
        // <realm>Server</realm>
        // <summary>Creates a Winch constraint.</summary>
        // <param name="pl">The player that will be used to call {{LibraryFunction|numpad|OnDown}} and {{LibraryFunction|numpad|OnUp}}.</param>
        // <param name="Ent1">First entity.</param>
        // <param name="Ent2">Second entity.</param>
        // <param name="Bone1">Bone of first entity (0 for non-ragdolls),.</param>
        // <param name="Bone2">Bone of second entity (0 for non-ragdolls).</param>
        // <param name="width">The width of the rope.</param>
        // <param name="key">The key binding for "forward", corresponding to an {{Enum|KEY}}.</param>
        // <param name="key1">The key binding for "backwards", corresponding to an {{Enum|KEY}}.</param>
        // <param name="fwd_speed">Forward speed.</param>
        // <param name="bwd_speed">Backwards speed.</param>
        // <param name="material">The material of the rope.</param>
        // <param name="toggle">Whether the winch should be on toggle.</param>
        // <return>Entity|Constraint. Can return nil. Will return false if the constraint could not be created.</return>
        public virtual Entity Winch(Player pl, Entity Ent1, Entity Ent2, float Bone1, float Bone2, float width, float key, float key1, float fwd_speed, float bwd_speed, string material, boolean toggle) {
            return new Entity();
        }
    }
}
