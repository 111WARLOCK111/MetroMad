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
    
    
    public class engine {
        
        // <realm>Shared</realm>
        // <summary>Returns the name of the currently running gamemode.</summary>
        // <return>string|The active gamemode's name.</return>
        public virtual string ActiveGamemode() {
            return "String";
        }
        
        // <realm>Server</realm>
        // <summary>Closes the server and completely exits.</summary>
        public virtual void CloseServer() {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the addons you have downloaded from the workshop.</summary>
        // <return>table|Returns a table with 6 keys (downloaded, models, title, file, mounted, wsid)</return>
        public virtual table GetAddons() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>When starting playing a demo, {{LibraryFunction|engine|GetDemoPlaybackTick}} will be reset and its old value will be added to this functions return value.</summary>
        public virtual int GetDemoPlaybackStartTick() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Current tick of currently loaded demo.</summary>
        // <return>number|The amount of ticks of currently loaded demo.</return>
        public virtual int GetDemoPlaybackTick() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns time scale of demo playback.</summary>
        // <return>number|The time scale of demo playback, value of demo_timescale console variable.</return>
        public virtual int GetDemoPlaybackTimeScale() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns total amount of ticks of currently loaded demo.</summary>
        // <return>number|Total amount of ticks of currently loaded demo.</return>
        public virtual int GetDemoPlaybackTotalTicks() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a table containing info for all installed gamemodes</summary>
        // <return>table|gamemodes</return>
        public virtual table GetGamemodes() {
            return new table();
        }
        
        // <realm>Shared</realm>
        // <summary>Returns an array of tables corresponding to all games from which Garry's Mod supports mounting content.</summary>
        // <return>table|A table containing all mountable games</return>
        public virtual table GetGames() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Returns true if we're currently playing a demo.</summary>
        // <return>boolean|Whether the game is currently playing a demo or not.</return>
        public virtual bool IsPlayingDemo() {
            return true;
        }
        
        // <realm>Client</realm>
        // <summary>Returns true if the game is currently recording a demo file (.dem) using gm_demo</summary>
        // <return>boolean|Whether the game is currently recording a demo or not.</return>
        public virtual bool IsRecordingDemo() {
            return true;
        }
        
        // <realm>Server</realm>
        // <summary>This is a direct binding to the function “engine->LightStyle”. This function allows you to change the default light style of the map - so you can make lighting lighter or darker. You’ll need to call {{LibraryFunction|render|RedownloadAllLightmaps}} clientside to refresh the lightmaps to this new color.</summary>
        // <param name="lightstyle">The lightstyle to edit. If you want to edit map lighting, you want to set this to 0.</param>
        // <param name="pattern">The pattern to change the lightstyle to. "a" is the darkest, "z" is the brightest. You can use stuff like "abcxyz" to make flashing patterns. The normal brightness for a map is "m".</param>
        public virtual void LightStyle(float lightstyle, string pattern) {
        }
        
        // <realm>Client</realm>
        // <summary>Loads a duplication from the local filesystem.</summary>
        // <param name="dupeName">Name of the file. e.g, engine.OpenDupe("dupes/8b809dd7a1a9a375e75be01cdc12e61f.dupe").</param>
        // <return>string|Compressed dupeData. Use util.JSONToTable to make it into a format useable by the duplicator tool.</return>
        public virtual string OpenDupe(string dupeName) {
            return "String";
        }
        
        // <realm>Menu</realm>
        // <summary>Sets the mounting options for mountable content.</summary>
        // <param name="depotID">The depot id of the game to mount.</param>
        // <param name="doMount">The mount state, true to mount, false to unmount.</param>
        public virtual void SetMounted(string depotID, boolean doMount) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the number of seconds between each gametick.</summary>
        // <return>number|Number of seconds between each gametick.</return>
        public virtual int TickInterval() {
            return 1;
        }
        
        // <realm>Client</realm>
        // <summary>Returns video recording settings set by {{LibraryFunction|video|Record}}. Used by Demo-To-Video feature.</summary>
        // <return>table|The video recording settings, see {{Struct|VideoData}}.</return>
        public virtual table VideoSettings() {
            return new table();
        }
        
        // <realm>Client</realm>
        // <summary>Saves a duplication as a file.</summary>
        // <param name="dupe">Dupe table, encoded by {{LibraryFunction|util|TableToJSON}} and compressed by {{LibraryFunction|util|Compress}}.</param>
        // <param name="jpeg">The dupe icon, created by {{LibraryFunction|render|Capture}}.</param>
        public virtual void WriteDupe(string dupe, string jpeg) {
        }
        
        // <realm>Client</realm>
        // <summary>Stores savedata into the game (can be loaded using the LoadGame menu)</summary>
        // <param name="saveData">Data generated by gmsave.SaveMap.</param>
        // <param name="name">Name the save will have.</param>
        // <param name="time">When the save was saved during the game (Put CurTime here).</param>
        // <param name="map">The map the save is used for.</param>
        public virtual void WriteSave(string saveData, string name, float time, string map) {
        }
    }
}
