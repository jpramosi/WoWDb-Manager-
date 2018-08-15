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


namespace DatabaseManager.Types
{
    /// <summary>
    /// A type to union defined fields in this class
    /// </summary>
    public struct Data_quest_template_addon
    {
        /// <summary>
        /// 
        /// </summary>
        public int AllowableClasses;

        /// <summary>
        /// 
        /// </summary>
        public int PreviousQuestId;

        /// <summary>
        /// 
        /// </summary>
        public int NextQuestId;
        
        /// <summary>
        /// A type to union defined fields in this class
        /// </summary>
        /// <param name="allowableClasses"></param>
        /// <param name="previousQuestId"></param>
        /// <param name="nextQuestId"></param>
        public Data_quest_template_addon(int allowableClasses, int previousQuestId, int nextQuestId)
        {
            AllowableClasses = allowableClasses;
            PreviousQuestId = previousQuestId;
            NextQuestId = nextQuestId;
        }
    }
}









