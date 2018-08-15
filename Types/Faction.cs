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
using DatabaseManager.Enums;


namespace DatabaseManager.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Faction
    {
        /// <summary>
        /// The factionId to check from
        /// </summary>
        public uint Id { get; set; }
        
        /// <summary>
        /// The wanted reaction
        /// <para/>ReactionType.Neutral: includes only neutral creatures
        /// <para/>ReactionType.Hostile: includes neutral &amp; hostile creatures
        /// <para/>ReactionType.Friendly: includes neutral &amp; friendly creatures
        /// </summary>
        public ReactionType Reaction { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public Faction()
        {
            this.Id = 0;
            this.Reaction = ReactionType.None;
        }
        
        /// <summary>
        /// <para/>ReactionType.Neutral: includes only neutral creatures
        /// <para/>ReactionType.Hostile: includes neutral &amp; hostile creatures
        /// <para/>ReactionType.Friendly: includes neutral &amp; friendly creatures
        /// </summary>
        /// <param name="id">The factionId to check from</param>
        /// <param name="reaction">The wanted reaction</param>
        public Faction(uint id, ReactionType reaction = ReactionType.None)
        {
            this.Id = id;
            this.Reaction = reaction;
        }
    }
}









