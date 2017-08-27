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
using robotManager.Helpful;


namespace DatabaseManager.Types
{
    /// <summary>
    /// 
    /// </summary>
    public class Range
    {
        /// <summary>
        /// Position to measure from
        /// </summary>
        public Vector3 From { get; set; } = Vector3.Empty;

        /// <summary>
        /// Maximum allowed distance
        /// </summary>
        public int Distance { get; set; }

        /// <summary>
        ///
        /// </summary>
        public Range()
        {
            this.From = Vector3.Empty;
            this.Distance = int.MaxValue;
        }
        
        /// <param name="from">Position to measure from</param>
        /// <param name="distance">Maximum allowed distance</param>
        public Range(Vector3 from, int distance = int.MaxValue)
        {
            this.From = from;
            this.Distance = distance;
        }
    }
}









