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
    /// <para />Used for filtering quests
    /// <remarks>
    /// <para>[Caution] Poor filtering can result in high memory usage &amp; access delay</para>
    /// </remarks>
    /// </summary>
    public class QuestFilter
    {
        /// <summary>
        /// Restrict by name
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Restrict by quest id
        /// </summary>
        public HashSet<int> QuestIds { get; set; } = new HashSet<int>();

        /// <summary>
        /// Exclude these ids (useful for blacklisting)
        /// </summary>
        public HashSet<int> ExcludeIds { get; set; } = new HashSet<int>();
        
        /// <summary>
        /// Restrict by id of creature, gameobject or item
        /// </summary>
        public QuestProvider QuestFrom { get; set; } = new QuestProvider();
        
        /// <summary>
        /// Restrict by quest flag
        /// </summary>
        public QuestFlag QuestFlags { get; set; } = new QuestFlag(Operator.And, new List<QuestFlags>());

        /// <summary>
        /// Restrict by race
        /// <see cref="DatabaseManager.Enums.Operator"/>
        /// </summary>
        public RaceFlag RaceFlags { get; set; } = new RaceFlag(Operator.And, new List<RaceFlags>());

        /// <summary>
        /// Restrict by previous quest id
        /// </summary>
        public int PreviousQuestId { get; set; } = 0;

        /// <summary>
        /// Restrict by next quest id
        /// </summary>
        public int NextQuestId { get; set; } = 0;

        /// <summary>
        /// Restrict by level at which a player can get the quest.
        /// <para>Values over "AcceptLevel" will not be taken</para>
        /// </summary>
        public int AcceptLevel { get; set; } = int.MaxValue;

        /// <summary>
        /// Restrict by minimum quest level
        /// </summary>
        public int MinimumQuestLevel { get; set; } = 0;

        /// <summary>
        /// Restrict by maximum quest level
        /// </summary>
        public int MaximumQuestLevel { get; set; } = int.MaxValue;
        
        /// <summary>
        /// Restrict by type
        /// </summary>
        public QuestInfo Type { get; set; } = QuestInfo.All;
        
        /// <summary>
        /// Restrict by quest's state
        /// </summary>
        public QuestState State { get; set; } = QuestState.All;
        
        /// <summary>
        /// Returns additional data by type on quest_template
        /// </summary>
        public List<QuestData> ReturnData { get; set; } = new List<QuestData>();
    }
}









