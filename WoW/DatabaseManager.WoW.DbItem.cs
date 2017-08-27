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


namespace DatabaseManager.WoW
{
    /// <summary>
    /// DbItem
    /// </summary>
    /// <para>Class to retrieve informations from database</para>
    public class DbItem
    {
        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static List<item_template> Get(ItemFilter filter)
        {
            using (var db = Access.Linq())
            {
                if (filter == null)
                    return new List<item_template>();
                var item_template = from it in db.item_template
                    select it;
                var item_loot_template = from clt in db.item_loot_template
                    select new item_loot_template
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
                if (filter.Ids.Any())
                {
                    item_template = item_template.Where(it => filter.Ids.Contains(it.entry));
                }
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var n = filter.Name.ToLower();
                    item_template = item_template.Where(it => it.name.ToLower().Contains(n));
                }
                if (filter.Type.Id != -1 && filter.Type.Type != -1)
                {
                    item_template = filter.Type.Id == -1 ? item_template.Where(it => it.class_ == filter.Type.Type) : item_template.Where(it => it.class_ == filter.Type.Type && it.subclass == filter.Type.Id);
                }
                if (filter.Quality != ItemQuality.All)
                {
                    var q = (int) filter.Quality;
                    item_template = item_template.Where(it => it.Quality == q);
                }
                if (filter.MinILevel != 0)
                {
                    item_template = item_template.Where(it => it.ItemLevel >= filter.MinILevel);
                }
                if (filter.MaxILevel != int.MaxValue)
                {
                    item_template = item_template.Where(it => it.ItemLevel <= filter.MaxILevel);
                }
                if (filter.MinLevelRequired != 0)
                {
                    item_template = item_template.Where(it => it.RequiredLevel >= filter.MinLevelRequired);
                }
                if (filter.MaxLevelRequired != int.MaxValue)
                {
                    item_template = item_template.Where(it => it.RequiredLevel <= filter.MaxLevelRequired);
                }
                if (filter.MaxBuyPrice != int.MaxValue)
                {
                    item_template = item_template.Where(it => it.BuyPrice <= filter.MaxBuyPrice);
                }
                if (filter.HasSpells.Any())
                {
                    item_template = item_template.Where(it => filter.HasSpells.Contains(it.spellid_1));
                }
                if (filter.HasItems.Any())
                {
                    item_template =
                        (from it in item_template
                            join ilt in item_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on it.entry equals ilt.Entry
                            select it)
                        .Union(from it in item_template
                            join ilt in item_loot_template.Where(i => i.Item == i.Reference) on it.entry equals ilt.Entry
                            join rlt in reference_loot_template.Where(i => filter.HasItems.Contains(i.Item)) on ilt.Reference equals rlt.Entry
                            select it);
                }
                if (filter.ExcludeIds.Any())
                {
                    item_template = item_template.Where(g => !filter.ExcludeIds.Contains(g.entry));
                }
                item_template =
                    from it in item_template
                    select it;
                return item_template.ToList();
            }
        }
        
        /// <summary>
        /// Return items contained by other wow-objects
        /// </summary>
        /// <param name="wowOjbectEntry">The entry to search</param>
        /// <param name="from">Determines the origin table of the id</param>
        /// <param name="containedIn">Determines the selection of the items from loot or merchant table(only affects creature table)</param>
        public static List<int> GetItemsById(int wowOjbectEntry, Table from, ContainedIn containedIn)
        {
            using (var db = Access.Linq())
            {
                if (wowOjbectEntry == 0)
                    return new List<int>();
                var reference_loot_template = from rlt in db.reference_loot_template
                    select new reference_loot_template
                    {
                        Entry = rlt.Entry,
                        Item = rlt.Item,
                        Reference = rlt.Reference,
                    };
                if (from == Table.Creature)
                {
                    if (containedIn == ContainedIn.Loot)
                    {
                        var creature_loot_template = from clt in db.creature_loot_template
                            select new creature_loot_template
                            {
                                Entry = clt.Entry,
                                Item = clt.Item,
                                Reference = clt.Reference,
                            };
                        creature_loot_template =
                            (from clt in creature_loot_template
                                where clt.Entry == wowOjbectEntry && clt.Item != clt.Reference
                                select new creature_loot_template
                                {
                                    Entry = clt.Entry,
                                    Item = clt.Item,
                                })
                            .Union(
                                from clt in creature_loot_template
                                where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                                join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                                where rlt.Reference == 0

                                select new creature_loot_template
                                {
                                    Item = rlt.Item,
                                }
                            )
                            .Union(
                                from clt in creature_loot_template
                                where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                                join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                                where rlt.Reference != 0
                                join rlt_ in reference_loot_template on rlt.Reference equals rlt_.Entry
                                select new creature_loot_template
                                {
                                    Item = rlt_.Item,
                                }
                            );
                        return creature_loot_template.Select(i => i.Item).ToList();
                    }
                    if (containedIn == ContainedIn.Merchant)
                    {
                        var npc_vendor = from nv in db.npc_vendor
                            where wowOjbectEntry == nv.entry
                            select new npc_vendor
                            {
                                entry = nv.entry,
                                item = nv.item
                            };
                        return npc_vendor.Select(i => i.item).ToList();
                    }
                }
                if (from == Table.GameOjbect)
                {
                    var gameobject_loot_template = from clt in db.gameobject_loot_template
                        select new gameobject_loot_template
                        {
                            Entry = clt.Entry,
                            Item = clt.Item,
                            Reference = clt.Reference,
                        };
                    gameobject_loot_template =
                        (from clt in gameobject_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item != clt.Reference
                            select new gameobject_loot_template
                            {
                                Entry = clt.Entry,
                                Item = clt.Item,
                            })
                        .Union(
                            from clt in gameobject_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                            join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                            where rlt.Reference == 0

                            select new gameobject_loot_template
                            {
                                Item = rlt.Item,
                            }
                        )
                        .Union(
                            from clt in gameobject_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                            join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                            where rlt.Reference != 0
                            join rlt_ in reference_loot_template on rlt.Reference equals rlt_.Entry
                            select new gameobject_loot_template
                            {
                                Item = rlt_.Item,
                            }
                        );
                    return gameobject_loot_template.Select(i => i.Item).ToList();
                }
                if (from == Table.Item)
                {
                    var item_loot_template = from clt in db.item_loot_template
                        select new item_loot_template
                        {
                            Entry = clt.Entry,
                            Item = clt.Item,
                            Reference = clt.Reference,
                        };
                    item_loot_template =
                        (from clt in item_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item != clt.Reference
                            select new item_loot_template
                            {
                                Entry = clt.Entry,
                                Item = clt.Item,
                            })
                        .Union(
                            from clt in item_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                            join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                            where rlt.Reference == 0

                            select new item_loot_template
                            {
                                Item = rlt.Item,
                            }
                        )
                        .Union(
                            from clt in item_loot_template
                            where clt.Entry == wowOjbectEntry && clt.Item == clt.Reference
                            join rlt in reference_loot_template on clt.Reference equals rlt.Entry
                            where rlt.Reference != 0
                            join rlt_ in reference_loot_template on rlt.Reference equals rlt_.Entry
                            select new item_loot_template
                            {
                                Item = rlt_.Item,
                            }
                        );
                    return item_loot_template.Select(i => i.Item).ToList();
                }
                return new List<int>();
            }
        }
    }
}







