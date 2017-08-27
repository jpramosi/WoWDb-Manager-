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


namespace DatabaseManager.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class RaceFlag
    {
        /// <summary>
        /// <see cref="DatabaseManager.Enums.Operator"/>
        /// </summary>
        public Operator Mode { get; set; } = Operator.And;
        
        /// <summary>
        /// 
        /// </summary>
        public List<RaceFlags> Flags { get; set; } = new List<RaceFlags>();

        /// <summary>
        /// 
        /// </summary>
        public RaceFlag()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"><see cref="DatabaseManager.Enums.Operator"/></param>
        /// <param name="flags"></param>
        public RaceFlag(Operator mode, List<RaceFlags> flags)
        {
            this.Mode = mode;
            this.Flags = flags;
        }
    }
}









