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
    
    
    public class NPC {
        
        // <realm>Server</realm>
        // <summary>Makes the NPC like, hate, feel neutral towards, or fear the entity in question. If you want to setup relationship towards a certain entity ''class'', use {{ClassFunction|NPC|AddRelationship}}.</summary>
        // <param name="target">The entity for the relationship to be applied to.</param>
        // <param name="disposition">A {{Enum|D}} representing the relationship type.</param>
        // <param name="priority">How strong the relationship is.</param>
        public virtual void AddEntityRelationship(Entity target, float disposition, float priority) {
        }
        
        // <realm>Server</realm>
        // <summary>Changes how an NPC feels towards another NPC.  If you want to setup relationship towards a certain ''entity'', use {{ClassFunction|NPC|AddEntityRelationship}}.</summary>
        // <param name="relationstring">A string representing how the relationship should be set up.</param>
        public virtual void AddRelationship(string relationstring) {
        }
        
        // <realm>Server</realm>
        // <summary>Force an NPC to play his Alert sound.</summary>
        public virtual void AlertSound() {
        }
        
        // <realm>Server</realm>
        // <summary>Adds a capability to the NPC</summary>
        // <param name="capabilities">Capabilities to add, see {{Enum|CAP}}.</param>
        public virtual void CapabilitiesAdd(float capabilities) {
        }
        
        // <realm>Server</realm>
        public virtual void CapabilitiesClear() {
        }
        
        // <realm>Server</realm>
        public virtual void CapabilitiesGet() {
        }
        
        // <realm>Server</realm>
        // <summary>Remove a certain capability.</summary>
        // <param name="capabilities">Capabilities to remove, see {{Enum|CAP}}.</param>
        public virtual void CapabilitiesRemove(float capabilities) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the NPC class. Do not confuse with {{ClassFunction|Entity|GetClass}}!</summary>
        // <return>number|See {{Enum|CLASS}}</return>
        public virtual int Classify() {
            return 1;
        }
        
        // <realm>Server</realm>
        public virtual void ClearCondition() {
        }
        
        // <realm>Server</realm>
        public virtual void ClearEnemyMemory() {
        }
        
        // <realm>Server</realm>
        public virtual void ClearExpression() {
        }
        
        // <realm>Server</realm>
        public virtual void ClearGoal() {
        }
        
        // <realm>Server</realm>
        public virtual void ClearSchedule() {
        }
        
        // <realm>Server</realm>
        // <summary>Translates condition ID to a string.</summary>
        // <param name="cond">The NPCs condition ID.</param>
        // <return>string|A human understandable string equivalent of that condition.</return>
        public virtual string ConditionName(float cond) {
            return "String";
        }
        
        // <realm>Server</realm>
        // <summary>Returns the way the NPC "feels" about the entity.</summary>
        // <param name="ent">The entity to get the disposition from.</param>
        // <return>number|The NPCs disposition, see {{Enum|D}}.</return>
        public virtual int Disposition(Entity ent) {
            return 1;
        }
        
        // <realm>Server</realm>
        // <summary>Makes an NPC exit a scripted sequence, if one is playing.</summary>
        public virtual void ExitScriptedSequence() {
        }
        
        // <realm>Server</realm>
        // <summary>Force an NPC to play his Fear sound.</summary>
        public virtual void FearSound() {
        }
        
        // <realm>Server</realm>
        // <summary>Force an NPC to play his FoundEnemy sound.</summary>
        public virtual void FoundEnemySound() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the weapon the NPC is currently carrying, if it does carry any</summary>
        // <return>Entity|The NPCs current weapon</return>
        public virtual Entity GetActiveWeapon() {
            return new Entity();
        }
        
        // <realm>Shared</realm>
        public virtual void GetActivity() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the aim vector of the NPC. NPC alternative of {{ClassFunction|Player|GetAimVector}}.</summary>
        // <return>Vector|The aim direction of the NPC.</return>
        public virtual Vector GetAimVector() {
            return new Vector();
        }
        
        // <realm>Server</realm>
        public virtual void GetArrivalActivity() {
        }
        
        // <realm>Server</realm>
        public virtual void GetArrivalSequence() {
        }
        
        // <realm>Server</realm>
        public virtual void GetBlockingEntity() {
        }
        
        // <realm>Server</realm>
        public virtual void GetCurrentWeaponProficiency() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the entity that this NPC is trying to fight</summary>
        // <return>NPC|Enemy NPC</return>
        public virtual NPC GetEnemy() {
            return new NPC();
        }
        
        // <realm>Server</realm>
        public virtual void GetExpression() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns NPCs hull type set by {{ClassFunction|NPC|SetHullType}}.</summary>
        // <return>number|Hull type, see {{Enum|HULL}}</return>
        public virtual int GetHullType() {
            return 1;
        }
        
        // <realm>Server</realm>
        public virtual void GetMovementActivity() {
        }
        
        // <realm>Server</realm>
        public virtual void GetMovementSequence() {
        }
        
        // <realm>Server</realm>
        public virtual void GetNPCState() {
        }
        
        // <realm>Server</realm>
        public virtual void GetPathDistanceToGoal() {
        }
        
        // <realm>Server</realm>
        public virtual void GetPathTimeToGoal() {
        }
        
        // <realm>Server</realm>
        public virtual void GetShootPos() {
        }
        
        // <realm>Server</realm>
        public virtual void GetTarget() {
        }
        
        // <realm>Server</realm>
        // <summary>Used to give a weapon to an already spawned NPC.</summary>
        // <param name="weapon">Class name of the weapon to equip to the NPC.</param>
        // <return>Weapon|The weapon entity given to the NPC.</return>
        public virtual Weapon Give(string weapon) {
            return new Weapon();
        }
        
        // <realm>Server</realm>
        public virtual void HasCondition() {
        }
        
        // <realm>Server</realm>
        // <summary>Force an NPC to play his Idle sound.</summary>
        public virtual void IdleSound() {
        }
        
        // <realm>Server</realm>
        public virtual void IsCurrentSchedule() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns whether the NPC is moving or not.</summary>
        // <return>boolean|Whether the NPC is moving or not.</return>
        public virtual bool IsMoving() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the entity is a NPC or not.</summary>
        // <return>boolean|isNPC</return>
        public virtual bool IsNPC() {
            return true;
        }
        
        // <realm>Server</realm>
        public virtual void IsRunningBehavior() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns whether the entity given can be reached by this NPC.</summary>
        // <param name="testEntity">The entity to test.</param>
        // <return>boolean|If the entity is reachable or not.</return>
        public virtual bool IsUnreachable(Entity testEntity) {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>Force an NPC to play his LostEnemy sound.</summary>
        public virtual void LostEnemySound() {
        }
        
        // <realm>Server</realm>
        public virtual void MaintainActivity() {
        }
        
        // <realm>Server</realm>
        public virtual void MarkEnemyAsEluded() {
        }
        
        // <realm>Server</realm>
        public virtual void MoveOrder() {
        }
        
        // <realm>Server</realm>
        public virtual void NavSetGoal() {
        }
        
        // <realm>Server</realm>
        // <summary>Set the goal target for an NPC.</summary>
        // <param name="target">The targeted entity to set the goal to.</param>
        // <param name="offset">The offset to apply to the targeted entity's position.</param>
        public virtual void NavSetGoalTarget(Entity target, Vector offset) {
        }
        
        // <realm>Server</realm>
        public virtual void NavSetRandomGoal() {
        }
        
        // <realm>Server</realm>
        public virtual void NavSetWanderGoal() {
        }
        
        // <realm>Server</realm>
        // <summary>Forces the NPC to play a sentence from scripts/sentences.txt</summary>
        // <param name="sentence">The sentence string to speak.</param>
        // <param name="delay">Delay in seconds until the sentence starts playing.</param>
        // <param name="volume">The volume of the sentence, from 0 to 1.</param>
        // <return>number|Returns the sentence index, -1 if the sentence couldn't be played.</return>
        public virtual int PlaySentence(string sentence, float delay, float volume) {
            return 1;
        }
        
        // <realm>Server</realm>
        public virtual void RemoveMemory() {
        }
        
        // <realm>Server</realm>
        public virtual void RunEngineTask() {
        }
        
        // <realm>Server</realm>
        public virtual void SentenceStop() {
        }
        
        // <realm>Server</realm>
        public virtual void SetArrivalActivity() {
        }
        
        // <realm>Server</realm>
        public virtual void SetArrivalDirection() {
        }
        
        // <realm>Server</realm>
        public virtual void SetArrivalDistance() {
        }
        
        // <realm>Server</realm>
        public virtual void SetArrivalSequence() {
        }
        
        // <realm>Server</realm>
        public virtual void SetArrivalSpeed() {
        }
        
        // <realm>Server</realm>
        public virtual void SetCondition() {
        }
        
        // <realm>Server</realm>
        public virtual void SetCurrentWeaponProficiency() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the target for an NPC.</summary>
        // <param name="enemy">The enemy that the NPC should target.</param>
        public virtual void SetEnemy(Entity enemy) {
        }
        
        // <realm>Server</realm>
        public virtual void SetExpression() {
        }
        
        // <realm>Server</realm>
        public virtual void SetHullSizeNormal() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the hull type for the NPC.</summary>
        // <param name="hullType">Hull type. See {{Enum|HULL}}.</param>
        public virtual void SetHullType(float hullType) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the last registered or memorized position for an npc. When using scheduling, the NPC will focus on navigating to the last position via nodes.<br /><br /></summary>
        // <param name="Position">Where the NPC's last position will be set.</param>
        public virtual void SetLastPosition(Vector Position) {
        }
        
        // <realm>Server</realm>
        public virtual void SetMaxRouteRebuildTime() {
        }
        
        // <realm>Server</realm>
        public virtual void SetMovementActivity() {
        }
        
        // <realm>Server</realm>
        public virtual void SetMovementSequence() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the state the NPC is in to help it decide on a ideal schedule.</summary>
        // <param name="state">New NPC state, see {{Enum|NPC}}.</param>
        public virtual void SetNPCState(float state) {
        }
        
        // <realm>Server</realm>
        public virtual void SetSchedule() {
        }
        
        // <realm>Server</realm>
        public virtual void SetTarget() {
        }
        
        // <realm>Server</realm>
        public virtual void StartEngineTask() {
        }
        
        // <realm>Server</realm>
        public virtual void StopMoving() {
        }
        
        // <realm>Server</realm>
        public virtual void TargetOrder() {
        }
        
        // <realm>Server</realm>
        public virtual void TaskComplete() {
        }
        
        // <realm>Server</realm>
        // <param name="unknown">A string that has an unknown effect on the NPC. May have something to do with Single Player.</param>
        public virtual void TaskFail(string unknown) {
        }
        
        // <realm>Server</realm>
        public virtual void UpdateEnemyMemory() {
        }
        
        // <realm>Server</realm>
        public virtual void UseActBusyBehavior() {
        }
        
        // <realm>Server</realm>
        public virtual void UseAssaultBehavior() {
        }
        
        // <realm>Server</realm>
        public virtual void UseFollowBehavior() {
        }
        
        // <realm>Server</realm>
        public virtual void UseFuncTankBehavior() {
        }
        
        // <realm>Server</realm>
        public virtual void UseLeadBehavior() {
        }
        
        // <realm>Server</realm>
        public virtual void UseNoBehavior() {
        }
    }
}
