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
    public struct Data_areatrigger
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id;

        /// <summary>
        /// 
        /// </summary>
        public int ContinentId;

        /// <summary>
        /// 
        /// </summary>
        public float X;

        /// <summary>
        /// 
        /// </summary>
        public float Y;

        /// <summary>
        /// 
        /// </summary>
        public float Z;

        /// <summary>
        /// 
        /// </summary>
        public float Radius;

        /// <summary>
        /// 
        /// </summary>
        public float BoxLength;

        /// <summary>
        /// 
        /// </summary>
        public float BoxWidth;

        /// <summary>
        /// 
        /// </summary>
        public float BoxHeight;

        /// <summary>
        /// 
        /// </summary>
        public float BoxYaw;
        
        /// <summary>
        /// A type to union defined fields in this class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="continentId"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="radius"></param>
        /// <param name="boxLength"></param>
        /// <param name="boxWidth"></param>
        /// <param name="boxHeight"></param>
        /// <param name="boxYaw"></param>
        public Data_areatrigger(int id, int continentId, float x, float y, float z, float radius, float boxLength, float boxWidth, float boxHeight, float boxYaw)
        {
            Id = id;
            ContinentId = continentId;
            X = x;
            Y = y;
            Z = z;
            Radius = radius;
            BoxLength = boxLength;
            BoxWidth = boxWidth;
            BoxHeight = boxHeight;
            BoxYaw = boxYaw;
        }
    }
}









