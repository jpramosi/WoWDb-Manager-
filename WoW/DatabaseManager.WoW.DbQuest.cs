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
using DatabaseManager.Types;


namespace DatabaseManager.WoW
{
    /// <summary>
    /// DbQuest
    /// </summary>
    /// <para>Class to retrieve informations from database</para>
    public class DbQuest
    {
        /// <summary>
        /// Return data by filtering
        /// </summary>
        public static List<quest_template> Get(QuestFilter filter)
        {
            using (var db = Access.Linq())
            {
                IEnumerable<Data_quest_template_addon> data0 = new Data_quest_template_addon[0];
                IEnumerable<Data_areatrigger> data1 = new Data_areatrigger[0];
                var data2 = new PickUp();
                var data3 = new TurnIn();
                if (filter == null)
                    return new List<quest_template>();
                var quest_template =
                    from qt in db.quest_template
                    select qt;
                var areatrigger_involvedrelation =
                    from ai in db.areatrigger_involvedrelation
                    select ai;
                var areatrigger =
                    from at in db.areatrigger
                    select at;
                var quest_template_addon =
                    from qta in db.quest_template_addon
                    select new quest_template_addon
                    {
                        ID = qta.ID,
                        AllowableClasses = qta.AllowableClasses,
                        PrevQuestID = qta.PrevQuestID,
                        NextQuestID = qta.NextQuestID,
                    };

                var creature_queststarter = 
                    from cqs in db.creature_queststarter
                    select cqs;
                var creature_questender = 
                    from cqe in db.creature_questender
                    select cqe;
                var gameobject_queststarter = 
                    from gqs in db.gameobject_queststarter
                    select gqs;
                var gameobject_questender = 
                    from gqe in db.gameobject_questender
                    select gqe;
                var item_template = 
                    from it in db.item_template
                    select new item_template
                    {
                        entry = it.entry,
                        startquest = it.startquest,
                    };
                if (!string.IsNullOrWhiteSpace(filter.Name))
                {
                    var n = filter.Name.ToLower();
                    quest_template = quest_template.Where(qt => qt.LogTitle.ToLower().Contains(n));
                }
                if (filter.QuestIds.Any())
                {
                    quest_template = quest_template.Where(qt => filter.QuestIds.Contains(qt.ID));
                }
                if (filter.ExcludeIds.Any())
                {
                    quest_template = quest_template.Where(qt => !filter.ExcludeIds.Contains(qt.ID));
                }
                if (filter.QuestFlags.Flags.Any())
                {
                    int m = Utilities.Other.EnumToBitmask(filter.QuestFlags.Flags ?? new List<QuestFlags>());
                    quest_template = quest_template.Where(qt =>
                        filter.QuestFlags.Mode == Operator.And  && (qt.Flags & m) == m
                        || 
                        filter.QuestFlags.Mode == Operator.Or && (qt.Flags & m) != 0
                        ||
                        filter.QuestFlags.Mode == Operator.Equal && m == qt.Flags
                    );
                }
                if (filter.RaceFlags.Flags.Any())
                {
                    int r = Utilities.Other.EnumToBitmask(filter.RaceFlags.Flags ?? new List<RaceFlags>());
                    quest_template = quest_template.Where(qt =>
                        filter.RaceFlags.Mode == Operator.And && (qt.AllowableRaces & r) == r
                        ||
                        filter.RaceFlags.Mode == Operator.Or && (qt.AllowableRaces & r) != 0
                        || 
                        filter.RaceFlags.Mode == Operator.Equal && r == qt.AllowableRaces
                    );
                }
                if (filter.AcceptLevel != Int32.MaxValue)
                {
                    quest_template = quest_template.Where(qt => qt.MinLevel <= filter.AcceptLevel);
                }
                if (filter.MinimumQuestLevel != 0)
                {
                    quest_template = quest_template.Where(qt => qt.QuestLevel >= filter.MinimumQuestLevel);
                }
                if (filter.MaximumQuestLevel != int.MaxValue)
                {
                    quest_template = quest_template.Where(qt => qt.QuestLevel <= filter.MaximumQuestLevel);
                }
                if (filter.Type != QuestInfo.All)
                {
                    var id = (int)filter.Type;
                    quest_template = quest_template.Where(qt => qt.QuestInfoID == id);
                }
                if (filter.State != QuestState.All)
                {
                    var id = (int)filter.State;
                    quest_template = quest_template.Where(qt => qt.QuestType == id);
                }
                if (filter.ReturnData.Any())
                {
                    if (filter.ReturnData.Contains(QuestData.Data_quest_template_addon))
                    {
                        data0 = null;
                    }
                    if (filter.ReturnData.Contains(QuestData.Data_areatrigger))
                    {
                        data1 = null;
                    }
                    if (filter.ReturnData.Contains(QuestData.PickUp))
                    {
                        data2 = null;
                    }
                    if (filter.ReturnData.Contains(QuestData.TurnIn))
                    {
                        data3 = null;
                    }
                }
                if (filter.QuestFrom.Ids.Any())
                {
                    if (filter.QuestFrom.SearchOn == Table.All)
                    {
                        switch (filter.QuestFrom.Type)
                        {
                            case QuestMark.All:
                                quest_template =
                                    (from qt in quest_template
                                        join cqs in creature_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqs.quest
                                        select qt)
                                    .Union(
                                        from qt in quest_template
                                        join cqe in creature_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqe.quest
                                        select qt)
                                    .Union(
                                        from qt in quest_template
                                        join cqe in gameobject_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqe.quest
                                        select qt)
                                    .Union(
                                        from qt in quest_template
                                        join cqe in gameobject_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqe.quest
                                        select qt)
                                    .Union(
                                        from qt in quest_template
                                        join cqe in item_template.Where(i => filter.QuestFrom.Ids.Contains(i.entry)) on qt
                                            .ID equals cqe.startquest
                                        select qt);
                                break;
                            case QuestMark.PickUp:
                                quest_template =
                                (from qt in quest_template
                                    join cqs in creature_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqs.quest
                                    select qt)
                                .Union(
                                    from qt in quest_template
                                    join cqe in gameobject_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt)
                                .Union(
                                    from qt in quest_template
                                    join cqe in item_template.Where(i => filter.QuestFrom.Ids.Contains(i.entry)) on qt
                                        .ID equals cqe.startquest
                                    select qt);
                                break;
                            case QuestMark.TurnIn:
                                quest_template =
                                (from qt in quest_template
                                    join cqe in creature_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt)
                                .Union(
                                    from qt in quest_template
                                    join cqe in gameobject_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt);
                                break;
                        }
                    }
                    else if (filter.QuestFrom.SearchOn == Table.Creature)
                    {
                        switch (filter.QuestFrom.Type)
                        {
                            case QuestMark.All:
                                quest_template =
                                (from qt in quest_template
                                    join cqs in creature_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqs.quest
                                    select qt)
                                .Union(
                                    from qt in quest_template
                                    join cqe in creature_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt);
                                break;
                            case QuestMark.PickUp:
                                quest_template =
                                    from qt in quest_template
                                    join cqs in creature_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqs.quest
                                    select qt;
                                break;
                            case QuestMark.TurnIn:
                                quest_template =
                                    from qt in quest_template
                                    join cqe in creature_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt;
                                break;
                        }
                    }
                    if (filter.QuestFrom.SearchOn == Table.GameOjbect)
                    {
                        switch (filter.QuestFrom.Type)
                        {
                            case QuestMark.All:
                                quest_template =
                                    (from qt in quest_template
                                        join cqe in gameobject_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqe.quest
                                        select qt)
                                    .Union(
                                        from qt in quest_template
                                        join cqe in gameobject_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                            .ID equals cqe.quest
                                        select qt);
                                break;
                            case QuestMark.PickUp:
                                quest_template =
                                    from qt in quest_template
                                    join cqe in gameobject_queststarter.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt;
                                break;
                            case QuestMark.TurnIn:
                                quest_template =
                                    from qt in quest_template
                                    join cqe in gameobject_questender.Where(i => filter.QuestFrom.Ids.Contains(i.id)) on qt
                                        .ID equals cqe.quest
                                    select qt;
                                break;
                        }
                    }
                    if (filter.QuestFrom.SearchOn == Table.Item)
                    {
                            quest_template =
                                from qt in quest_template
                                join cqe in item_template.Where(i => filter.QuestFrom.Ids.Contains(i.entry)) on qt
                                    .ID equals cqe.startquest
                                select qt;
                    }
                }
                quest_template =
                    from qt in quest_template
                    select new quest_template
                    {
                        ID = qt.ID,
                        QuestType = qt.QuestType,
                        QuestLevel = qt.QuestLevel,
                        MinLevel = qt.MinLevel,
                        QuestInfoID = qt.QuestInfoID,
                        SuggestedGroupNum = qt.SuggestedGroupNum,
                        RewardNextQuest = qt.RewardNextQuest,
                        RewardXPDifficulty = qt.RewardXPDifficulty,
                        RewardMoney = qt.RewardMoney,
                        RewardBonusMoney = qt.RewardBonusMoney,
                        RewardSpell = qt.RewardSpell,
                        RewardHonor = qt.RewardHonor,
                        RewardKillHonor = qt.RewardKillHonor,
                        StartItem = qt.StartItem,
                        Flags = qt.Flags,
                        RequiredPlayerKills = qt.RequiredPlayerKills,
                        RewardItem1 = qt.RewardItem1,
                        RewardAmount1 = qt.RewardAmount1,
                        RewardItem2 = qt.RewardItem2,
                        RewardAmount2 = qt.RewardAmount2,
                        RewardItem3 = qt.RewardItem3,
                        RewardAmount3 = qt.RewardAmount3,
                        RewardItem4 = qt.RewardItem4,
                        RewardAmount4 = qt.RewardAmount4,
                        ItemDrop1 = qt.ItemDrop1,
                        ItemDropQuantity1 = qt.ItemDropQuantity1,
                        ItemDrop2 = qt.ItemDrop2,
                        ItemDropQuantity2 = qt.ItemDropQuantity2,
                        ItemDrop3 = qt.ItemDrop3,
                        ItemDropQuantity3 = qt.ItemDropQuantity3,
                        ItemDrop4 = qt.ItemDrop4,
                        ItemDropQuantity4 = qt.ItemDropQuantity4,
                        RewardChoiceItemID1 = qt.RewardChoiceItemID1,
                        RewardChoiceItemQuantity1 = qt.RewardChoiceItemQuantity1,
                        RewardChoiceItemID2 = qt.RewardChoiceItemID2,
                        RewardChoiceItemQuantity2 = qt.RewardChoiceItemQuantity2,
                        RewardChoiceItemID3 = qt.RewardChoiceItemID3,
                        RewardChoiceItemQuantity3 = qt.RewardChoiceItemQuantity3,
                        RewardChoiceItemID4 = qt.RewardChoiceItemID4,
                        RewardChoiceItemQuantity4 = qt.RewardChoiceItemQuantity4,
                        RewardChoiceItemID5 = qt.RewardChoiceItemID5,
                        RewardChoiceItemQuantity5 = qt.RewardChoiceItemQuantity5,
                        RewardChoiceItemID6 = qt.RewardChoiceItemID6,
                        RewardChoiceItemQuantity6 = qt.RewardChoiceItemQuantity6,
                        POIContinent = qt.POIContinent,
                        POIx = qt.POIx,
                        POIy = qt.POIy,
                        RewardTitle = qt.RewardTitle,
                        RewardTalents = qt.RewardTalents,
                        RewardFactionID1 = qt.RewardFactionID1,
                        RewardFactionValue1 = qt.RewardFactionValue1,
                        RewardFactionID2 = qt.RewardFactionID2,
                        RewardFactionValue2 = qt.RewardFactionValue2,
                        RewardFactionID3 = qt.RewardFactionID3,
                        RewardFactionValue3 = qt.RewardFactionValue3,
                        RewardFactionID4 = qt.RewardFactionID4,
                        RewardFactionValue4 = qt.RewardFactionValue4,
                        RewardFactionID5 = qt.RewardFactionID5,
                        RewardFactionValue5 = qt.RewardFactionValue5,
                        TimeAllowed = qt.TimeAllowed,
                        AllowableRaces = qt.AllowableRaces,
                        LogTitle = qt.LogTitle,
                        LogDescription = qt.LogDescription,
                        QuestDescription = qt.QuestDescription,
                        AreaDescription = qt.AreaDescription,
                        QuestCompletionLog = qt.QuestCompletionLog,
                        RequiredNpcOrGo1 = qt.RequiredNpcOrGo1,
                        RequiredNpcOrGo2 = qt.RequiredNpcOrGo2,
                        RequiredNpcOrGo3 = qt.RequiredNpcOrGo3,
                        RequiredNpcOrGo4 = qt.RequiredNpcOrGo4,
                        RequiredNpcOrGoCount1 = qt.RequiredNpcOrGoCount1,
                        RequiredNpcOrGoCount2 = qt.RequiredNpcOrGoCount2,
                        RequiredNpcOrGoCount3 = qt.RequiredNpcOrGoCount3,
                        RequiredNpcOrGoCount4 = qt.RequiredNpcOrGoCount4,
                        RequiredItemId1 = qt.RequiredItemId1,
                        RequiredItemId2 = qt.RequiredItemId2,
                        RequiredItemId3 = qt.RequiredItemId3,
                        RequiredItemId4 = qt.RequiredItemId4,
                        RequiredItemCount1 = qt.RequiredItemCount1,
                        RequiredItemCount2 = qt.RequiredItemCount2,
                        RequiredItemCount3 = qt.RequiredItemCount3,
                        RequiredItemCount4 = qt.RequiredItemCount4,
                        ObjectiveText1 = qt.ObjectiveText1,
                        ObjectiveText2 = qt.ObjectiveText2,
                        ObjectiveText3 = qt.ObjectiveText3,
                        ObjectiveText4 = qt.ObjectiveText4,
                        Data = 
                            data0 ?? 
                            quest_template_addon
                                .Where(i => i.ID == qt.ID)
                                .Select(i => new Data_quest_template_addon(i.AllowableClasses, i.PrevQuestID, i.NextQuestID))
                                .AsEnumerable(),
                        Data1 = 
                            data1 ??
                            (from at in areatrigger
                                join ati in areatrigger_involvedrelation.Where(i => i.quest == qt.ID) on at.ID equals ati.id
                                select at)
                            .Select(i => new Data_areatrigger(i.ID, i.ContinentID, i.x, i.y, i.z, i.radius, i.box_length, i.box_width, i.box_height, i.box_yaw))
                            .AsEnumerable(),
                        Data2 =
                            data2 ??
                            new PickUp(
                                creature_queststarter.Where(i => i.quest == qt.ID).Select(i => i.id).AsEnumerable(), 
                                gameobject_queststarter.Where(i => i.quest == qt.ID).Select(i => i.id).AsEnumerable(),
                                item_template.Where(i => i.startquest == qt.ID).Select(i => i.entry).AsEnumerable()),
                        Data3 = 
                            data3 ??
                            new TurnIn(
                                creature_questender.Where(i => i.quest == qt.ID).Select(i => i.id).AsEnumerable(), 
                                gameobject_questender.Where(i => i.quest == qt.ID).Select(i => i.id).AsEnumerable()),
                    };
                //Logging.Write(quest_template.ToString());
                return quest_template.ToList();
            }
        }
    }
}









