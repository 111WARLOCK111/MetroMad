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
    
    
    public class net {
        
        // <realm>Server</realm>
        // <summary>Sends the currently build net message to all connected players</summary>
        public static void Broadcast() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the size of the current message in bytes.</summary>
        public static void BytesWritten() {
        }
        
        // <realm>Shared</realm>
        // <summary>Function called by the engine to tell the lua state a message arrived, you should not modify this function.</summary>
        // <param name="length">message length in bits.</param>
        // <param name="client">Serverside, this will be the client that send the message, on the clientside this will be nil.</param>
        public static void Incoming(float length, Entity client) {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads an angle from the received net message.</summary>
        public static void ReadAngle() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a boolean from the received net message.</summary>
        public static void ReadBit() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a {{Struct|Color}} from the current net message.</summary>
        public static void ReadColor() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads pure binary data from the message.</summary>
        // <param name="length">The length of the data to be read, in bytes.</param>
        public static void ReadData(float length) {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a double-precision number from the received net message.</summary>
        public static void ReadDouble() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads an entity from the received net message. You should always check if the specified entity exists as it may have been removed and therefor NULL if it is outside of the players PVS or was already removed.</summary>
        public static void ReadEntity() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a floating point number from the received net message.</summary>
        public static void ReadFloat() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the "header" of the message which contains a short which can be converted to the corresponding message name via {{LibraryFunction|util|NetworkIDToString}}.</summary>
        public static void ReadHeader() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads an integer from the received net message.</summary>
        // <param name="bitCount">The amount of bits to be read, should be power of 2.</param>
        public static void ReadInt(float bitCount) {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a normal vector from the net message.</summary>
        public static void ReadNormal() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a null terminated string from the net stream.</summary>
        public static void ReadString() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a table from the received net message.</summary>
        public static void ReadTable() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a value from the usermessage with the specified type.</summary>
        // <param name="TypeID">The type of value to be read, using {{Enum|TYPE}}.</param>
        public static void ReadType(float TypeID) {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads an unsigned integer with the specified number of bits from the received net message.</summary>
        // <param name="numberOfBits">The size of the integer to be read, in bits.</param>
        public static void ReadUInt(float numberOfBits) {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a vector from the received net message.  Vectors sent by this function are compressed, which may result in precision loss. See {{LibraryFunction|net|WriteVector}} for more information.</summary>
        public static void ReadVector() {
        }
        
        // <realm>Shared</realm>
        // <summary>Adds a net message handler. You '''must''' put this function '''outside''' of any other function or hook for it to work properly.</summary>
        // <param name="messageName">The message name to hook to.</param>
        // <param name="callback">The function to be called if the specified message was received. Arugments are:.</param>
        public static void Receive(string messageName, function callback) {
        }
        
        // <realm>Server</realm>
        // <summary>Sends the current message to the specified player, or to all players listed in the table.</summary>
        // <param name="ply">The player(s) to send the message to. Can be a table of players.</param>
        public static void Send(any ply) {
        }
        
        // <realm>Server</realm>
        // <summary>Sends the current message to all except the specified, or to all except all players in the table.</summary>
        // <param name="ply">The player(s) to NOT send the message to. Can be a table of players.</param>
        public static void SendOmit(Player ply) {
        }
        
        // <realm>Server</realm>
        // <summary>Sends the message to all players that are in the same potentially audible set(PAS) as the position, or simply said, it adds all players that can potentially hear sounds from this position.</summary>
        // <param name="position">PAS position.</param>
        public static void SendPAS(Vector position) {
        }
        
        // <realm>Server</realm>
        // <summary>Sends the message to all players that are in the same potentially visibility set(PVS) as the position, or simply said, it adds all players that can potentially be seen from this position.</summary>
        // <param name="position">PVS position.</param>
        public static void SendPVS(Vector position) {
        }
        
        // <realm>Client</realm>
        // <summary>Sends the current message to the server.</summary>
        public static void SendToServer() {
        }
        
        // <realm>Shared</realm>
        // <summary>Begins a new net message.</summary>
        // <param name="messageName">The name of the message to send.</param>
        // <param name="unreliable">If set to true, the message is not guaranteed to reach its destination.</param>
        public static void Start(string messageName, boolean unreliable) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes an angle to the current net message.</summary>
        // <param name="angle">The angle to be sent.</param>
        public static void WriteAngle(Angle angle) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a boolean to the current net message.</summary>
        // <param name="boolean">T.</param>
        public static void WriteBit(boolean boolean) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a {{Struct|Color}} to the current net message.</summary>
        // <param name="Color">The {{Struct|Color}} you want to append to the net message.</param>
        public static void WriteColor(table Color) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a chunk of binary data to the message.</summary>
        // <param name="binaryData">The binary data to be sent.</param>
        // <param name="length">The length of the binary data to be sent, in bytes.</param>
        public static void WriteData(string binaryData, float length) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a double-precision number to the current net message.</summary>
        // <param name="double">The double to be sent.</param>
        public static void WriteDouble(float @double) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends an entity to the current net message.</summary>
        // <param name="entity">The entity to be sent.</param>
        public static void WriteEntity(Entity entity) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a float (number with decimals) to the current net message.</summary>
        // <param name="float">The float to be sent.</param>
        public static void WriteFloat(float @float) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends an integer (number without decimals) to the current net message.</summary>
        // <param name="integer">The integer to be sent.</param>
        // <param name="bitCount">The amount of bits the number consists of. (signed).</param>
        public static void WriteInt(float integer, float bitCount) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a normal vector to the net message.</summary>
        // <param name="normal">The normal vector to be send.</param>
        public static void WriteNormal(Vector normal) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a string to the current net message.</summary>
        // <param name="string">The string to be sent.</param>
        public static void WriteString(string @string) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a table to the current net message.</summary>
        // <param name="table">The table to be sent.</param>
        public static void WriteTable(table table) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends any type of value to the usermessage.</summary>
        // <param name="Data">The data to be sent. A UInt(8) indicating the type will automatically be written to the packet before the value, in order to facilitate reading with net.ReadType.</param>
        public static void WriteType(any Data) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends an unsigned integer with the specified number of bits to the current net message.</summary>
        // <param name="unsignedInteger">The unsigned integer to be sent.</param>
        // <param name="numberOfBits">The size of the integer to be sent, in bits. Acceptable values range from 1 to 32. Other values will cause undefined behaviour.</param>
        public static void WriteUInt(float unsignedInteger, float numberOfBits) {
        }
        
        // <realm>Shared</realm>
        // <summary>Appends a vector to the current net message.</summary>
        // <param name="vector">The vector to be sent.</param>
        public static void WriteVector(Vector vector) {
        }
    }
}
