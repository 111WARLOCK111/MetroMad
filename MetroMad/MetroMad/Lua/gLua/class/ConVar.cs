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
    
    
    public class ConVar {
        
        // <realm>Shared</realm>
        // <summary>Tries to convert the current string value of a {{Type|ConVar}} to a boolean.</summary>
        // <return>boolean|The boolean value of the console variable, where everything except "1" evaluates to false.</return>
        public virtual bool GetBool() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the default value of the {{Type|ConVar}}</summary>
        // <return>string|The default value of the console variable.</return>
        public virtual string GetDefault() {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Attempts to convert the {{Type|ConVar}} value to a float</summary>
        // <return>number|The float value of the console variable.<br/></return>
        public virtual int GetFloat() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the help text assigned to that convar.</summary>
        // <return>string|The help text</return>
        public virtual string GetHelpText() {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Attempts to convert the {{Type|ConVar}} value to a integer.</summary>
        // <return>number|The integer value of the console variable.<br/></return>
        public virtual int GetInt() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the name of the {{Type|ConVar}}.</summary>
        // <return>string|The name of the console variable.</return>
        public virtual string GetName() {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the current {{Type|ConVar}} value as a string.</summary>
        // <return>string|The current console variable value as a string.</return>
        public virtual string GetString() {
            return "String";
        }
    }
}
