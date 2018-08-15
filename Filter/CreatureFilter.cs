// MIT License
// 
// Copyright (c) 2018 reapler https://github.com/reapler
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
using wManager.Wow.Enums;


namespace DatabaseManager.Filter
{
    /// <summary>
    /// <para />Used for filtering Items
    /// <remarks>
    /// <para>[Caution] Poor filtering can result in high memory usage &amp; access delay</para>
    /// </remarks>
    /// </summary>
    public class CreatureFilter
    {
        /// <summary>
        /// Restrict by continent
        /// </summary>
        public ContinentId ContinentId { get; set; } = ContinentId.None;

        /// <summary>
        /// Restrict by name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Minimum level of the creature
        /// </summary>
        public int MinLevel { get; set; } = 0;

        /// <summary>
        /// Maximum level of the creature
        /// </summary>
        public int MaxLevel { get; set; } = int.MaxValue;
        
        /// <summary>
        /// Creatures's maximum allowed distance from "Range.From"
        /// </summary>
        /// <see cref="Types.Range"/>
        public Range Range { get; set; } = new Range();
        
        /// <summary>
        /// Restrict by given faction & wanted reaction
        /// </summary>
        /// <see cref="Types.Faction"/>
        public Faction Faction { get; set; } = new Faction();

        /// <summary>
        /// Restrict by trainer type
        /// </summary>
        /// <para>Default: Train.None</para>
        /// <see cref="DatabaseManager.Enums.Train"/>
        public Train Trainer { get; set; } = Train.All;
        
        /// <summary>
        /// Restrict by dropped loot or sold items
        /// </summary>
        /// <see cref="DatabaseManager.Enums.ContainedIn"/>
        public ItemIds HasItems { get; set; } = new ItemIds();

        /// <summary>
        /// Restrict by id
        /// </summary>
        public HashSet<int> Ids { get; set; } = new HashSet<int>();
        
        /// <summary>
        /// Exclude these ids (useful for blacklisting)
        /// </summary>
        public HashSet<int> ExcludeIds { get; set; } = new HashSet<int>();
        
        /// <summary>
        /// Restrict by flag
        /// <see cref="DatabaseManager.Enums.Operator"/>
        /// </summary>
        public NpcFlag NpcFlags { get; set; } = new NpcFlag();
    }
}









