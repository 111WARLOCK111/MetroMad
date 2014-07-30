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
    
    
    public class math {
        
        // <realm>Shared</realm>
        // <summary>Calculates the absolute value of a number (effectively removes any negative sign).</summary>
        // <param name="x">The number to get the absolute value of.</param>
        public static void abs(float x) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the arc cosine of the given number.</summary>
        // <param name="normal">Value in range of -1 - 1.</param>
        public static void acos(float normal) {
        }
        
        // <realm>Shared</realm>
        // <summary>Calculates the difference between two angles.</summary>
        // <param name="a">The first angle.</param>
        // <param name="b">The second angle.</param>
        public static void AngleDifference(float a, float b) {
        }
        
        // <realm>Shared</realm>
        // <summary>Increments a value from a start point by the given amount, up to a given upper limit.</summary>
        // <param name="start">The number to start with.</param>
        // <param name="end">The max value, this function will never return a number greater than this.</param>
        // <param name="amount">The amount to increment the starting number by.</param>
        public static void Approach(float start, float end, float amount) {
        }
        
        // <realm>Shared</realm>
        // <summary>Increments an angle towards another by specified rate</summary>
        // <param name="currentAngle">The current angle to increase.</param>
        // <param name="targetAngle">The angle to increase towards.</param>
        // <param name="rate">The amount to approach the target angle by.</param>
        public static void ApproachAngle(float currentAngle, float targetAngle, float rate) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the arc sine of the given number.</summary>
        // <param name="normal">Value in range of -1 - 1.</param>
        public static void asin(float normal) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the arc tangents of the given number.</summary>
        // <param name="normal">Value in range of -1 - 1.</param>
        public static void atan(float normal) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the atan2 of the specified values.</summary>
        // <param name="y">Y coordinate.</param>
        // <param name="x">X coordinate.</param>
        public static void atan2(float y, float x) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts a binary string into a number.</summary>
        // <param name="string">Binary string to convert.</param>
        public static void BinToInt(string @string) {
        }
        
        // <realm>Shared</realm>
        // <summary>Basic code for Bezier-Spline algorithm.</summary>
        // <param name="tPoints">A table of {{GlobalFunction|Vector}}s.</param>
        public static void BSplinePoint(table tPoints) {
        }
        
        // <realm>Shared</realm>
        // <summary>Basic code for Bezier-Spline algorithm.</summary>
        public static void calcBSplineN() {
        }
        
        // <realm>Shared</realm>
        // <summary>Ceils or rounds a number up.</summary>
        // <param name="number">The number to be rounded up.</param>
        public static void ceil(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Clamps a number between a minimum and maximum value</summary>
        // <param name="input">The number to clamp.</param>
        // <param name="min">The minimum value, this function will never return a number less than this.</param>
        // <param name="max">The maximum value, this function will never return a number greater than this.</param>
        public static void Clamp(float input, float min, float max) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns cosine of given angle.</summary>
        // <param name="number">Angle in radians.</param>
        public static void cos(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns hyperbolic cosine of the given number.</summary>
        // <param name="number">Value in radians.</param>
        public static void cosh(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts radians to degrees.</summary>
        // <param name="radians">Value to be converted to degrees.</param>
        public static void deg(float radians) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Deprecated|You should use {{LibraryFunction|math|Distance}} instead}}</summary>
        // <param name="x1">X position of first point.</param>
        // <param name="y1">Y position of first point.</param>
        // <param name="x2">X position of second point.</param>
        // <param name="y2">Y position of second point.</param>
        public static void Dist(float x1, float y1, float x2, float y2) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the difference between two points in 2D space. Alias of {{LibraryFunction|math|Dist}}</summary>
        // <param name="x1">X position of first point.</param>
        // <param name="y1">Y position of first point.</param>
        // <param name="x2">X position of second point.</param>
        // <param name="y2">Y position of second point.</param>
        public static void Distance(float x1, float y1, float x2, float y2) {
        }
        
        // <realm>Shared</realm>
        // <summary>Calculates the progress of a value fraction, taking in to account given easing fractions</summary>
        // <param name="progress">Fraction of the progress to ease.</param>
        // <param name="easeIn">Fraction of how much easing to begin with.</param>
        // <param name="easeOut">Fraction of how much easing to end with.</param>
        public static void EaseInOut(float progress, float easeIn, float easeOut) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the x power of the euler constant.</summary>
        // <param name="exponent">The exponent for the function.</param>
        public static void exp(float exponent) {
        }
        
        // <realm>Shared</realm>
        // <summary>Floors or rounds a number down.</summary>
        // <param name="number">The number to be rounded down.</param>
        public static void floor(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the modulus of the specified values.</summary>
        // <param name="base">The base value.</param>
        // <param name="modulator">The modulator.</param>
        public static void fmod(float @base, float modulator) {
        }
        
        // <realm>Shared</realm>
        // <summary>used to split the number value into a normalized fraction and an exponent. Two values are returned: the first is a value always in the range 1/2 (inclusive) to 1 (exclusive) and the second is an exponent.</summary>
        // <param name="inputValue">The value to get the normalized fraction and the exponent from.</param>
        public static void frexp(float inputValue) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts an integer to a binary (base-2) string</summary>
        // <param name="number">Number to be converted.</param>
        public static void IntToBin(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Takes a normalised number and returns the floating point representation.</summary>
        // <param name="normalizedFraction">The value to get the normalized fraction and the exponent from.</param>
        // <param name="exponent">The value to get the normalized fraction and the exponent from.</param>
        public static void ldexp(float normalizedFraction, float exponent) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the the given exponent for the base e.</summary>
        // <param name="value">The value to get the base from exponent from.</param>
        public static void log(float value) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the the given exponent for the base 10.</summary>
        // <param name="value">The value to get the base from exponent from.</param>
        public static void log10(float value) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the largest value of all arguments.</summary>
        // <param name="numbers">Numbers to get the largest from.</param>
        public static void max(vararg numbers) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the smallest value of all arguments.</summary>
        // <param name="numbers">Numbers to get the smallest from.</param>
        public static void min(vararg numbers) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Deprecated|This is removed in Lua versions later than what GMod is currently using. You should use {{LibraryFunction|math|fmod}} instead.}}</summary>
        // <param name="base">The base value.</param>
        // <param name="modulator">Modulator.</param>
        public static void mod(float @base, float modulator) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the integral and fractional component of the modulo operation.</summary>
        // <param name="base">The base value.</param>
        // <param name="modulator">The modulator.</param>
        public static void modf(float @base, float modulator) {
        }
        
        // <realm>Shared</realm>
        // <summary>Normalizes angle, so it returns value between -180 and 180.</summary>
        // <param name="angle">The angle to normalize, in degrees.</param>
        public static void NormalizeAngle(float angle) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the y power of x.</summary>
        // <param name="x">Base.</param>
        // <param name="y">Exponent.</param>
        public static void pow(float x, float y) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts an angle in degrees to it's equivalent in radians.</summary>
        // <param name="degrees">The angle measured in degrees.</param>
        public static void rad(float degrees) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a random float between min and max.</summary>
        // <param name="min">The minimum value.</param>
        // <param name="max">The maximum value.</param>
        public static void Rand(float min, float max) {
        }
        
        // <realm>Shared</realm>
        // <summary>If no value is specified, a random float value between 0-1 will be returned, if the first value is specified, a integer value between 1 and the specified value will be returned, if both values are specified, a integer value between the first and the second value will be returned, all inputs are rounded.</summary>
        // <param name="limitOrLimitStart">Limit or begin of limit.</param>
        // <param name="limit">End of limit.</param>
        public static void random(float limitOrLimitStart, float limit) {
        }
        
        // <realm>Shared</realm>
        // <summary>Seeds the "seed" for the random generator, which will cause {{LibraryFunction|math|random}} to return the same sequence of numbers.</summary>
        // <param name="seed">The new seed.</param>
        public static void randomseed(float seed) {
        }
        
        // <realm>Shared</realm>
        // <summary>Remaps the value from one range to another</summary>
        // <param name="value">The value.</param>
        // <param name="inMin">The minimum of the initial range.</param>
        // <param name="inMax">The maximum of the initial range.</param>
        // <param name="outMin">The minimum of new range.</param>
        // <param name="outMax">The maximum of new range.</param>
        public static void Remap(float value, float inMin, float inMax, float outMin, float outMax) {
        }
        
        // <realm>Shared</realm>
        // <summary>Rounds the given value to the nearest whole number or to the given decimal places.</summary>
        // <param name="value">The value to round.</param>
        // <param name="decimals">The decimal places to round to.</param>
        public static void Round(float value, float decimals) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns sine of given angle.</summary>
        // <param name="number">Angle in radians.</param>
        public static void sin(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns hyperbolic sine of the given number.</summary>
        // <param name="number">Value in radians.</param>
        public static void sinh(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the square root of the number.</summary>
        // <param name="value">Value to get the square root from.</param>
        public static void sqrt(float value) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns tangents of given angle.</summary>
        // <param name="value">Angle in radians.</param>
        public static void tan(float value) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns hyperbolic tangents of the given number.</summary>
        // <param name="number">Value in radians.</param>
        public static void tanh(float number) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the fraction of where the current time is relative to the start and end times</summary>
        // <param name="start">Start time in seconds.</param>
        // <param name="end">End time in seconds.</param>
        // <param name="current">Current time in seconds.</param>
        public static void TimeFraction(float start, float end, float current) {
        }
    }
}