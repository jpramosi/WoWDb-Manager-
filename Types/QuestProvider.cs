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


namespace DatabaseManager.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class QuestProvider
    {
        /// <summary>
        /// Limit search range
        /// </summary>
        public Table SearchOn { get; set; } = Table.All;
        
        /// <summary>
        /// Determines which type of quest to receive
        /// </summary>
        public QuestMark Type { get; set; } = QuestMark.All;

        /// <summary>
        /// Ids to search
        /// </summary>
        public HashSet<int> Ids { get; set; } = new HashSet<int>();

        /// <summary>
        /// 
        /// </summary>
        public QuestProvider()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchOn">Limit search range</param>
        /// <param name="ids">Ids to search</param>
        public QuestProvider(Table searchOn, QuestMark type, HashSet<int> ids)
        {
            this.SearchOn = searchOn;
            this.Type = type;
            this.Ids = ids;
        }
    }
}









