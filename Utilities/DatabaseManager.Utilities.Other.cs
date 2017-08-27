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
using System.Linq;
using DatabaseManager.Enums;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;


namespace DatabaseManager.Utilities
{
    /// <summary>
    /// 
    /// </summary>
    public class Other
    {
        /// <summary>
        /// Converts a bitmask value to IEnumerable&lt;T&gt;
        /// </summary>
        /// <typeparam name="T">Destination enum</typeparam>
        /// <param name="bitmask">Value to convert</param>
        public static IEnumerable<T> BitmaskToEnum<T>(int bitmask)
        {
            return from object cur in Enum.GetValues(typeof(T)) let number = (int)(object)(T)cur where 0 != (number & bitmask) select (T)cur;
        }

        /// <summary>
        /// Converts List&lt;T&gt; to a bitmask value
        /// </summary>
        /// <typeparam name="T">Source enum type</typeparam>
        /// <param name="enumList">Source enum flags</param>
        public static int EnumToBitmask<T>(List<T> enumList)
        {
            return enumList.Cast<int>().Sum();
        }

        public static HashSet<uint> GetFactionsByReaction(WoWFactionTemplate faction, ReactionType reaction)
        {
            var f = new HashSet<uint>();
            if (faction.Record.FactionId == 0)
                return f;
            switch (reaction)
            {
                case ReactionType.Neutral:
                    for (uint i = 1; i < 2400; i++)
                    {
                        var c = WoWFactionTemplate.FromId(i);
                        if (c != null && c.Record.FactionId != 0
                            && c.GetReactionTowards(faction) == Reaction.Neutral)
                        {
                            f.Add(c.Id);
                        }
                    }
                    break;
                case ReactionType.Friendly:
                    for (uint i = 1; i < 2400; i++)
                    {
                        var c = WoWFactionTemplate.FromId(i);
                        if (c != null && c.Record.FactionId != 0
                            && c.GetReactionTowards(faction) >= Reaction.Neutral)
                        {
                            f.Add(c.Id);
                        }
                    }
                    break;
                case ReactionType.Hostile:
                    for (uint i = 1; i < 2400; i++)
                    {
                        var c = WoWFactionTemplate.FromId(i);
                        if (c != null && c.Record.FactionId != 0
                            && c.GetReactionTowards(faction) <= Reaction.Neutral)
                        {
                            f.Add(c.Id);
                        }
                    }
                    break;
                case ReactionType.None:
                    return f;
                default:
                    return f;
            }
            return f;
        }

        public static double BytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        public static double KilobytesToMegabytes(long kilobytes)
        {
            return kilobytes / 1024f;
        }
    }
}









