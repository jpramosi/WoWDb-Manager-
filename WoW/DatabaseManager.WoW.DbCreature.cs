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
using wManager.Wow.Helpers;
using Math = System.Math;


namespace DatabaseManager.WoW
{
    /// <summary>
    /// DbCreature
    /// </summary>
    /// <para>Class to retrieve informations from database</para>
    public class DbCreature 
    {
        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static List<creature> Get(CreatureFilter filter)
        {
            using (var db = Access.Linq())
            {
                if (filter == null)
                    return new List<creature>();
                int m = Utilities.Other.EnumToBitmask(filter.NpcFlags.Flags ?? new List<UnitNPCFlags>());
                var creature = from c in db.creature
                               select c;
                var creature_template = from ct in db.creature_template
                                        select new creature_template
                                        {
                                            entry = ct.entry,
                                            name = ct.name,
                                            minlevel = ct.minlevel,
                                            maxlevel = ct.maxlevel,
                                            mingold = ct.mingold,
                                            maxgold = ct.maxgold,
                                            rank = ct.rank,
                                            faction = ct.faction,
                                            npcflag = ct.npcflag,
                                            lootid = ct.lootid,
                                            trainer_class = ct.trainer_class,
                                            subname = ct.subname,
                                        };
                var creature_loot_template = from clt in db.creature_loot_template
                                             select new creature_loot_template
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
                var npc_vendor = from nv in db.npc_vendor
                    select new npc_vendor
                    {
                        entry = nv.entry,
                        item = nv.item
                    };
                if (filter.ContinentId != ContinentId.None)
                {
                    creature = creature.Where(c => c.map == (int) filter.ContinentId);
                }
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var s = filter.Name.ToLower();
                    creature_template = creature_template.Where(ct => ct.name.ToLower().Contains(s));
                }
                if (filter.Ids != null && filter.Ids.Any())
                {
                    creature = creature.Where(c => filter.Ids.Contains(c.id));
                }
                if (filter.ExcludeIds != null && filter.ExcludeIds.Any())
                {
                    creature = creature.Where(c => !filter.ExcludeIds.Contains(c.id));
                }
                if (filter.Range.Distance != int.MaxValue && filter.Range.From != null)
                {
                    creature = creature.Where(c => Math.Sqrt(Math.Pow(filter.Range.From.X - c.position_x, 2f) +
                                                             Math.Pow(filter.Range.From.Y - c.position_y, 2f) +
                                                             Math.Pow(filter.Range.From.Z - c.position_z, 2f)) <= filter.Range.Distance);
                }
                if (filter.HasItems.Ids.Any())
                {
                    if (filter.HasItems.Contains == ContainedIn.Loot)
                    {
                        creature_template =
                        (from ct in creature_template
                            join clt in creature_loot_template.Where(i => filter.HasItems.Ids.Contains(i.Item)) on ct.lootid
                            equals clt.Entry
                            select ct).Union(from ct in creature_template
                            join clt in creature_loot_template.Where(i => i.Item == i.Reference) on ct.lootid equals clt
                                .Entry
                            join rlt in reference_loot_template.Where(i => filter.HasItems.Ids.Contains(i.Item)) on clt
                                .Reference equals rlt.Entry
                            select ct);
                    }
                    else if (filter.HasItems.Contains == ContainedIn.Merchant)
                    {
                        creature_template =
                            from ct in creature_template
                            join nv in npc_vendor.Where(i => filter.HasItems.Ids.Contains(i.item)) on ct.entry equals nv.entry
                            select ct;
                    }
                }
                if (filter.Trainer != Train.All)
                {
                    var s = (int) filter.Trainer;
                    if (s < 20)
                    {
                        creature_template =
                            from ct in creature_template
                            where ct.trainer_class == s
                            select ct;
                    }
                    else if (s > 20)
                    {
                        var t = filter.Trainer.ToString().Replace("Primary_", "").Replace("Secondary_", "") + " T";
                        creature_template =
                            from ct in creature_template
                            where ct.subname.Contains(t)
                            select ct;
                    }
                }
                if (filter.Faction.Id != 0 && filter.Faction.Reaction != ReactionType.None)
                {
                    var f = Utilities.Other.GetFactionsByReaction(WoWFactionTemplate.FromId(filter.Faction.Id), filter.Faction.Reaction);
                    creature_template =
                        from ct in creature_template
                        where f.Contains(ct.faction)
                        select ct;
                }
                creature = 
                    from c in creature
                    join ct in creature_template on c.id equals ct.entry
                    where ct.minlevel >= filter.MinLevel
                          && ct.maxlevel <= filter.MaxLevel
                          && 
                          (
                              filter.NpcFlags.Mode == Operator.And && (ct.npcflag & m) == m
                              ||
                              filter.NpcFlags.Mode == Operator.Or && (ct.npcflag & m) != 0
                              ||
                              filter.NpcFlags.Mode == Operator.Equal && ct.npcflag == m
                          )
                    select new creature
                    {
                        id = c.id,
                        map = c.map,
                        zoneId = c.zoneId,
                        areaId = c.areaId,
                        modelid = c.modelid,
                        position_x = c.position_x,
                        position_y = c.position_y,
                        position_z = c.position_z,
                        orientation = c.orientation,
                        spawntimesecs = c.spawntimesecs,
                        spawndist = c.spawndist,
                        currentwaypoint = c.currentwaypoint,
                        curhealth = c.curhealth,
                        curmana = c.curmana,
                        MovementType = c.MovementType,
                        npcflag = c.npcflag,
                        unit_flags = c.unit_flags,
                        Name = ct.name,
                        MinLevel = ct.minlevel,
                        MaxLevel = ct.maxlevel,
                        MinGold = ct.mingold,
                        MaxGold = ct.maxgold,
                        Position = new Vector3(c.position_x, c.position_y, c.position_z, "DbCreature"),
                        Rank = (UnitClassification) ct.rank,
                        Faction = WoWFactionTemplate.FromId(ct.faction),
                        NpcFlags = ct.npcflag,
                    };
                //Logging.Write("query: \n"+ creature);
                creature = creature.OrderBy(c =>
                    Math.Sqrt(Math.Pow(filter.Range.From.X - c.position_x, 2f) +
                              Math.Pow(filter.Range.From.Y - c.position_y, 2f) +
                              Math.Pow(filter.Range.From.Z - c.position_z, 2f))
                );
                return creature.ToList();
            }
        }

        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static creature GetNearest(CreatureFilter filter, Vector3 from, int maxDistance = int.MaxValue)
        {
            using (var db = Access.Linq())
            {
                if (filter == null)
                    return new creature();
                int m = Utilities.Other.EnumToBitmask(filter.NpcFlags.Flags ?? new List<UnitNPCFlags>());
                var creature = from c in db.creature
                    select c;
                var creature_template = from ct in db.creature_template
                    select new creature_template
                    {
                        entry = ct.entry,
                        name = ct.name,
                        minlevel = ct.minlevel,
                        maxlevel = ct.maxlevel,
                        mingold = ct.mingold,
                        maxgold = ct.maxgold,
                        rank = ct.rank,
                        faction = ct.faction,
                        npcflag = ct.npcflag,
                        lootid = ct.lootid,
                        trainer_class = ct.trainer_class,
                        subname = ct.subname,
                    };
                var creature_loot_template = from clt in db.creature_loot_template
                    select new creature_loot_template
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
                var npc_vendor = from nv in db.npc_vendor
                    select new npc_vendor
                    {
                        entry = nv.entry,
                        item = nv.item
                    };
                if (filter.ContinentId != ContinentId.None)
                {
                    creature = creature.Where(c => c.map == (int) filter.ContinentId);
                }
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var s = filter.Name.ToLower();
                    creature_template = creature_template.Where(ct => ct.name.ToLower().Contains(s));
                }
                if (filter.Ids != null && filter.Ids.Any())
                {
                    creature = creature.Where(c => filter.Ids.Contains(c.id));
                }
                if (filter.ExcludeIds != null && filter.ExcludeIds.Any())
                {
                    creature = creature.Where(c => !filter.ExcludeIds.Contains(c.id));
                }
                if (from != Vector3.Empty)
                {
                    creature = creature.Where(c => Math.Sqrt(Math.Pow(from.X - c.position_x, 2f) +
                                                             Math.Pow(from.Y - c.position_y, 2f) +
                                                             Math.Pow(from.Z - c.position_z, 2f)) <= maxDistance);
                }
                if (filter.HasItems.Ids.Any())
                {
                    if (filter.HasItems.Contains == ContainedIn.Loot)
                    {
                        creature_template =
                        (from ct in creature_template
                            join clt in creature_loot_template.Where(i => filter.HasItems.Ids.Contains(i.Item)) on ct.lootid
                            equals clt.Entry
                            select ct).Union(from ct in creature_template
                            join clt in creature_loot_template.Where(i => i.Item == i.Reference) on ct.lootid equals clt
                                .Entry
                            join rlt in reference_loot_template.Where(i => filter.HasItems.Ids.Contains(i.Item)) on clt
                                .Reference equals rlt.Entry
                            select ct);
                    }
                    else if (filter.HasItems.Contains == ContainedIn.Merchant)
                    {
                        creature_template =
                            from ct in creature_template
                            join nv in npc_vendor.Where(i => filter.HasItems.Ids.Contains(i.item)) on ct.entry equals nv.entry
                            select ct;
                    }
                }
                if (filter.Trainer != Train.All)
                {
                    var s = (int) filter.Trainer;
                    if (s < 20)
                    {
                        creature_template =
                            from ct in creature_template
                            where ct.trainer_class == s
                            select ct;
                    }
                    else if (s > 20)
                    {
                        var t = filter.Trainer.ToString().Replace("Primary_", "").Replace("Secondary_", "") + " T";
                        creature_template =
                            from ct in creature_template
                            where ct.subname.Contains(t)
                            select ct;
                    }
                }
                if (filter.Faction.Id != 0 && filter.Faction.Reaction != ReactionType.None)
                {
                    var f = Utilities.Other.GetFactionsByReaction(WoWFactionTemplate.FromId(filter.Faction.Id), filter.Faction.Reaction);

                    creature_template =
                        from ct in creature_template
                        where f.Contains(ct.faction)
                        select ct;
                }
                creature = 
                    from c in creature
                    join ct in creature_template on c.id equals ct.entry
                    where ct.minlevel >= filter.MinLevel
                          && ct.maxlevel <= filter.MaxLevel
                          && ((ct.npcflag & m) == m && filter.NpcFlags.Mode == Operator.And ||
                              (ct.npcflag & m) != 0 && filter.NpcFlags.Mode == Operator.Or)
                    select new creature
                    {
                        id = c.id,
                        map = c.map,
                        zoneId = c.zoneId,
                        areaId = c.areaId,
                        modelid = c.modelid,
                        position_x = c.position_x,
                        position_y = c.position_y,
                        position_z = c.position_z,
                        orientation = c.orientation,
                        spawntimesecs = c.spawntimesecs,
                        spawndist = c.spawndist,
                        currentwaypoint = c.currentwaypoint,
                        curhealth = c.curhealth,
                        curmana = c.curmana,
                        MovementType = c.MovementType,
                        npcflag = c.npcflag,
                        unit_flags = c.unit_flags,
                        Name = ct.name,
                        MinLevel = ct.minlevel,
                        MaxLevel = ct.maxlevel,
                        MinGold = ct.mingold,
                        MaxGold = ct.maxgold,
                        Position = new Vector3(c.position_x, c.position_y, c.position_z, "DbCreature"),
                        Rank = (UnitClassification) ct.rank,
                        Faction = WoWFactionTemplate.FromId(ct.faction),
                        NpcFlags = ct.npcflag,
                    };
                //Logging.Write("query: \n"+ creature);
                creature = creature.OrderBy(c =>
                    Math.Sqrt(Math.Pow(from.X - c.position_x, 2f) +
                              Math.Pow(from.Y - c.position_y, 2f) +
                              Math.Pow(from.Z - c.position_z, 2f))
                );
                return creature.FirstOrDefault();
            }
        }
    }
}






