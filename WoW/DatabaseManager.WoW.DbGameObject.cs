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
using DatabaseManager.Filter;
using DatabaseManager.Tables;
using robotManager.Helpful;
using wManager.Wow.Enums;
using Math = System.Math;


namespace DatabaseManager.WoW
{
    /// <summary>
    /// DbGameObject
    /// </summary>
    /// <para>Class to retrieve informations from database</para>
    public class DbGameObject
    {
        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static List<gameobject> Get(GameObjectFilter filter)
        {
            using (var db = Access.Linq())
            {
                if (filter == null)
                    return new List<gameobject>();
                var t = (int)filter.Type;
                var gameobject = from g in db.gameobject
                    select g;
                var gameobject_template = from gt in db.gameobject_template
                    select new gameobject_template
                    {
                        entry = gt.entry,
                        Data1 = gt.Data1,
                        name = gt.name,
                        type = gt.type,
                        displayId = gt.displayId,
                        size = gt.size
                    };
                var gameobject_loot_template = from clt in db.gameobject_loot_template
                    select new gameobject_loot_template
                    {
                        Entry = clt.Entry,
                        Item = clt.Item,
                        Reference = clt.Reference,
                        Chance = clt.Chance,
                        MaxCount = clt.MaxCount,
                    };
                var reference_loot_template = from rlt in db.reference_loot_template
                    select new reference_loot_template
                    {
                        Entry = rlt.Entry,
                        Item = rlt.Item,
                        Reference = rlt.Reference,
                    };
                if (filter.ContinentId != ContinentId.None)
                {
                    gameobject = gameobject.Where(g => g.map == (int) filter.ContinentId);
                }
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var s = filter.Name.ToLower();
                    gameobject_template = gameobject_template.Where(gt => gt.name.ToLower().Contains(s));
                }
                if (filter.Type != GameObjectType.None)
                {
                    gameobject_template = gameobject_template.Where(gt => gt.type == t);
                }
                if (filter.Ids != null && filter.Ids.Any())
                {
                    gameobject = gameobject.Where(g => filter.Ids.Contains(g.id));
                }
                if (filter.ExcludeIds != null && filter.ExcludeIds.Any())
                {
                    gameobject = gameobject.Where(g => !filter.ExcludeIds.Contains(g.id));
                }
                if (filter.Range.Distance != int.MaxValue && filter.Range.From != null)
                {
                    gameobject = gameobject.Where(g => Math.Sqrt(Math.Pow(filter.Range.From.X - g.position_x, 2f) +
                                                                 Math.Pow(filter.Range.From.Y - g.position_y, 2f) +
                                                                 Math.Pow(filter.Range.From.Z - g.position_z, 2f)) <= filter.Range.Distance);
                }
                if (filter.HasItems.Any())
                {
                    gameobject_template =
                    (from gt in gameobject_template
                        join glt in gameobject_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on gt.Data1 equals glt.Entry
                        select gt)
                        .Union(from ct in gameobject_template
                        join glt in gameobject_loot_template.Where(i => i.Item == i.Reference) on ct.Data1 equals glt.Entry
                        join rlt in reference_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on glt.Reference equals rlt.Entry
                        select ct);
                }
                gameobject = 
                    from g in gameobject
                    join gt in gameobject_template on g.id equals gt.entry
                    select new gameobject
                    {
                        id = g.id,
                        map = g.map,
                        zoneId = g.zoneId,
                        areaId = g.areaId,
                        position_x = g.position_x,
                        position_y = g.position_y,
                        position_z = g.position_z,
                        spawntimesecs = g.spawntimesecs,
                        state = g.state,
                        Name = gt.name,
                        Type = (GameObjectType)gt.type,
                        DisplayId = gt.displayId,
                        Size = gt.size,
                        Position = new Vector3(g.position_x, g.position_y, g.position_z, "DbGameObject"),
                    };
                gameobject = gameobject.OrderBy(c =>
                    Math.Sqrt(Math.Pow(filter.Range.From.X - c.position_x, 2f) +
                              Math.Pow(filter.Range.From.Y - c.position_y, 2f) +
                              Math.Pow(filter.Range.From.Z - c.position_z, 2f))
                );
                return gameobject.ToList();
            }
        }

        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static gameobject GetNearest(GameObjectFilter filter)
        {
            using (var db = Access.Linq())
            {
                if (filter == null)
                    return new gameobject();
                var t = (int)filter.Type;
                var gameobject = from g in db.gameobject
                    select g;
                var gameobject_template = from gt in db.gameobject_template
                    select new gameobject_template
                    {
                        entry = gt.entry,
                        Data1 = gt.Data1,
                        name = gt.name,
                        type = gt.type,
                        displayId = gt.displayId,
                        size = gt.size
                    };
                var gameobject_loot_template = from clt in db.gameobject_loot_template
                    select new gameobject_loot_template
                    {
                        Entry = clt.Entry,
                        Item = clt.Item,
                        Reference = clt.Reference,
                        Chance = clt.Chance,
                        MaxCount = clt.MaxCount,
                    };
                var reference_loot_template = from rlt in db.reference_loot_template
                    select new reference_loot_template
                    {
                        Entry = rlt.Entry,
                        Item = rlt.Item,
                        Reference = rlt.Reference,
                    };
                if (filter.ContinentId != ContinentId.None)
                {
                    gameobject = gameobject.Where(g => g.map == (int) filter.ContinentId);
                }
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var s = filter.Name.ToLower();
                    gameobject_template = gameobject_template.Where(gt => gt.name.ToLower().Contains(s));
                }
                if (filter.Type != GameObjectType.None)
                {
                    gameobject_template = gameobject_template.Where(gt => gt.type == t);
                }
                if (filter.Ids != null && filter.Ids.Any())
                {
                    gameobject = gameobject.Where(g => filter.Ids.Contains(g.id));
                }
                if (filter.ExcludeIds != null && filter.ExcludeIds.Any())
                {
                    gameobject = gameobject.Where(g => !filter.ExcludeIds.Contains(g.id));
                }
                if (filter.Range.Distance != int.MaxValue && filter.Range.From != null)
                {
                    gameobject = gameobject.Where(g => Math.Sqrt(Math.Pow(filter.Range.From.X - g.position_x, 2f) +
                                                                 Math.Pow(filter.Range.From.Y - g.position_y, 2f) +
                                                                 Math.Pow(filter.Range.From.Z - g.position_z, 2f)) <= filter.Range.Distance);
                }
                if (filter.HasItems.Any())
                {
                    gameobject_template =
                        (from gt in gameobject_template
                            join glt in gameobject_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on gt.Data1 equals glt.Entry
                            select gt)
                        .Union(from ct in gameobject_template
                            join glt in gameobject_loot_template.Where(i => i.Item == i.Reference) on ct.Data1 equals glt.Entry
                            join rlt in reference_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on glt.Reference equals rlt.Entry
                            select ct);
                }
                gameobject = 
                    from g in gameobject
                    join gt in gameobject_template on g.id equals gt.entry
                    select new gameobject
                    {
                        id = g.id,
                        map = g.map,
                        zoneId = g.zoneId,
                        areaId = g.areaId,
                        position_x = g.position_x,
                        position_y = g.position_y,
                        position_z = g.position_z,
                        spawntimesecs = g.spawntimesecs,
                        state = g.state,
                        Name = gt.name,
                        Type = (GameObjectType)gt.type,
                        DisplayId = gt.displayId,
                        Size = gt.size,
                        Position = new Vector3(g.position_x, g.position_y, g.position_z, "DbGameObject"),
                    };
                gameobject = gameobject.OrderBy(c =>
                    Math.Sqrt(Math.Pow(filter.Range.From.X - c.position_x, 2f) +
                              Math.Pow(filter.Range.From.Y - c.position_y, 2f) +
                              Math.Pow(filter.Range.From.Z - c.position_z, 2f))
                );
                return gameobject.FirstOrDefault();
            }
        }
    }
}








