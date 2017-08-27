// MIT License
// 
// Copyright (c) 2017 reapler https://github.com/reapler
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
using System;
using System.Collections.Generic;
using DatabaseManager.Enums;
using DatabaseManager.Types;


namespace DatabaseManager.Filter
{
    /// <summary>
    /// <para />Used for filtering items
    /// <remarks>
    /// <para>[Caution] Poor filtering can result in high memory usage &amp; access delay</para>
    /// </remarks>
    /// </summary>
    public class ItemFilter
    {
        /// <summary>
        /// Restrict by id
        /// </summary>
        public HashSet<int> Ids { get; set; } = new HashSet<int>();

        /// <summary>
        /// Restrict by name
        /// </summary>
        public string Name { get; set; } = "";
        
        /// <summary>
        /// Restrict by type
        /// </summary>
        public ItemClass Type { get; set; } = new ItemClass();

        /// <summary>
        /// Restrict by quality
        /// </summary>
        public ItemQuality Quality { get; set; } = ItemQuality.All;

        /// <summary>
        /// Restrict by minimum item level
        /// </summary>
        public int MinILevel { get; set; } = 0;

        /// <summary>
        /// Restrict by maximum item level
        /// </summary>
        public int MaxILevel { get; set; } = int.MaxValue;

        /// <summary>
        /// Restrict by the minimum required level to use
        /// </summary>
        public int MinLevelRequired { get; set; } = 0;

        /// <summary>
        /// Restrict by the maximum required level to use
        /// </summary>
        public int MaxLevelRequired { get; set; } = int.MaxValue;

        /// <summary>
        /// Restrict by maximum buy price
        /// </summary>
        public int MaxBuyPrice { get; set; } = int.MaxValue;
        
        /// <summary>
        /// Restrict by contained spell-id
        /// </summary>
        public HashSet<uint> HasSpells { get; set; } = new HashSet<uint>();

        /// <summary>
        /// Restrict by contained loot
        /// </summary>
        public HashSet<int> HasItems { get; set; } = new HashSet<int>();
        
        /// <summary>
        /// Exclude these ids (useful for blacklisting)
        /// </summary>
        public HashSet<int> ExcludeIds { get; set; } = new HashSet<int>();
    }
}









