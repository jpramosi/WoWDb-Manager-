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
using System.Linq;
using DatabaseManager.Enums;
using DatabaseManager.Types;
using LinqToDB.Mapping;
using robotManager.Helpful;
using wManager.Wow.Enums;
using wManager.Wow.Helpers;


namespace DatabaseManager.Tables
{
    [Table(Name = "access_requirement")]
    public class access_requirement
    {
        [Column(Name = "mapId")]
        public int mapId { get; set; }

        [Column(Name = "difficulty")]
        public int difficulty { get; set; }

        [Column(Name = "level_min")]
        public int level_min { get; set; }

        [Column(Name = "level_max")]
        public int level_max { get; set; }

        [Column(Name = "item_level")]
        public int item_level { get; set; }

        [Column(Name = "item")]
        public int item { get; set; }

        [Column(Name = "item2")]
        public int item2 { get; set; }

        [Column(Name = "quest_done_A")]
        public int quest_done_A { get; set; }

        [Column(Name = "quest_done_H")]
        public int quest_done_H { get; set; }

        [Column(Name = "completed_achievement")]
        public int completed_achievement { get; set; }

        [Column(Name = "quest_failed_text")]
        public string quest_failed_text { get; set; }

        [Column(Name = "comment")]
        public string comment { get; set; }
    }

    [Table(Name = "areatrigger_involvedrelation")]
    public class areatrigger_involvedrelation
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "quest")]
        public int quest { get; set; }
    }

    [Table(Name = "areatrigger_scripts")]
    public class areatrigger_scripts
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }
    }

    [Table(Name = "areatrigger_teleport")]
    public class areatrigger_teleport
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "target_map")]
        public int target_map { get; set; }

        [Column(Name = "target_position_x")]
        public float target_position_x { get; set; }

        [Column(Name = "target_position_y")]
        public float target_position_y { get; set; }

        [Column(Name = "target_position_z")]
        public float target_position_z { get; set; }

        [Column(Name = "target_orientation")]
        public float target_orientation { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "battleground_template")]
    public class battleground_template
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "MinPlayersPerTeam")]
        public int MinPlayersPerTeam { get; set; }

        [Column(Name = "MaxPlayersPerTeam")]
        public int MaxPlayersPerTeam { get; set; }

        [Column(Name = "MinLvl")]
        public int MinLvl { get; set; }

        [Column(Name = "MaxLvl")]
        public int MaxLvl { get; set; }

        [Column(Name = "AllianceStartLoc")]
        public int AllianceStartLoc { get; set; }

        [Column(Name = "AllianceStartO")]
        public float AllianceStartO { get; set; }

        [Column(Name = "HordeStartLoc")]
        public int HordeStartLoc { get; set; }

        [Column(Name = "HordeStartO")]
        public float HordeStartO { get; set; }

        [Column(Name = "StartMaxDist")]
        public float StartMaxDist { get; set; }

        [Column(Name = "Weight")]
        public int Weight { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "battlemaster_entry")]
    public class battlemaster_entry
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "bg_template")]
        public int bg_template { get; set; }
    }
    
    [Table(Name = "creature")]
    public class creature
    {
        [Column(Name = "guid")]
        internal int guid { get; set; }

        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "map")]
        public int map { get; set; }

        [Column(Name = "zoneId")]
        public int zoneId { get; set; }

        [Column(Name = "areaId")]
        public int areaId { get; set; }

        [Column(Name = "spawnMask")]
        internal int spawnMask { get; set; }

        [Column(Name = "phaseMask")]
        internal int phaseMask { get; set; }

        [Column(Name = "modelid")]
        public int modelid { get; set; }

        [Column(Name = "equipment_id")]
        internal int equipment_id { get; set; }

        [Column(Name = "position_x")]
        public float position_x { get; set; }

        [Column(Name = "position_y")]
        public float position_y { get; set; }

        [Column(Name = "position_z")]
        public float position_z { get; set; }

        [Column(Name = "orientation")]
        public float orientation { get; set; }

        [Column(Name = "spawntimesecs")]
        public int spawntimesecs { get; set; }

        [Column(Name = "spawndist")]
        public float spawndist { get; set; }

        [Column(Name = "currentwaypoint")]
        public int currentwaypoint { get; set; }

        [Column(Name = "curhealth")]
        public int curhealth { get; set; }

        [Column(Name = "curmana")]
        public int curmana { get; set; }

        [Column(Name = "MovementType")]
        public int MovementType { get; set; }

        [Column(Name = "npcflag")]
        public int npcflag { get; set; }

        [Column(Name = "unit_flags")]
        public int unit_flags { get; set; }

        [Column(Name = "dynamicflags")]
        internal int dynamicflags { get; set; }

        [Column(Name = "ScriptName")]
        internal string ScriptName { get; set; }

        [Column(Name = "VerifiedBuild")]
        internal int VerifiedBuild { get; set; }

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public int MinLevel { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public int MaxLevel { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public int MinGold { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public int MaxGold { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public Vector3 Position { get; set; } = Vector3.Empty;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public UnitClassification Rank { get; set; } = UnitClassification.minus;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public WoWFactionTemplate Faction { get; set; } = WoWFactionTemplate.FromId(0);

        /// <summary>
        /// No linqdb-select!
        /// <para>Is bitmask</para>
        /// <see cref="GetNpcFlags"/>
        /// </summary>
        internal int NpcFlags { get; set; }
        public List<UnitNPCFlags> GetNpcFlags()
        {
            return Utilities.Other.BitmaskToEnum<UnitNPCFlags>(NpcFlags).ToList();
        }
    }

    [Table(Name = "creature_addon")]
    public class creature_addon
    {
        [Column(Name = "guid")]
        public int guid { get; set; }

        [Column(Name = "path_id")]
        public int path_id { get; set; }

        [Column(Name = "mount")]
        public int mount { get; set; }

        [Column(Name = "bytes1")]
        public int bytes1 { get; set; }

        [Column(Name = "bytes2")]
        public int bytes2 { get; set; }

        [Column(Name = "emote")]
        public int emote { get; set; }

        [Column(Name = "auras")]
        public string auras { get; set; }
    }

    [Table(Name = "creature_classlevelstats")]
    public class creature_classlevelstats
    {
        [Column(Name = "level")]
        public int level { get; set; }

        [Column(Name = "class")]
        public int class_ { get; set; }

        [Column(Name = "basehp0")]
        public int basehp0 { get; set; }

        [Column(Name = "basehp1")]
        public int basehp1 { get; set; }

        [Column(Name = "basehp2")]
        public int basehp2 { get; set; }

        [Column(Name = "basemana")]
        public int basemana { get; set; }

        [Column(Name = "basearmor")]
        public int basearmor { get; set; }

        [Column(Name = "attackpower")]
        public int attackpower { get; set; }

        [Column(Name = "rangedattackpower")]
        public int rangedattackpower { get; set; }

        [Column(Name = "damage_base")]
        public float damage_base { get; set; }

        [Column(Name = "damage_exp1")]
        public float damage_exp1 { get; set; }

        [Column(Name = "damage_exp2")]
        public float damage_exp2 { get; set; }

        [Column(Name = "comment")]
        public string comment { get; set; }
    }

    [Table(Name = "creature_loot_template")]
    public class creature_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "creature_questender")]
    public class creature_questender
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "quest")]
        public int quest { get; set; }
    }

    [Table(Name = "creature_questitem")]
    public class creature_questitem
    {
        [Column(Name = "CreatureEntry")]
        public int CreatureEntry { get; set; }

        [Column(Name = "Idx")]
        public int Idx { get; set; }

        [Column(Name = "ItemId")]
        public int ItemId { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "creature_queststarter")]
    public class creature_queststarter
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "quest")]
        public int quest { get; set; }
    }

    [Table(Name = "creature_template")]
    public class creature_template
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "difficulty_entry_1")]
        public int difficulty_entry_1 { get; set; }

        [Column(Name = "difficulty_entry_2")]
        public int difficulty_entry_2 { get; set; }

        [Column(Name = "difficulty_entry_3")]
        public int difficulty_entry_3 { get; set; }

        [Column(Name = "KillCredit1")]
        public int KillCredit1 { get; set; }

        [Column(Name = "KillCredit2")]
        public int KillCredit2 { get; set; }

        [Column(Name = "modelid1")]
        public int modelid1 { get; set; }

        [Column(Name = "modelid2")]
        public int modelid2 { get; set; }

        [Column(Name = "modelid3")]
        public int modelid3 { get; set; }

        [Column(Name = "modelid4")]
        public int modelid4 { get; set; }

        [Column(Name = "name")]
        public string name { get; set; }

        [Column(Name = "subname")]
        public string subname { get; set; }

        [Column(Name = "IconName")]
        public string IconName { get; set; }

        [Column(Name = "gossip_menu_id")]
        public int gossip_menu_id { get; set; }

        [Column(Name = "minlevel")]
        public int minlevel { get; set; }

        [Column(Name = "maxlevel")]
        public int maxlevel { get; set; }

        [Column(Name = "exp")]
        public int exp { get; set; }

        [Column(Name = "faction")]
        public uint faction { get; set; }

        [Column(Name = "npcflag")]
        public int npcflag { get; set; }

        [Column(Name = "speed_walk")]
        public float speed_walk { get; set; }

        [Column(Name = "speed_run")]
        public float speed_run { get; set; }

        [Column(Name = "scale")]
        public float scale { get; set; }

        [Column(Name = "rank")]
        public int rank { get; set; }

        [Column(Name = "dmgschool")]
        public int dmgschool { get; set; }

        [Column(Name = "BaseAttackTime")]
        public int BaseAttackTime { get; set; }

        [Column(Name = "RangeAttackTime")]
        public int RangeAttackTime { get; set; }

        [Column(Name = "BaseVariance")]
        public float BaseVariance { get; set; }

        [Column(Name = "RangeVariance")]
        public float RangeVariance { get; set; }

        [Column(Name = "unit_class")]
        public int unit_class { get; set; }

        [Column(Name = "unit_flags")]
        public int unit_flags { get; set; }

        [Column(Name = "unit_flags2")]
        public int unit_flags2 { get; set; }

        [Column(Name = "dynamicflags")]
        public int dynamicflags { get; set; }

        [Column(Name = "family")]
        public int family { get; set; }

        [Column(Name = "trainer_type")]
        public int trainer_type { get; set; }

        [Column(Name = "trainer_spell")]
        public int trainer_spell { get; set; }

        [Column(Name = "trainer_class")]
        public int trainer_class { get; set; }

        [Column(Name = "trainer_race")]
        public int trainer_race { get; set; }

        [Column(Name = "type")]
        public int type { get; set; }

        [Column(Name = "type_flags")]
        public int type_flags { get; set; }

        [Column(Name = "lootid")]
        public int lootid { get; set; }

        [Column(Name = "pickpocketloot")]
        public int pickpocketloot { get; set; }

        [Column(Name = "skinloot")]
        public int skinloot { get; set; }

        [Column(Name = "resistance1")]
        public int resistance1 { get; set; }

        [Column(Name = "resistance2")]
        public int resistance2 { get; set; }

        [Column(Name = "resistance3")]
        public int resistance3 { get; set; }

        [Column(Name = "resistance4")]
        public int resistance4 { get; set; }

        [Column(Name = "resistance5")]
        public int resistance5 { get; set; }

        [Column(Name = "resistance6")]
        public int resistance6 { get; set; }

        [Column(Name = "spell1")]
        public int spell1 { get; set; }

        [Column(Name = "spell2")]
        public int spell2 { get; set; }

        [Column(Name = "spell3")]
        public int spell3 { get; set; }

        [Column(Name = "spell4")]
        public int spell4 { get; set; }

        [Column(Name = "spell5")]
        public int spell5 { get; set; }

        [Column(Name = "spell6")]
        public int spell6 { get; set; }

        [Column(Name = "spell7")]
        public int spell7 { get; set; }

        [Column(Name = "spell8")]
        public int spell8 { get; set; }

        [Column(Name = "PetSpellDataId")]
        public int PetSpellDataId { get; set; }

        [Column(Name = "VehicleId")]
        public int VehicleId { get; set; }

        [Column(Name = "mingold")]
        public int mingold { get; set; }

        [Column(Name = "maxgold")]
        public int maxgold { get; set; }

        [Column(Name = "AIName")]
        public string AIName { get; set; }

        [Column(Name = "MovementType")]
        public int MovementType { get; set; }

        [Column(Name = "InhabitType")]
        public int InhabitType { get; set; }

        [Column(Name = "HoverHeight")]
        public float HoverHeight { get; set; }

        [Column(Name = "HealthModifier")]
        public float HealthModifier { get; set; }

        [Column(Name = "ManaModifier")]
        public float ManaModifier { get; set; }

        [Column(Name = "ArmorModifier")]
        public float ArmorModifier { get; set; }

        [Column(Name = "DamageModifier")]
        public float DamageModifier { get; set; }

        [Column(Name = "ExperienceModifier")]
        public float ExperienceModifier { get; set; }

        [Column(Name = "RacialLeader")]
        public int RacialLeader { get; set; }

        [Column(Name = "movementId")]
        public int movementId { get; set; }

        [Column(Name = "RegenHealth")]
        public int RegenHealth { get; set; }

        [Column(Name = "mechanic_immune_mask")]
        public int mechanic_immune_mask { get; set; }

        [Column(Name = "flags_extra")]
        public int flags_extra { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "creature_template_addon")]
    public class creature_template_addon
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "path_id")]
        public int path_id { get; set; }

        [Column(Name = "mount")]
        public int mount { get; set; }

        [Column(Name = "bytes1")]
        public int bytes1 { get; set; }

        [Column(Name = "bytes2")]
        public int bytes2 { get; set; }

        [Column(Name = "emote")]
        public int emote { get; set; }

        [Column(Name = "auras")]
        public string auras { get; set; }
    }

    [Table(Name = "disenchant_loot_template")]
    public class disenchant_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "fishing_loot_template")]
    public class fishing_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "gameobject")]
    public class gameobject
    {
        [Column(Name = "guid")]
        public int guid { get; set; }

        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "map")]
        public int map { get; set; }

        [Column(Name = "zoneId")]
        public int zoneId { get; set; }

        [Column(Name = "areaId")]
        public int areaId { get; set; }

        [Column(Name = "spawnMask")]
        public int spawnMask { get; set; }

        [Column(Name = "phaseMask")]
        public int phaseMask { get; set; }

        [Column(Name = "position_x")]
        public float position_x { get; set; }

        [Column(Name = "position_y")]
        public float position_y { get; set; }

        [Column(Name = "position_z")]
        public float position_z { get; set; }

        [Column(Name = "orientation")]
        public float orientation { get; set; }

        [Column(Name = "rotation0")]
        public float rotation0 { get; set; }

        [Column(Name = "rotation1")]
        public float rotation1 { get; set; }

        [Column(Name = "rotation2")]
        public float rotation2 { get; set; }

        [Column(Name = "rotation3")]
        public float rotation3 { get; set; }

        [Column(Name = "spawntimesecs")]
        public int spawntimesecs { get; set; }

        [Column(Name = "animprogress")]
        public int animprogress { get; set; }

        [Column(Name = "state")]
        public int state { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public GameObjectType Type { get; set; } = GameObjectType.None;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public int DisplayId { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public float Size { get; set; } = 0;

        /// <summary>
        /// No linqdb-select!
        /// </summary>
        public Vector3 Position { get; set; } = Vector3.Empty;
    }

    [Table(Name = "gameobject_addon")]
    public class gameobject_addon
    {
        [Column(Name = "guid")]
        public int guid { get; set; }

        [Column(Name = "parent_rotation0")]
        public float parent_rotation0 { get; set; }

        [Column(Name = "parent_rotation1")]
        public float parent_rotation1 { get; set; }

        [Column(Name = "parent_rotation2")]
        public float parent_rotation2 { get; set; }

        [Column(Name = "parent_rotation3")]
        public float parent_rotation3 { get; set; }

        [Column(Name = "invisibilityType")]
        public int invisibilityType { get; set; }

        [Column(Name = "invisibilityValue")]
        public int invisibilityValue { get; set; }
    }

    [Table(Name = "gameobject_loot_template")]
    public class gameobject_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "gameobject_questender")]
    public class gameobject_questender
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "quest")]
        public int quest { get; set; }
    }

    [Table(Name = "gameobject_questitem")]
    public class gameobject_questitem
    {
        [Column(Name = "GameObjectEntry")]
        public int GameObjectEntry { get; set; }

        [Column(Name = "Idx")]
        public int Idx { get; set; }

        [Column(Name = "ItemId")]
        public int ItemId { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "gameobject_queststarter")]
    public class gameobject_queststarter
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "quest")]
        public int quest { get; set; }
    }

    [Table(Name = "gameobject_template")]
    public class gameobject_template
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "type")]
        public int type { get; set; }

        [Column(Name = "displayId")]
        public int displayId { get; set; }

        [Column(Name = "name")]
        public string name { get; set; }

        [Column(Name = "IconName")]
        public string IconName { get; set; }

        [Column(Name = "castBarCaption")]
        public string castBarCaption { get; set; }

        [Column(Name = "unk1")]
        public string unk1 { get; set; }

        [Column(Name = "size")]
        public float size { get; set; }

        [Column(Name = "Data0")]
        public int Data0 { get; set; }

        [Column(Name = "Data1")]
        public int Data1 { get; set; }

        [Column(Name = "Data2")]
        public int Data2 { get; set; }

        [Column(Name = "Data3")]
        public int Data3 { get; set; }

        [Column(Name = "Data4")]
        public int Data4 { get; set; }

        [Column(Name = "Data5")]
        public int Data5 { get; set; }

        [Column(Name = "Data6")]
        public int Data6 { get; set; }

        [Column(Name = "Data7")]
        public int Data7 { get; set; }

        [Column(Name = "Data8")]
        public int Data8 { get; set; }

        [Column(Name = "Data9")]
        public int Data9 { get; set; }

        [Column(Name = "Data10")]
        public int Data10 { get; set; }

        [Column(Name = "Data11")]
        public int Data11 { get; set; }

        [Column(Name = "Data12")]
        public int Data12 { get; set; }

        [Column(Name = "Data13")]
        public int Data13 { get; set; }

        [Column(Name = "Data14")]
        public int Data14 { get; set; }

        [Column(Name = "Data15")]
        public int Data15 { get; set; }

        [Column(Name = "Data16")]
        public int Data16 { get; set; }

        [Column(Name = "Data17")]
        public int Data17 { get; set; }

        [Column(Name = "Data18")]
        public int Data18 { get; set; }

        [Column(Name = "Data19")]
        public int Data19 { get; set; }

        [Column(Name = "Data20")]
        public int Data20 { get; set; }

        [Column(Name = "Data21")]
        public int Data21 { get; set; }

        [Column(Name = "Data22")]
        public int Data22 { get; set; }

        [Column(Name = "Data23")]
        public int Data23 { get; set; }

        [Column(Name = "AIName")]
        public string AIName { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "gameobject_template_addon")]
    public class gameobject_template_addon
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "faction")]
        public int faction { get; set; }

        [Column(Name = "flags")]
        public int flags { get; set; }

        [Column(Name = "mingold")]
        public int mingold { get; set; }

        [Column(Name = "maxgold")]
        public int maxgold { get; set; }
    }

    [Table(Name = "graveyard_zone")]
    public class graveyard_zone
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "GhostZone")]
        public int GhostZone { get; set; }

        [Column(Name = "Faction")]
        public int Faction { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "item_enchantment_template")]
    public class item_enchantment_template
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "ench")]
        public int ench { get; set; }

        [Column(Name = "chance")]
        public float chance { get; set; }
    }

    [Table(Name = "item_loot_template")]
    public class item_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "item_template")]
    public class item_template
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "class")]
        public int class_ { get; set; }

        [Column(Name = "subclass")]
        public int subclass { get; set; }

        [Column(Name = "SoundOverrideSubclass")]
        public int SoundOverrideSubclass { get; set; }

        [Column(Name = "name")]
        public string name { get; set; }

        [Column(Name = "displayid")]
        public int displayid { get; set; }

        [Column(Name = "Quality")]
        public int Quality { get; set; }

        [Column(Name = "Flags")]
        public int Flags { get; set; }

        [Column(Name = "FlagsExtra")]
        public int FlagsExtra { get; set; }

        [Column(Name = "BuyCount")]
        public int BuyCount { get; set; }

        [Column(Name = "BuyPrice")]
        public int BuyPrice { get; set; }

        [Column(Name = "SellPrice")]
        public int SellPrice { get; set; }

        [Column(Name = "InventoryType")]
        public int InventoryType { get; set; }

        [Column(Name = "AllowableClass")]
        public int AllowableClass { get; set; }

        [Column(Name = "AllowableRace")]
        public int AllowableRace { get; set; }

        [Column(Name = "ItemLevel")]
        public int ItemLevel { get; set; }

        [Column(Name = "RequiredLevel")]
        public int RequiredLevel { get; set; }

        [Column(Name = "RequiredSkill")]
        public int RequiredSkill { get; set; }

        [Column(Name = "RequiredSkillRank")]
        public int RequiredSkillRank { get; set; }

        [Column(Name = "requiredspell")]
        public int requiredspell { get; set; }

        [Column(Name = "requiredhonorrank")]
        public int requiredhonorrank { get; set; }

        [Column(Name = "RequiredCityRank")]
        public int RequiredCityRank { get; set; }

        [Column(Name = "RequiredReputationFaction")]
        public int RequiredReputationFaction { get; set; }

        [Column(Name = "RequiredReputationRank")]
        public int RequiredReputationRank { get; set; }

        [Column(Name = "maxcount")]
        public int maxcount { get; set; }

        [Column(Name = "stackable")]
        public int stackable { get; set; }

        [Column(Name = "ContainerSlots")]
        public int ContainerSlots { get; set; }

        [Column(Name = "StatsCount")]
        public int StatsCount { get; set; }

        [Column(Name = "stat_type1")]
        public int stat_type1 { get; set; }

        [Column(Name = "stat_value1")]
        public int stat_value1 { get; set; }

        [Column(Name = "stat_type2")]
        public int stat_type2 { get; set; }

        [Column(Name = "stat_value2")]
        public int stat_value2 { get; set; }

        [Column(Name = "stat_type3")]
        public int stat_type3 { get; set; }

        [Column(Name = "stat_value3")]
        public int stat_value3 { get; set; }

        [Column(Name = "stat_type4")]
        public int stat_type4 { get; set; }

        [Column(Name = "stat_value4")]
        public int stat_value4 { get; set; }

        [Column(Name = "stat_type5")]
        public int stat_type5 { get; set; }

        [Column(Name = "stat_value5")]
        public int stat_value5 { get; set; }

        [Column(Name = "stat_type6")]
        public int stat_type6 { get; set; }

        [Column(Name = "stat_value6")]
        public int stat_value6 { get; set; }

        [Column(Name = "stat_type7")]
        public int stat_type7 { get; set; }

        [Column(Name = "stat_value7")]
        public int stat_value7 { get; set; }

        [Column(Name = "stat_type8")]
        public int stat_type8 { get; set; }

        [Column(Name = "stat_value8")]
        public int stat_value8 { get; set; }

        [Column(Name = "stat_type9")]
        public int stat_type9 { get; set; }

        [Column(Name = "stat_value9")]
        public int stat_value9 { get; set; }

        [Column(Name = "stat_type10")]
        public int stat_type10 { get; set; }

        [Column(Name = "stat_value10")]
        public int stat_value10 { get; set; }

        [Column(Name = "ScalingStatDistribution")]
        public int ScalingStatDistribution { get; set; }

        [Column(Name = "ScalingStatValue")]
        public int ScalingStatValue { get; set; }

        [Column(Name = "dmg_min1")]
        public float dmg_min1 { get; set; }

        [Column(Name = "dmg_max1")]
        public float dmg_max1 { get; set; }

        [Column(Name = "dmg_type1")]
        public int dmg_type1 { get; set; }

        [Column(Name = "dmg_min2")]
        public float dmg_min2 { get; set; }

        [Column(Name = "dmg_max2")]
        public float dmg_max2 { get; set; }

        [Column(Name = "dmg_type2")]
        public int dmg_type2 { get; set; }

        [Column(Name = "armor")]
        public int armor { get; set; }

        [Column(Name = "holy_res")]
        public int holy_res { get; set; }

        [Column(Name = "fire_res")]
        public int fire_res { get; set; }

        [Column(Name = "nature_res")]
        public int nature_res { get; set; }

        [Column(Name = "frost_res")]
        public int frost_res { get; set; }

        [Column(Name = "shadow_res")]
        public int shadow_res { get; set; }

        [Column(Name = "arcane_res")]
        public int arcane_res { get; set; }

        [Column(Name = "delay")]
        public int delay { get; set; }

        [Column(Name = "ammo_type")]
        public int ammo_type { get; set; }

        [Column(Name = "RangedModRange")]
        public float RangedModRange { get; set; }

        [Column(Name = "spellid_1")]
        public uint spellid_1 { get; set; }

        [Column(Name = "spelltrigger_1")]
        public int spelltrigger_1 { get; set; }

        [Column(Name = "spellcharges_1")]
        public int spellcharges_1 { get; set; }

        [Column(Name = "spellppmRate_1")]
        public float spellppmRate_1 { get; set; }

        [Column(Name = "spellcooldown_1")]
        public int spellcooldown_1 { get; set; }

        [Column(Name = "spellcategory_1")]
        public int spellcategory_1 { get; set; }

        [Column(Name = "spellcategorycooldown_1")]
        public int spellcategorycooldown_1 { get; set; }

        [Column(Name = "spellid_2")]
        public int spellid_2 { get; set; }

        [Column(Name = "spelltrigger_2")]
        public int spelltrigger_2 { get; set; }

        [Column(Name = "spellcharges_2")]
        public int spellcharges_2 { get; set; }

        [Column(Name = "spellppmRate_2")]
        public float spellppmRate_2 { get; set; }

        [Column(Name = "spellcooldown_2")]
        public int spellcooldown_2 { get; set; }

        [Column(Name = "spellcategory_2")]
        public int spellcategory_2 { get; set; }

        [Column(Name = "spellcategorycooldown_2")]
        public int spellcategorycooldown_2 { get; set; }

        [Column(Name = "spellid_3")]
        public int spellid_3 { get; set; }

        [Column(Name = "spelltrigger_3")]
        public int spelltrigger_3 { get; set; }

        [Column(Name = "spellcharges_3")]
        public int spellcharges_3 { get; set; }

        [Column(Name = "spellppmRate_3")]
        public float spellppmRate_3 { get; set; }

        [Column(Name = "spellcooldown_3")]
        public int spellcooldown_3 { get; set; }

        [Column(Name = "spellcategory_3")]
        public int spellcategory_3 { get; set; }

        [Column(Name = "spellcategorycooldown_3")]
        public int spellcategorycooldown_3 { get; set; }

        [Column(Name = "spellid_4")]
        public int spellid_4 { get; set; }

        [Column(Name = "spelltrigger_4")]
        public int spelltrigger_4 { get; set; }

        [Column(Name = "spellcharges_4")]
        public int spellcharges_4 { get; set; }

        [Column(Name = "spellppmRate_4")]
        public float spellppmRate_4 { get; set; }

        [Column(Name = "spellcooldown_4")]
        public int spellcooldown_4 { get; set; }

        [Column(Name = "spellcategory_4")]
        public int spellcategory_4 { get; set; }

        [Column(Name = "spellcategorycooldown_4")]
        public int spellcategorycooldown_4 { get; set; }

        [Column(Name = "spellid_5")]
        public int spellid_5 { get; set; }

        [Column(Name = "spelltrigger_5")]
        public int spelltrigger_5 { get; set; }

        [Column(Name = "spellcharges_5")]
        public int spellcharges_5 { get; set; }

        [Column(Name = "spellppmRate_5")]
        public float spellppmRate_5 { get; set; }

        [Column(Name = "spellcooldown_5")]
        public int spellcooldown_5 { get; set; }

        [Column(Name = "spellcategory_5")]
        public int spellcategory_5 { get; set; }

        [Column(Name = "spellcategorycooldown_5")]
        public int spellcategorycooldown_5 { get; set; }

        [Column(Name = "bonding")]
        public int bonding { get; set; }

        [Column(Name = "description")]
        public string description { get; set; }

        [Column(Name = "PageText")]
        public int PageText { get; set; }

        [Column(Name = "LanguageID")]
        public int LanguageID { get; set; }

        [Column(Name = "PageMaterial")]
        public int PageMaterial { get; set; }

        [Column(Name = "startquest")]
        public int startquest { get; set; }

        [Column(Name = "lockid")]
        public int lockid { get; set; }

        [Column(Name = "Material")]
        public int Material { get; set; }

        [Column(Name = "sheath")]
        public int sheath { get; set; }

        [Column(Name = "RandomProperty")]
        public int RandomProperty { get; set; }

        [Column(Name = "RandomSuffix")]
        public int RandomSuffix { get; set; }

        [Column(Name = "block")]
        public int block { get; set; }

        [Column(Name = "itemset")]
        public int itemset { get; set; }

        [Column(Name = "MaxDurability")]
        public int MaxDurability { get; set; }

        [Column(Name = "area")]
        public int area { get; set; }

        [Column(Name = "Map")]
        public int Map { get; set; }

        [Column(Name = "BagFamily")]
        public int BagFamily { get; set; }

        [Column(Name = "TotemCategory")]
        public int TotemCategory { get; set; }

        [Column(Name = "socketColor_1")]
        public int socketColor_1 { get; set; }

        [Column(Name = "socketContent_1")]
        public int socketContent_1 { get; set; }

        [Column(Name = "socketColor_2")]
        public int socketColor_2 { get; set; }

        [Column(Name = "socketContent_2")]
        public int socketContent_2 { get; set; }

        [Column(Name = "socketColor_3")]
        public int socketColor_3 { get; set; }

        [Column(Name = "socketContent_3")]
        public int socketContent_3 { get; set; }

        [Column(Name = "socketBonus")]
        public int socketBonus { get; set; }

        [Column(Name = "GemProperties")]
        public int GemProperties { get; set; }

        [Column(Name = "RequiredDisenchantSkill")]
        public int RequiredDisenchantSkill { get; set; }

        [Column(Name = "ArmorDamageModifier")]
        public float ArmorDamageModifier { get; set; }

        [Column(Name = "duration")]
        public int duration { get; set; }

        [Column(Name = "ItemLimitCategory")]
        public int ItemLimitCategory { get; set; }

        [Column(Name = "HolidayId")]
        public int HolidayId { get; set; }

        [Column(Name = "ScriptName")]
        public string ScriptName { get; set; }

        [Column(Name = "DisenchantID")]
        public int DisenchantID { get; set; }

        [Column(Name = "FoodType")]
        public int FoodType { get; set; }

        [Column(Name = "minMoneyLoot")]
        public int minMoneyLoot { get; set; }

        [Column(Name = "maxMoneyLoot")]
        public int maxMoneyLoot { get; set; }

        [Column(Name = "flagsCustom")]
        public int flagsCustom { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "milling_loot_template")]
    public class milling_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "npc_trainer")]
    public class npc_trainer
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "SpellID")]
        public int SpellID { get; set; }

        [Column(Name = "MoneyCost")]
        public int MoneyCost { get; set; }

        [Column(Name = "ReqSkillLine")]
        public int ReqSkillLine { get; set; }

        [Column(Name = "ReqSkillRank")]
        public int ReqSkillRank { get; set; }

        [Column(Name = "ReqLevel")]
        public int ReqLevel { get; set; }
    }

    [Table(Name = "npc_vendor")]
    public class npc_vendor
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "slot")]
        public int slot { get; set; }

        [Column(Name = "item")]
        public int item { get; set; }

        [Column(Name = "maxcount")]
        public int maxcount { get; set; }

        [Column(Name = "incrtime")]
        public int incrtime { get; set; }

        [Column(Name = "ExtendedCost")]
        public int ExtendedCost { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "pickpocketing_loot_template")]
    public class pickpocketing_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "player_xp_for_level")]
    public class player_xp_for_level
    {
        [Column(Name = "Level")]
        public int Level { get; set; }

        [Column(Name = "Experience")]
        public int Experience { get; set; }
    }

    [Table(Name = "playercreateinfo")]
    public class playercreateinfo
    {
        [Column(Name = "race")]
        public int race { get; set; }

        [Column(Name = "class")]
        public int class_ { get; set; }

        [Column(Name = "map")]
        public int map { get; set; }

        [Column(Name = "zone")]
        public int zone { get; set; }

        [Column(Name = "position_x")]
        public float position_x { get; set; }

        [Column(Name = "position_y")]
        public float position_y { get; set; }

        [Column(Name = "position_z")]
        public float position_z { get; set; }

        [Column(Name = "orientation")]
        public float orientation { get; set; }
    }

    [Table(Name = "points_of_interest")]
    public class points_of_interest
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "PositionX")]
        public float PositionX { get; set; }

        [Column(Name = "PositionY")]
        public float PositionY { get; set; }

        [Column(Name = "Icon")]
        public int Icon { get; set; }

        [Column(Name = "Flags")]
        public int Flags { get; set; }

        [Column(Name = "Importance")]
        public int Importance { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "quest_offer_reward")]
    public class quest_offer_reward
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "Emote1")]
        public int Emote1 { get; set; }

        [Column(Name = "Emote2")]
        public int Emote2 { get; set; }

        [Column(Name = "Emote3")]
        public int Emote3 { get; set; }

        [Column(Name = "Emote4")]
        public int Emote4 { get; set; }

        [Column(Name = "EmoteDelay1")]
        public int EmoteDelay1 { get; set; }

        [Column(Name = "EmoteDelay2")]
        public int EmoteDelay2 { get; set; }

        [Column(Name = "EmoteDelay3")]
        public int EmoteDelay3 { get; set; }

        [Column(Name = "EmoteDelay4")]
        public int EmoteDelay4 { get; set; }

        [Column(Name = "RewardText")]
        public string RewardText { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "quest_poi")]
    public class quest_poi
    {
        [Column(Name = "QuestID")]
        public int QuestID { get; set; }

        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "ObjectiveIndex")]
        public int ObjectiveIndex { get; set; }

        [Column(Name = "MapID")]
        public int MapID { get; set; }

        [Column(Name = "WorldMapAreaId")]
        public int WorldMapAreaId { get; set; }

        [Column(Name = "Floor")]
        public int Floor { get; set; }

        [Column(Name = "Priority")]
        public int Priority { get; set; }

        [Column(Name = "Flags")]
        public int Flags { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "quest_poi_points")]
    public class quest_poi_points
    {
        [Column(Name = "QuestID")]
        public int QuestID { get; set; }

        [Column(Name = "Idx1")]
        public int Idx1 { get; set; }

        [Column(Name = "Idx2")]
        public int Idx2 { get; set; }

        [Column(Name = "X")]
        public int X { get; set; }

        [Column(Name = "Y")]
        public int Y { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "quest_request_items")]
    public class quest_request_items
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "EmoteOnComplete")]
        public int EmoteOnComplete { get; set; }

        [Column(Name = "EmoteOnIncomplete")]
        public int EmoteOnIncomplete { get; set; }

        [Column(Name = "CompletionText")]
        public string CompletionText { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "quest_template")]
    public class quest_template
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "QuestType")]
        public int QuestType { get; set; }

        [Column(Name = "QuestLevel")]
        public int QuestLevel { get; set; }

        [Column(Name = "MinLevel")]
        public int MinLevel { get; set; }

        [Column(Name = "QuestSortID")]
        internal int QuestSortID { get; set; }

        [Column(Name = "QuestInfoID")]
        public int QuestInfoID { get; set; }

        [Column(Name = "SuggestedGroupNum")]
        public int SuggestedGroupNum { get; set; }

        [Column(Name = "RequiredFactionId1")]
        internal int RequiredFactionId1 { get; set; }

        [Column(Name = "RequiredFactionId2")]
        internal int RequiredFactionId2 { get; set; }

        [Column(Name = "RequiredFactionValue1")]
        internal int RequiredFactionValue1 { get; set; }

        [Column(Name = "RequiredFactionValue2")]
        internal int RequiredFactionValue2 { get; set; }

        [Column(Name = "RewardNextQuest")]
        public int RewardNextQuest { get; set; }

        [Column(Name = "RewardXPDifficulty")]
        public int RewardXPDifficulty { get; set; }

        [Column(Name = "RewardMoney")]
        public int RewardMoney { get; set; }

        [Column(Name = "RewardBonusMoney")]
        public int RewardBonusMoney { get; set; }

        [Column(Name = "RewardDisplaySpell")]
        public int RewardDisplaySpell { get; set; }

        [Column(Name = "RewardSpell")]
        public int RewardSpell { get; set; }

        [Column(Name = "RewardHonor")]
        public int RewardHonor { get; set; }

        [Column(Name = "RewardKillHonor")]
        public float RewardKillHonor { get; set; }

        [Column(Name = "StartItem")]
        public int StartItem { get; set; }

        [Column(Name = "Flags")]
        public int Flags { get; set; }
        
        [Column(Name = "RequiredPlayerKills")]
        public int RequiredPlayerKills { get; set; }

        [Column(Name = "RewardItem1")]
        public int RewardItem1 { get; set; }

        [Column(Name = "RewardAmount1")]
        public int RewardAmount1 { get; set; }

        [Column(Name = "RewardItem2")]
        public int RewardItem2 { get; set; }

        [Column(Name = "RewardAmount2")]
        public int RewardAmount2 { get; set; }

        [Column(Name = "RewardItem3")]
        public int RewardItem3 { get; set; }

        [Column(Name = "RewardAmount3")]
        public int RewardAmount3 { get; set; }

        [Column(Name = "RewardItem4")]
        public int RewardItem4 { get; set; }

        [Column(Name = "RewardAmount4")]
        public int RewardAmount4 { get; set; }

        [Column(Name = "ItemDrop1")]
        public int ItemDrop1 { get; set; }

        [Column(Name = "ItemDropQuantity1")]
        public int ItemDropQuantity1 { get; set; }

        [Column(Name = "ItemDrop2")]
        public int ItemDrop2 { get; set; }

        [Column(Name = "ItemDropQuantity2")]
        public int ItemDropQuantity2 { get; set; }

        [Column(Name = "ItemDrop3")]
        public int ItemDrop3 { get; set; }

        [Column(Name = "ItemDropQuantity3")]
        public int ItemDropQuantity3 { get; set; }

        [Column(Name = "ItemDrop4")]
        public int ItemDrop4 { get; set; }

        [Column(Name = "ItemDropQuantity4")]
        public int ItemDropQuantity4 { get; set; }

        [Column(Name = "RewardChoiceItemID1")]
        public int RewardChoiceItemID1 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity1")]
        public int RewardChoiceItemQuantity1 { get; set; }

        [Column(Name = "RewardChoiceItemID2")]
        public int RewardChoiceItemID2 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity2")]
        public int RewardChoiceItemQuantity2 { get; set; }

        [Column(Name = "RewardChoiceItemID3")]
        public int RewardChoiceItemID3 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity3")]
        public int RewardChoiceItemQuantity3 { get; set; }

        [Column(Name = "RewardChoiceItemID4")]
        public int RewardChoiceItemID4 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity4")]
        public int RewardChoiceItemQuantity4 { get; set; }

        [Column(Name = "RewardChoiceItemID5")]
        public int RewardChoiceItemID5 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity5")]
        public int RewardChoiceItemQuantity5 { get; set; }

        [Column(Name = "RewardChoiceItemID6")]
        public int RewardChoiceItemID6 { get; set; }

        [Column(Name = "RewardChoiceItemQuantity6")]
        public int RewardChoiceItemQuantity6 { get; set; }

        [Column(Name = "POIContinent")]
        public int POIContinent { get; set; }

        [Column(Name = "POIx")]
        public float POIx { get; set; }

        [Column(Name = "POIy")]
        public float POIy { get; set; }

        [Column(Name = "POIPriority")]
        public int POIPriority { get; set; }

        [Column(Name = "RewardTitle")]
        public int RewardTitle { get; set; }

        [Column(Name = "RewardTalents")]
        public int RewardTalents { get; set; }

        [Column(Name = "RewardArenaPoints")]
        public int RewardArenaPoints { get; set; }

        [Column(Name = "RewardFactionID1")]
        public int RewardFactionID1 { get; set; }

        [Column(Name = "RewardFactionValue1")]
        public int RewardFactionValue1 { get; set; }

        [Column(Name = "RewardFactionOverride1")]
        public int RewardFactionOverride1 { get; set; }

        [Column(Name = "RewardFactionID2")]
        public int RewardFactionID2 { get; set; }

        [Column(Name = "RewardFactionValue2")]
        public int RewardFactionValue2 { get; set; }

        [Column(Name = "RewardFactionOverride2")]
        public int RewardFactionOverride2 { get; set; }

        [Column(Name = "RewardFactionID3")]
        public int RewardFactionID3 { get; set; }

        [Column(Name = "RewardFactionValue3")]
        public int RewardFactionValue3 { get; set; }

        [Column(Name = "RewardFactionOverride3")]
        public int RewardFactionOverride3 { get; set; }

        [Column(Name = "RewardFactionID4")]
        public int RewardFactionID4 { get; set; }

        [Column(Name = "RewardFactionValue4")]
        public int RewardFactionValue4 { get; set; }

        [Column(Name = "RewardFactionOverride4")]
        public int RewardFactionOverride4 { get; set; }

        [Column(Name = "RewardFactionID5")]
        public int RewardFactionID5 { get; set; }

        [Column(Name = "RewardFactionValue5")]
        public int RewardFactionValue5 { get; set; }

        [Column(Name = "RewardFactionOverride5")]
        public int RewardFactionOverride5 { get; set; }

        [Column(Name = "TimeAllowed")]
        public int TimeAllowed { get; set; }

        [Column(Name = "AllowableRaces")]
        public int AllowableRaces { get; set; }

        [Column(Name = "LogTitle")]
        public string LogTitle { get; set; }

        [Column(Name = "LogDescription")]
        public string LogDescription { get; set; }

        [Column(Name = "QuestDescription")]
        public string QuestDescription { get; set; }

        [Column(Name = "AreaDescription")]
        public string AreaDescription { get; set; }

        [Column(Name = "QuestCompletionLog")]
        public string QuestCompletionLog { get; set; }

        [Column(Name = "RequiredNpcOrGo1")]
        public int RequiredNpcOrGo1 { get; set; }

        [Column(Name = "RequiredNpcOrGo2")]
        public int RequiredNpcOrGo2 { get; set; }

        [Column(Name = "RequiredNpcOrGo3")]
        public int RequiredNpcOrGo3 { get; set; }

        [Column(Name = "RequiredNpcOrGo4")]
        public int RequiredNpcOrGo4 { get; set; }

        [Column(Name = "RequiredNpcOrGoCount1")]
        public int RequiredNpcOrGoCount1 { get; set; }

        [Column(Name = "RequiredNpcOrGoCount2")]
        public int RequiredNpcOrGoCount2 { get; set; }

        [Column(Name = "RequiredNpcOrGoCount3")]
        public int RequiredNpcOrGoCount3 { get; set; }

        [Column(Name = "RequiredNpcOrGoCount4")]
        public int RequiredNpcOrGoCount4 { get; set; }

        [Column(Name = "RequiredItemId1")]
        public int RequiredItemId1 { get; set; }

        [Column(Name = "RequiredItemId2")]
        public int RequiredItemId2 { get; set; }

        [Column(Name = "RequiredItemId3")]
        public int RequiredItemId3 { get; set; }

        [Column(Name = "RequiredItemId4")]
        public int RequiredItemId4 { get; set; }

        [Column(Name = "RequiredItemId5")]
        public int RequiredItemId5 { get; set; }

        [Column(Name = "RequiredItemId6")]
        public int RequiredItemId6 { get; set; }

        [Column(Name = "RequiredItemCount1")]
        public int RequiredItemCount1 { get; set; }

        [Column(Name = "RequiredItemCount2")]
        public int RequiredItemCount2 { get; set; }

        [Column(Name = "RequiredItemCount3")]
        public int RequiredItemCount3 { get; set; }

        [Column(Name = "RequiredItemCount4")]
        public int RequiredItemCount4 { get; set; }

        [Column(Name = "RequiredItemCount5")]
        public int RequiredItemCount5 { get; set; }

        [Column(Name = "RequiredItemCount6")]
        public int RequiredItemCount6 { get; set; }

        [Column(Name = "Unknown0")]
        internal int Unknown0 { get; set; }

        [Column(Name = "ObjectiveText1")]
        public string ObjectiveText1 { get; set; }

        [Column(Name = "ObjectiveText2")]
        public string ObjectiveText2 { get; set; }

        [Column(Name = "ObjectiveText3")]
        public string ObjectiveText3 { get; set; }

        [Column(Name = "ObjectiveText4")]
        public string ObjectiveText4 { get; set; }

        [Column(Name = "VerifiedBuild")]
        internal int VerifiedBuild { get; set; }
        
        /// <summary>
        /// List of quest flags
        /// </summary>
        public IEnumerable<QuestFlags> flags => Utilities.Other.BitmaskToEnum<QuestFlags>(Flags);
        
        /// <summary>
        /// Internal usage
        /// </summary>
        internal IEnumerable<Data_quest_template_addon> Data { get; set; } = new Data_quest_template_addon[0];
        
        /// <summary>
        /// Contains data by type
        /// <para>Affected by <see cref="DatabaseManager.Filter.QuestFilter.ReturnData"/></para>
        /// </summary>
        public Data_quest_template_addon Data0 => Data.FirstOrDefault();

        /// <summary>
        /// Contains a list of all area triggers for a quest
        /// <para>AreaTrigger: Is used here as a quest-objective(explore an area for example)</para>
        /// <para>Affected by <see cref="DatabaseManager.Filter.QuestFilter.ReturnData"/></para>
        /// </summary>
        public IEnumerable<Data_areatrigger> Data1 { get; set; } = new Data_areatrigger[0];
        
        /// <summary>
        /// Contains data by type
        /// <para>Affected by <see cref="DatabaseManager.Filter.QuestFilter.ReturnData"/></para>
        /// </summary>
        public PickUp Data2 { get; set; } = new PickUp();

        /// <summary>
        /// Contains data by type
        /// <para>Affected by <see cref="DatabaseManager.Filter.QuestFilter.ReturnData"/></para>
        /// </summary>
        public TurnIn Data3 { get; set; } = new TurnIn();
    }

    [Table(Name = "quest_template_addon")]
    public class quest_template_addon
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "MaxLevel")]
        public int MaxLevel { get; set; }

        [Column(Name = "AllowableClasses")]
        public int AllowableClasses { get; set; }

        [Column(Name = "SourceSpellID")]
        public int SourceSpellID { get; set; }

        [Column(Name = "PrevQuestID")]
        public int PrevQuestID { get; set; }

        [Column(Name = "NextQuestID")]
        public int NextQuestID { get; set; }

        [Column(Name = "ExclusiveGroup")]
        public int ExclusiveGroup { get; set; }

        [Column(Name = "RewardMailTemplateID")]
        public int RewardMailTemplateID { get; set; }

        [Column(Name = "RewardMailDelay")]
        public int RewardMailDelay { get; set; }

        [Column(Name = "RequiredSkillID")]
        public int RequiredSkillID { get; set; }

        [Column(Name = "RequiredSkillPoints")]
        public int RequiredSkillPoints { get; set; }

        [Column(Name = "RequiredMinRepFaction")]
        public int RequiredMinRepFaction { get; set; }

        [Column(Name = "RequiredMaxRepFaction")]
        public int RequiredMaxRepFaction { get; set; }

        [Column(Name = "RequiredMinRepValue")]
        public int RequiredMinRepValue { get; set; }

        [Column(Name = "RequiredMaxRepValue")]
        public int RequiredMaxRepValue { get; set; }

        [Column(Name = "ProvidedItemCount")]
        public int ProvidedItemCount { get; set; }

        [Column(Name = "SpecialFlags")]
        public int SpecialFlags { get; set; }
    }

    [Table(Name = "reference_loot_template")]
    public class reference_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "script_spline_chain_meta")]
    public class script_spline_chain_meta
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "chainId")]
        public int chainId { get; set; }

        [Column(Name = "splineId")]
        public int splineId { get; set; }

        [Column(Name = "expectedDuration")]
        public int expectedDuration { get; set; }

        [Column(Name = "msUntilNext")]
        public int msUntilNext { get; set; }
    }

    [Table(Name = "script_spline_chain_waypoints")]
    public class script_spline_chain_waypoints
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "chainId")]
        public int chainId { get; set; }

        [Column(Name = "splineId")]
        public int splineId { get; set; }

        [Column(Name = "wpId")]
        public int wpId { get; set; }

        [Column(Name = "x")]
        public float x { get; set; }

        [Column(Name = "y")]
        public float y { get; set; }

        [Column(Name = "z")]
        public float z { get; set; }
    }

    [Table(Name = "script_waypoint")]
    public class script_waypoint
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "pointid")]
        public int pointid { get; set; }

        [Column(Name = "location_x")]
        public float location_x { get; set; }

        [Column(Name = "location_y")]
        public float location_y { get; set; }

        [Column(Name = "location_z")]
        public float location_z { get; set; }

        [Column(Name = "waittime")]
        public int waittime { get; set; }

        [Column(Name = "point_comment")]
        public string point_comment { get; set; }
    }

    [Table(Name = "skill_fishing_base_level")]
    public class skill_fishing_base_level
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "skill")]
        public int skill { get; set; }
    }

    [Table(Name = "skinning_loot_template")]
    public class skinning_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "spell_area")]
    public class spell_area
    {
        [Column(Name = "spell")]
        public int spell { get; set; }

        [Column(Name = "area")]
        public int area { get; set; }

        [Column(Name = "quest_start")]
        public int quest_start { get; set; }

        [Column(Name = "quest_end")]
        public int quest_end { get; set; }

        [Column(Name = "aura_spell")]
        public int aura_spell { get; set; }

        [Column(Name = "racemask")]
        public int racemask { get; set; }

        [Column(Name = "gender")]
        public int gender { get; set; }

        [Column(Name = "autocast")]
        public int autocast { get; set; }

        [Column(Name = "quest_start_status")]
        public int quest_start_status { get; set; }

        [Column(Name = "quest_end_status")]
        public int quest_end_status { get; set; }
    }

    /// <summary>
    /// Serverside spells
    /// </summary>
    [Table(Name = "spell_dbc")]
    public class spell_dbc
    {
        [Column(Name = "Id")]
        public int Id { get; set; }

        [Column(Name = "Dispel")]
        public int Dispel { get; set; }

        [Column(Name = "Mechanic")]
        public int Mechanic { get; set; }

        [Column(Name = "Attributes")]
        public int Attributes { get; set; }

        [Column(Name = "AttributesEx")]
        public int AttributesEx { get; set; }

        [Column(Name = "AttributesEx2")]
        public int AttributesEx2 { get; set; }

        [Column(Name = "AttributesEx3")]
        public int AttributesEx3 { get; set; }

        [Column(Name = "AttributesEx4")]
        public int AttributesEx4 { get; set; }

        [Column(Name = "AttributesEx5")]
        public int AttributesEx5 { get; set; }

        [Column(Name = "AttributesEx6")]
        public int AttributesEx6 { get; set; }

        [Column(Name = "AttributesEx7")]
        public int AttributesEx7 { get; set; }

        [Column(Name = "Stances")]
        public int Stances { get; set; }

        [Column(Name = "StancesNot")]
        public int StancesNot { get; set; }

        [Column(Name = "Targets")]
        public int Targets { get; set; }

        [Column(Name = "CastingTimeIndex")]
        public int CastingTimeIndex { get; set; }

        [Column(Name = "AuraInterruptFlags")]
        public int AuraInterruptFlags { get; set; }

        [Column(Name = "ProcFlags")]
        public int ProcFlags { get; set; }

        [Column(Name = "ProcChance")]
        public int ProcChance { get; set; }

        [Column(Name = "ProcCharges")]
        public int ProcCharges { get; set; }

        [Column(Name = "MaxLevel")]
        public int MaxLevel { get; set; }

        [Column(Name = "BaseLevel")]
        public int BaseLevel { get; set; }

        [Column(Name = "SpellLevel")]
        public int SpellLevel { get; set; }

        [Column(Name = "DurationIndex")]
        public int DurationIndex { get; set; }

        [Column(Name = "RangeIndex")]
        public int RangeIndex { get; set; }

        [Column(Name = "StackAmount")]
        public int StackAmount { get; set; }

        [Column(Name = "EquippedItemClass")]
        public int EquippedItemClass { get; set; }

        [Column(Name = "EquippedItemSubClassMask")]
        public int EquippedItemSubClassMask { get; set; }

        [Column(Name = "EquippedItemInventoryTypeMask")]
        public int EquippedItemInventoryTypeMask { get; set; }

        [Column(Name = "Effect1")]
        public int Effect1 { get; set; }

        [Column(Name = "Effect2")]
        public int Effect2 { get; set; }

        [Column(Name = "Effect3")]
        public int Effect3 { get; set; }

        [Column(Name = "EffectDieSides1")]
        public int EffectDieSides1 { get; set; }

        [Column(Name = "EffectDieSides2")]
        public int EffectDieSides2 { get; set; }

        [Column(Name = "EffectDieSides3")]
        public int EffectDieSides3 { get; set; }

        [Column(Name = "EffectRealPointsPerLevel1")]
        public float EffectRealPointsPerLevel1 { get; set; }

        [Column(Name = "EffectRealPointsPerLevel2")]
        public float EffectRealPointsPerLevel2 { get; set; }

        [Column(Name = "EffectRealPointsPerLevel3")]
        public float EffectRealPointsPerLevel3 { get; set; }

        [Column(Name = "EffectBasePoints1")]
        public int EffectBasePoints1 { get; set; }

        [Column(Name = "EffectBasePoints2")]
        public int EffectBasePoints2 { get; set; }

        [Column(Name = "EffectBasePoints3")]
        public int EffectBasePoints3 { get; set; }

        [Column(Name = "EffectMechanic1")]
        public int EffectMechanic1 { get; set; }

        [Column(Name = "EffectMechanic2")]
        public int EffectMechanic2 { get; set; }

        [Column(Name = "EffectMechanic3")]
        public int EffectMechanic3 { get; set; }

        [Column(Name = "EffectImplicitTargetA1")]
        public int EffectImplicitTargetA1 { get; set; }

        [Column(Name = "EffectImplicitTargetA2")]
        public int EffectImplicitTargetA2 { get; set; }

        [Column(Name = "EffectImplicitTargetA3")]
        public int EffectImplicitTargetA3 { get; set; }

        [Column(Name = "EffectImplicitTargetB1")]
        public int EffectImplicitTargetB1 { get; set; }

        [Column(Name = "EffectImplicitTargetB2")]
        public int EffectImplicitTargetB2 { get; set; }

        [Column(Name = "EffectImplicitTargetB3")]
        public int EffectImplicitTargetB3 { get; set; }

        [Column(Name = "EffectRadiusIndex1")]
        public int EffectRadiusIndex1 { get; set; }

        [Column(Name = "EffectRadiusIndex2")]
        public int EffectRadiusIndex2 { get; set; }

        [Column(Name = "EffectRadiusIndex3")]
        public int EffectRadiusIndex3 { get; set; }

        [Column(Name = "EffectApplyAuraName1")]
        public int EffectApplyAuraName1 { get; set; }

        [Column(Name = "EffectApplyAuraName2")]
        public int EffectApplyAuraName2 { get; set; }

        [Column(Name = "EffectApplyAuraName3")]
        public int EffectApplyAuraName3 { get; set; }

        [Column(Name = "EffectAmplitude1")]
        public int EffectAmplitude1 { get; set; }

        [Column(Name = "EffectAmplitude2")]
        public int EffectAmplitude2 { get; set; }

        [Column(Name = "EffectAmplitude3")]
        public int EffectAmplitude3 { get; set; }

        [Column(Name = "EffectMultipleValue1")]
        public float EffectMultipleValue1 { get; set; }

        [Column(Name = "EffectMultipleValue2")]
        public float EffectMultipleValue2 { get; set; }

        [Column(Name = "EffectMultipleValue3")]
        public float EffectMultipleValue3 { get; set; }

        [Column(Name = "EffectItemType1")]
        public int EffectItemType1 { get; set; }

        [Column(Name = "EffectItemType2")]
        public int EffectItemType2 { get; set; }

        [Column(Name = "EffectItemType3")]
        public int EffectItemType3 { get; set; }

        [Column(Name = "EffectMiscValue1")]
        public int EffectMiscValue1 { get; set; }

        [Column(Name = "EffectMiscValue2")]
        public int EffectMiscValue2 { get; set; }

        [Column(Name = "EffectMiscValue3")]
        public int EffectMiscValue3 { get; set; }

        [Column(Name = "EffectMiscValueB1")]
        public int EffectMiscValueB1 { get; set; }

        [Column(Name = "EffectMiscValueB2")]
        public int EffectMiscValueB2 { get; set; }

        [Column(Name = "EffectMiscValueB3")]
        public int EffectMiscValueB3 { get; set; }

        [Column(Name = "EffectTriggerSpell1")]
        public int EffectTriggerSpell1 { get; set; }

        [Column(Name = "EffectTriggerSpell2")]
        public int EffectTriggerSpell2 { get; set; }

        [Column(Name = "EffectTriggerSpell3")]
        public int EffectTriggerSpell3 { get; set; }

        [Column(Name = "EffectSpellClassMaskA1")]
        public int EffectSpellClassMaskA1 { get; set; }

        [Column(Name = "EffectSpellClassMaskA2")]
        public int EffectSpellClassMaskA2 { get; set; }

        [Column(Name = "EffectSpellClassMaskA3")]
        public int EffectSpellClassMaskA3 { get; set; }

        [Column(Name = "EffectSpellClassMaskB1")]
        public int EffectSpellClassMaskB1 { get; set; }

        [Column(Name = "EffectSpellClassMaskB2")]
        public int EffectSpellClassMaskB2 { get; set; }

        [Column(Name = "EffectSpellClassMaskB3")]
        public int EffectSpellClassMaskB3 { get; set; }

        [Column(Name = "EffectSpellClassMaskC1")]
        public int EffectSpellClassMaskC1 { get; set; }

        [Column(Name = "EffectSpellClassMaskC2")]
        public int EffectSpellClassMaskC2 { get; set; }

        [Column(Name = "EffectSpellClassMaskC3")]
        public int EffectSpellClassMaskC3 { get; set; }

        [Column(Name = "MaxTargetLevel")]
        public int MaxTargetLevel { get; set; }

        [Column(Name = "SpellFamilyName")]
        public int SpellFamilyName { get; set; }

        [Column(Name = "SpellFamilyFlags1")]
        public int SpellFamilyFlags1 { get; set; }

        [Column(Name = "SpellFamilyFlags2")]
        public int SpellFamilyFlags2 { get; set; }

        [Column(Name = "SpellFamilyFlags3")]
        public int SpellFamilyFlags3 { get; set; }

        [Column(Name = "MaxAffectedTargets")]
        public int MaxAffectedTargets { get; set; }

        [Column(Name = "DmgClass")]
        public int DmgClass { get; set; }

        [Column(Name = "PreventionType")]
        public int PreventionType { get; set; }

        [Column(Name = "DmgMultiplier1")]
        public float DmgMultiplier1 { get; set; }

        [Column(Name = "DmgMultiplier2")]
        public float DmgMultiplier2 { get; set; }

        [Column(Name = "DmgMultiplier3")]
        public float DmgMultiplier3 { get; set; }

        [Column(Name = "AreaGroupId")]
        public int AreaGroupId { get; set; }

        [Column(Name = "SchoolMask")]
        public int SchoolMask { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "spell_enchant_proc_data")]
    public class spell_enchant_proc_data
    {
        [Column(Name = "EnchantID")]
        public int EnchantID { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "ProcsPerMinute")]
        public float ProcsPerMinute { get; set; }

        [Column(Name = "HitMask")]
        public int HitMask { get; set; }

        [Column(Name = "AttributesMask")]
        public int AttributesMask { get; set; }
    }

    [Table(Name = "spell_group")]
    public class spell_group
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "spell_id")]
        public int spell_id { get; set; }
    }

    [Table(Name = "spell_group_stack_rules")]
    public class spell_group_stack_rules
    {
        [Column(Name = "group_id")]
        public int group_id { get; set; }

        [Column(Name = "stack_rule")]
        public int stack_rule { get; set; }
    }

    [Table(Name = "spell_learn_spell")]
    public class spell_learn_spell
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "SpellID")]
        public int SpellID { get; set; }

        [Column(Name = "Active")]
        public int Active { get; set; }
    }

    [Table(Name = "spell_linked_spell")]
    public class spell_linked_spell
    {
        [Column(Name = "spell_trigger")]
        public int spell_trigger { get; set; }

        [Column(Name = "spell_effect")]
        public int spell_effect { get; set; }

        [Column(Name = "type")]
        public int type { get; set; }

        [Column(Name = "comment")]
        public string comment { get; set; }
    }

    [Table(Name = "spell_loot_template")]
    public class spell_loot_template
    {
        [Column(Name = "Entry")]
        public int Entry { get; set; }

        [Column(Name = "Item")]
        public int Item { get; set; }

        [Column(Name = "Reference")]
        public int Reference { get; set; }

        [Column(Name = "Chance")]
        public float Chance { get; set; }

        [Column(Name = "QuestRequired")]
        public bool QuestRequired { get; set; }

        [Column(Name = "LootMode")]
        public int LootMode { get; set; }

        [Column(Name = "GroupId")]
        public int GroupId { get; set; }

        [Column(Name = "MinCount")]
        public int MinCount { get; set; }

        [Column(Name = "MaxCount")]
        public int MaxCount { get; set; }

        [Column(Name = "Comment")]
        public string Comment { get; set; }
    }

    [Table(Name = "spell_ranks")]
    public class spell_ranks
    {
        [Column(Name = "first_spell_id")]
        public int first_spell_id { get; set; }

        [Column(Name = "spell_id")]
        public int spell_id { get; set; }

        [Column(Name = "rank")]
        public int rank { get; set; }
    }

    [Table(Name = "spell_required")]
    public class spell_required
    {
        [Column(Name = "spell_id")]
        public int spell_id { get; set; }

        [Column(Name = "req_spell")]
        public int req_spell { get; set; }
    }

    [Table(Name = "spell_target_position")]
    public class spell_target_position
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "EffectIndex")]
        public int EffectIndex { get; set; }

        [Column(Name = "MapID")]
        public int MapID { get; set; }

        [Column(Name = "PositionX")]
        public float PositionX { get; set; }

        [Column(Name = "PositionY")]
        public float PositionY { get; set; }

        [Column(Name = "PositionZ")]
        public float PositionZ { get; set; }

        [Column(Name = "Orientation")]
        public float Orientation { get; set; }

        [Column(Name = "VerifiedBuild")]
        public int VerifiedBuild { get; set; }
    }

    [Table(Name = "spell_threat")]
    public class spell_threat
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "flatMod")]
        public int flatMod { get; set; }

        [Column(Name = "pctMod")]
        public float pctMod { get; set; }

        [Column(Name = "apPctMod")]
        public float apPctMod { get; set; }
    }

    [Table(Name = "transports")]
    public class transports
    {
        [Column(Name = "guid")]
        internal int guid { get; set; }

        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "name")]
        internal string name { get; set; }

        [Column(Name = "ScriptName")]
        internal string ScriptName { get; set; }

        public string Name { get; set; } = "";

        public float From_X { get; set; } = 0;

        public float From_Y { get; set; } = 0;

        public float From_Z { get; set; } = 0;

        public ContinentId From_ContinentId { get; set; } = ContinentId.None;

        public Vector3 From_Position => new Vector3(this.From_X, this.From_Y, this.From_Z, "From_DbTransport");

        public float To_X { get; set; } = 0;

        public float To_Y { get; set; } = 0;

        public float To_Z { get; set; } = 0;

        public ContinentId To_ContinentId { get; set; } = ContinentId.None;

        public Vector3 To_Position => new Vector3(this.To_X, this.To_Y, this.To_Z, "To_DbTransport");
    }

    [Table(Name = "vehicle_accessory")]
    public class vehicle_accessory
    {
        [Column(Name = "guid")]
        public int guid { get; set; }

        [Column(Name = "accessory_entry")]
        public int accessory_entry { get; set; }

        [Column(Name = "seat_id")]
        public int seat_id { get; set; }

        [Column(Name = "minion")]
        public int minion { get; set; }

        [Column(Name = "description")]
        public string description { get; set; }

        [Column(Name = "summontype")]
        public int summontype { get; set; }

        [Column(Name = "summontimer")]
        public int summontimer { get; set; }
    }

    [Table(Name = "vehicle_template_accessory")]
    public class vehicle_template_accessory
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "accessory_entry")]
        public int accessory_entry { get; set; }

        [Column(Name = "seat_id")]
        public int seat_id { get; set; }

        [Column(Name = "minion")]
        public int minion { get; set; }

        [Column(Name = "description")]
        public string description { get; set; }

        [Column(Name = "summontype")]
        public int summontype { get; set; }

        [Column(Name = "summontimer")]
        public int summontimer { get; set; }
    }

    [Table(Name = "waypoint_data")]
    public class waypoint_data
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "point")]
        public int point { get; set; }

        [Column(Name = "position_x")]
        public float position_x { get; set; }

        [Column(Name = "position_y")]
        public float position_y { get; set; }

        [Column(Name = "position_z")]
        public float position_z { get; set; }

        [Column(Name = "orientation")]
        public float orientation { get; set; }

        [Column(Name = "delay")]
        public int delay { get; set; }

        [Column(Name = "move_type")]
        public int move_type { get; set; }

        [Column(Name = "action")]
        public int action { get; set; }

        [Column(Name = "action_chance")]
        public int action_chance { get; set; }

        [Column(Name = "wpguid")]
        public int wpguid { get; set; }
    }

    [Table(Name = "waypoint_scripts")]
    public class waypoint_scripts
    {
        [Column(Name = "id")]
        public int id { get; set; }

        [Column(Name = "delay")]
        public int delay { get; set; }

        [Column(Name = "command")]
        public int command { get; set; }

        [Column(Name = "datalong")]
        public int datalong { get; set; }

        [Column(Name = "datalong2")]
        public int datalong2 { get; set; }

        [Column(Name = "dataint")]
        public int dataint { get; set; }

        [Column(Name = "x")]
        public float x { get; set; }

        [Column(Name = "y")]
        public float y { get; set; }

        [Column(Name = "z")]
        public float z { get; set; }

        [Column(Name = "o")]
        public float o { get; set; }

        [Column(Name = "guid")]
        public int guid { get; set; }
    }

    [Table(Name = "waypoints")]
    public class waypoints
    {
        [Column(Name = "entry")]
        public int entry { get; set; }

        [Column(Name = "pointid")]
        public int pointid { get; set; }

        [Column(Name = "position_x")]
        public float position_x { get; set; }

        [Column(Name = "position_y")]
        public float position_y { get; set; }

        [Column(Name = "position_z")]
        public float position_z { get; set; }

        [Column(Name = "point_comment")]
        public string point_comment { get; set; }
    }

    [Table(Name = "areatrigger")]
    public class areatrigger
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "ContinentID")]
        public int ContinentID { get; set; }

        [Column(Name = "x")]
        public float x { get; set; }

        [Column(Name = "y")]
        public float y { get; set; }

        [Column(Name = "z")]
        public float z { get; set; }

        [Column(Name = "radius")]
        public float radius { get; set; }

        [Column(Name = "box_length")]
        public float box_length { get; set; }

        [Column(Name = "box_width")]
        public float box_width { get; set; }

        [Column(Name = "box_height")]
        public float box_height { get; set; }

        [Column(Name = "box_yaw")]
        public float box_yaw { get; set; }
    }

    [Table(Name = "dungeon_map")]
    public class dungeon_map
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapID")]
        public int mapID { get; set; }

        [Column(Name = "floorIndex")]
        public int floorIndex { get; set; }

        [Column(Name = "minX")]
        public float minX { get; set; }

        [Column(Name = "maxX")]
        public float maxX { get; set; }

        [Column(Name = "minY")]
        public float minY { get; set; }

        [Column(Name = "maxY")]
        public float maxY { get; set; }

        [Column(Name = "parentWorldMapID")]
        public int parentWorldMapID { get; set; }
    }

    [Table(Name = "dungeon_map_chunk")]
    public class dungeon_map_chunk
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapID")]
        public int mapID { get; set; }

        [Column(Name = "wmoGroupID")]
        public int wmoGroupID { get; set; }

        [Column(Name = "dungeonMapID")]
        public int dungeonMapID { get; set; }

        [Column(Name = "minZ")]
        public float minZ { get; set; }
    }

    [Table(Name = "map")]
    public class map
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "Directory")]
        public string Directory { get; set; }

        [Column(Name = "InstanceType")]
        public int InstanceType { get; set; }

        [Column(Name = "Flags")]
        public int Flags { get; set; }

        [Column(Name = "PVP")]
        public int PVP { get; set; }

        [Column(Name = "MapName_lang_enUS")]
        public string MapName_lang_enUS { get; set; }

        [Column(Name = "MapName_lang_enGB")]
        public string MapName_lang_enGB { get; set; }

        [Column(Name = "MapName_lang_koKR")]
        public string MapName_lang_koKR { get; set; }

        [Column(Name = "MapName_lang_frFR")]
        public string MapName_lang_frFR { get; set; }

        [Column(Name = "MapName_lang_deDE")]
        public string MapName_lang_deDE { get; set; }

        [Column(Name = "MapName_lang_enCN")]
        public string MapName_lang_enCN { get; set; }

        [Column(Name = "MapName_lang_zhCN")]
        public string MapName_lang_zhCN { get; set; }

        [Column(Name = "MapName_lang_enTW")]
        public string MapName_lang_enTW { get; set; }

        [Column(Name = "MapName_lang_zhTW")]
        public string MapName_lang_zhTW { get; set; }

        [Column(Name = "MapName_lang_esES")]
        public string MapName_lang_esES { get; set; }

        [Column(Name = "MapName_lang_esMX")]
        public string MapName_lang_esMX { get; set; }

        [Column(Name = "MapName_lang_ruRU")]
        public string MapName_lang_ruRU { get; set; }

        [Column(Name = "MapName_lang_ptPT")]
        public string MapName_lang_ptPT { get; set; }

        [Column(Name = "MapName_lang_ptBR")]
        public string MapName_lang_ptBR { get; set; }

        [Column(Name = "MapName_lang_itIT")]
        public string MapName_lang_itIT { get; set; }

        [Column(Name = "MapName_lang_Unk")]
        public string MapName_lang_Unk { get; set; }

        [Column(Name = "MapName_lang_Mask")]
        public int MapName_lang_Mask { get; set; }

        [Column(Name = "areaTableID")]
        public int areaTableID { get; set; }

        [Column(Name = "MapDescription0_lang_enUS")]
        public string MapDescription0_lang_enUS { get; set; }

        [Column(Name = "MapDescription0_lang_enGB")]
        public string MapDescription0_lang_enGB { get; set; }

        [Column(Name = "MapDescription0_lang_koKR")]
        public string MapDescription0_lang_koKR { get; set; }

        [Column(Name = "MapDescription0_lang_frFR")]
        public string MapDescription0_lang_frFR { get; set; }

        [Column(Name = "MapDescription0_lang_deDE")]
        public string MapDescription0_lang_deDE { get; set; }

        [Column(Name = "MapDescription0_lang_enCN")]
        public string MapDescription0_lang_enCN { get; set; }

        [Column(Name = "MapDescription0_lang_zhCN")]
        public string MapDescription0_lang_zhCN { get; set; }

        [Column(Name = "MapDescription0_lang_enTW")]
        public string MapDescription0_lang_enTW { get; set; }

        [Column(Name = "MapDescription0_lang_zhTW")]
        public string MapDescription0_lang_zhTW { get; set; }

        [Column(Name = "MapDescription0_lang_esES")]
        public string MapDescription0_lang_esES { get; set; }

        [Column(Name = "MapDescription0_lang_esMX")]
        public string MapDescription0_lang_esMX { get; set; }

        [Column(Name = "MapDescription0_lang_ruRU")]
        public string MapDescription0_lang_ruRU { get; set; }

        [Column(Name = "MapDescription0_lang_ptPT")]
        public string MapDescription0_lang_ptPT { get; set; }

        [Column(Name = "MapDescription0_lang_ptBR")]
        public string MapDescription0_lang_ptBR { get; set; }

        [Column(Name = "MapDescription0_lang_itIT")]
        public string MapDescription0_lang_itIT { get; set; }

        [Column(Name = "MapDescription0_lang_Unk")]
        public string MapDescription0_lang_Unk { get; set; }

        [Column(Name = "MapDescription0_lang_Mask")]
        public int MapDescription0_lang_Mask { get; set; }

        [Column(Name = "MapDescription1_lang_enUS")]
        public string MapDescription1_lang_enUS { get; set; }

        [Column(Name = "MapDescription1_lang_enGB")]
        public string MapDescription1_lang_enGB { get; set; }

        [Column(Name = "MapDescription1_lang_koKR")]
        public string MapDescription1_lang_koKR { get; set; }

        [Column(Name = "MapDescription1_lang_frFR")]
        public string MapDescription1_lang_frFR { get; set; }

        [Column(Name = "MapDescription1_lang_deDE")]
        public string MapDescription1_lang_deDE { get; set; }

        [Column(Name = "MapDescription1_lang_enCN")]
        public string MapDescription1_lang_enCN { get; set; }

        [Column(Name = "MapDescription1_lang_zhCN")]
        public string MapDescription1_lang_zhCN { get; set; }

        [Column(Name = "MapDescription1_lang_enTW")]
        public string MapDescription1_lang_enTW { get; set; }

        [Column(Name = "MapDescription1_lang_zhTW")]
        public string MapDescription1_lang_zhTW { get; set; }

        [Column(Name = "MapDescription1_lang_esES")]
        public string MapDescription1_lang_esES { get; set; }

        [Column(Name = "MapDescription1_lang_esMX")]
        public string MapDescription1_lang_esMX { get; set; }

        [Column(Name = "MapDescription1_lang_ruRU")]
        public string MapDescription1_lang_ruRU { get; set; }

        [Column(Name = "MapDescription1_lang_ptPT")]
        public string MapDescription1_lang_ptPT { get; set; }

        [Column(Name = "MapDescription1_lang_ptBR")]
        public string MapDescription1_lang_ptBR { get; set; }

        [Column(Name = "MapDescription1_lang_itIT")]
        public string MapDescription1_lang_itIT { get; set; }

        [Column(Name = "MapDescription1_lang_Unk")]
        public string MapDescription1_lang_Unk { get; set; }

        [Column(Name = "MapDescription1_lang_Mask")]
        public int MapDescription1_lang_Mask { get; set; }

        [Column(Name = "LoadingScreenID")]
        public int LoadingScreenID { get; set; }

        [Column(Name = "minimapIconScale")]
        public float minimapIconScale { get; set; }

        [Column(Name = "corpseMapID")]
        public int corpseMapID { get; set; }

        [Column(Name = "corpseX")]
        public float corpseX { get; set; }

        [Column(Name = "corpseY")]
        public float corpseY { get; set; }

        [Column(Name = "timeOfDayOverride")]
        public int timeOfDayOverride { get; set; }

        [Column(Name = "expansionID")]
        public int expansionID { get; set; }

        [Column(Name = "raidOffset")]
        public int raidOffset { get; set; }

        [Column(Name = "maxPlayers")]
        public int maxPlayers { get; set; }
    }

    [Table(Name = "spell")]
    public class spell
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "category")]
        public int category { get; set; }

        [Column(Name = "dispelType")]
        public int dispelType { get; set; }

        [Column(Name = "mechanic")]
        public int mechanic { get; set; }

        [Column(Name = "attributes")]
        public int attributes { get; set; }

        [Column(Name = "attributesEx")]
        public int attributesEx { get; set; }

        [Column(Name = "attributesExB")]
        public int attributesExB { get; set; }

        [Column(Name = "attributesExC")]
        public int attributesExC { get; set; }

        [Column(Name = "attributesExD")]
        public int attributesExD { get; set; }

        [Column(Name = "attributesExE")]
        public int attributesExE { get; set; }

        [Column(Name = "attributesExF")]
        public int attributesExF { get; set; }

        [Column(Name = "attributesExG")]
        public int attributesExG { get; set; }

        [Column(Name = "shapeshiftMask")]
        public int shapeshiftMask { get; set; }

        [Column(Name = "shapeshiftExclude")]
        public int shapeshiftExclude { get; set; }

        [Column(Name = "targets")]
        public int targets { get; set; }

        [Column(Name = "targetCreatureType")]
        public int targetCreatureType { get; set; }

        [Column(Name = "requiresSpellFocus")]
        public int requiresSpellFocus { get; set; }

        [Column(Name = "facingCasterFlags")]
        public int facingCasterFlags { get; set; }

        [Column(Name = "casterAuraState")]
        public int casterAuraState { get; set; }

        [Column(Name = "targetAuraState")]
        public int targetAuraState { get; set; }

        [Column(Name = "excludeCasterAuraState")]
        public int excludeCasterAuraState { get; set; }

        [Column(Name = "excludeTargetAuraState")]
        public int excludeTargetAuraState { get; set; }

        [Column(Name = "casterAuraSpell")]
        public int casterAuraSpell { get; set; }

        [Column(Name = "targetAuraSpell")]
        public int targetAuraSpell { get; set; }

        [Column(Name = "excludeCasterAuraSpell")]
        public int excludeCasterAuraSpell { get; set; }

        [Column(Name = "excludeTargetAuraSpell")]
        public int excludeTargetAuraSpell { get; set; }

        [Column(Name = "castingTimeIndex")]
        public int castingTimeIndex { get; set; }

        [Column(Name = "recoveryTime")]
        public int recoveryTime { get; set; }

        [Column(Name = "categoryRecoveryTime")]
        public int categoryRecoveryTime { get; set; }

        [Column(Name = "interruptFlags")]
        public int interruptFlags { get; set; }

        [Column(Name = "auraInterruptFlags")]
        public int auraInterruptFlags { get; set; }

        [Column(Name = "channelInterruptFlags")]
        public int channelInterruptFlags { get; set; }

        [Column(Name = "procTypeMask")]
        public int procTypeMask { get; set; }

        [Column(Name = "procChance")]
        public int procChance { get; set; }

        [Column(Name = "procCharges")]
        public int procCharges { get; set; }

        [Column(Name = "maxLevel")]
        public int maxLevel { get; set; }

        [Column(Name = "baseLevel")]
        public int baseLevel { get; set; }

        [Column(Name = "spellLevel")]
        public int spellLevel { get; set; }

        [Column(Name = "durationIndex")]
        public int durationIndex { get; set; }

        [Column(Name = "powerType")]
        public int powerType { get; set; }

        [Column(Name = "manaCost")]
        public int manaCost { get; set; }

        [Column(Name = "manaCostPerLevel")]
        public int manaCostPerLevel { get; set; }

        [Column(Name = "manaPerSecond")]
        public int manaPerSecond { get; set; }

        [Column(Name = "manaPerSecondPerLevel")]
        public int manaPerSecondPerLevel { get; set; }

        [Column(Name = "rangeIndex")]
        public int rangeIndex { get; set; }

        [Column(Name = "speed")]
        public float speed { get; set; }

        [Column(Name = "modalNextSpell")]
        public int modalNextSpell { get; set; }

        [Column(Name = "cumulativeAura")]
        public int cumulativeAura { get; set; }

        [Column(Name = "tote1")]
        public int tote1 { get; set; }

        [Column(Name = "tote2")]
        public int tote2 { get; set; }

        [Column(Name = "reagent_1")]
        public int reagent_1 { get; set; }

        [Column(Name = "reagent_2")]
        public int reagent_2 { get; set; }

        [Column(Name = "reagent_3")]
        public int reagent_3 { get; set; }

        [Column(Name = "reagent_4")]
        public int reagent_4 { get; set; }

        [Column(Name = "reagent_5")]
        public int reagent_5 { get; set; }

        [Column(Name = "reagent_6")]
        public int reagent_6 { get; set; }

        [Column(Name = "reagent_7")]
        public int reagent_7 { get; set; }

        [Column(Name = "reagent_8")]
        public int reagent_8 { get; set; }

        [Column(Name = "reagentCount_1")]
        public int reagentCount_1 { get; set; }

        [Column(Name = "reagentCount_2")]
        public int reagentCount_2 { get; set; }

        [Column(Name = "reagentCount_3")]
        public int reagentCount_3 { get; set; }

        [Column(Name = "reagentCount_4")]
        public int reagentCount_4 { get; set; }

        [Column(Name = "reagentCount_5")]
        public int reagentCount_5 { get; set; }

        [Column(Name = "reagentCount_6")]
        public int reagentCount_6 { get; set; }

        [Column(Name = "reagentCount_7")]
        public int reagentCount_7 { get; set; }

        [Column(Name = "reagentCount_8")]
        public int reagentCount_8 { get; set; }

        [Column(Name = "equippedItemClass")]
        public int equippedItemClass { get; set; }

        [Column(Name = "equippedItemSubclass")]
        public int equippedItemSubclass { get; set; }

        [Column(Name = "equippedItemInvTypes")]
        public int equippedItemInvTypes { get; set; }

        [Column(Name = "effect_1")]
        public int effect_1 { get; set; }

        [Column(Name = "effect_2")]
        public int effect_2 { get; set; }

        [Column(Name = "effect_3")]
        public int effect_3 { get; set; }

        [Column(Name = "effectDieSides_1")]
        public int effectDieSides_1 { get; set; }

        [Column(Name = "effectDieSides_2")]
        public int effectDieSides_2 { get; set; }

        [Column(Name = "effectDieSides_3")]
        public int effectDieSides_3 { get; set; }

        [Column(Name = "effectRealPointsPerLevel_1")]
        public float effectRealPointsPerLevel_1 { get; set; }

        [Column(Name = "effectRealPointsPerLevel_2")]
        public float effectRealPointsPerLevel_2 { get; set; }

        [Column(Name = "effectRealPointsPerLevel_3")]
        public float effectRealPointsPerLevel_3 { get; set; }

        [Column(Name = "effectBasePoints_1")]
        public int effectBasePoints_1 { get; set; }

        [Column(Name = "effectBasePoints_2")]
        public int effectBasePoints_2 { get; set; }

        [Column(Name = "effectBasePoints_3")]
        public int effectBasePoints_3 { get; set; }

        [Column(Name = "effectMechanic_1")]
        public int effectMechanic_1 { get; set; }

        [Column(Name = "effectMechanic_2")]
        public int effectMechanic_2 { get; set; }

        [Column(Name = "effectMechanic_3")]
        public int effectMechanic_3 { get; set; }

        [Column(Name = "implicitTargetA_1")]
        public int implicitTargetA_1 { get; set; }

        [Column(Name = "implicitTargetA_2")]
        public int implicitTargetA_2 { get; set; }

        [Column(Name = "implicitTargetA_3")]
        public int implicitTargetA_3 { get; set; }

        [Column(Name = "implicitTargetB_1")]
        public int implicitTargetB_1 { get; set; }

        [Column(Name = "implicitTargetB_2")]
        public int implicitTargetB_2 { get; set; }

        [Column(Name = "implicitTargetB_3")]
        public int implicitTargetB_3 { get; set; }

        [Column(Name = "effectRadiusIndex_1")]
        public int effectRadiusIndex_1 { get; set; }

        [Column(Name = "effectRadiusIndex_2")]
        public int effectRadiusIndex_2 { get; set; }

        [Column(Name = "effectRadiusIndex_3")]
        public int effectRadiusIndex_3 { get; set; }

        [Column(Name = "effectAura_1")]
        public int effectAura_1 { get; set; }

        [Column(Name = "effectAura_2")]
        public int effectAura_2 { get; set; }

        [Column(Name = "effectAura_3")]
        public int effectAura_3 { get; set; }

        [Column(Name = "effectAuraPeriod_1")]
        public int effectAuraPeriod_1 { get; set; }

        [Column(Name = "effectAuraPeriod_2")]
        public int effectAuraPeriod_2 { get; set; }

        [Column(Name = "effectAuraPeriod_3")]
        public int effectAuraPeriod_3 { get; set; }

        [Column(Name = "effectAmplitude_1")]
        public float effectAmplitude_1 { get; set; }

        [Column(Name = "effectAmplitude_2")]
        public float effectAmplitude_2 { get; set; }

        [Column(Name = "effectAmplitude_3")]
        public float effectAmplitude_3 { get; set; }

        [Column(Name = "effectChainTargets_1")]
        public int effectChainTargets_1 { get; set; }

        [Column(Name = "effectChainTargets_2")]
        public int effectChainTargets_2 { get; set; }

        [Column(Name = "effectChainTargets_3")]
        public int effectChainTargets_3 { get; set; }

        [Column(Name = "effectItemType_1")]
        public int effectItemType_1 { get; set; }

        [Column(Name = "effectItemType_2")]
        public int effectItemType_2 { get; set; }

        [Column(Name = "effectItemType_3")]
        public int effectItemType_3 { get; set; }

        [Column(Name = "effectMiscValue_1")]
        public int effectMiscValue_1 { get; set; }

        [Column(Name = "effectMiscValue_2")]
        public int effectMiscValue_2 { get; set; }

        [Column(Name = "effectMiscValue_3")]
        public int effectMiscValue_3 { get; set; }

        [Column(Name = "effectMiscValueB_1")]
        public int effectMiscValueB_1 { get; set; }

        [Column(Name = "effectMiscValueB_2")]
        public int effectMiscValueB_2 { get; set; }

        [Column(Name = "effectMiscValueB_3")]
        public int effectMiscValueB_3 { get; set; }

        [Column(Name = "effectTriggerSpell_1")]
        public int effectTriggerSpell_1 { get; set; }

        [Column(Name = "effectTriggerSpell_2")]
        public int effectTriggerSpell_2 { get; set; }

        [Column(Name = "effectTriggerSpell_3")]
        public int effectTriggerSpell_3 { get; set; }

        [Column(Name = "effectPointsPerCombo_1")]
        public float effectPointsPerCombo_1 { get; set; }

        [Column(Name = "effectPointsPerCombo_2")]
        public float effectPointsPerCombo_2 { get; set; }

        [Column(Name = "effectPointsPerCombo_3")]
        public float effectPointsPerCombo_3 { get; set; }

        [Column(Name = "effectSpellClassMaskA_1")]
        public int effectSpellClassMaskA_1 { get; set; }

        [Column(Name = "effectSpellClassMaskA_2")]
        public int effectSpellClassMaskA_2 { get; set; }

        [Column(Name = "effectSpellClassMaskA_3")]
        public int effectSpellClassMaskA_3 { get; set; }

        [Column(Name = "effectSpellClassMaskB_1")]
        public int effectSpellClassMaskB_1 { get; set; }

        [Column(Name = "effectSpellClassMaskB_2")]
        public int effectSpellClassMaskB_2 { get; set; }

        [Column(Name = "effectSpellClassMaskB_3")]
        public int effectSpellClassMaskB_3 { get; set; }

        [Column(Name = "effectSpellClassMaskC_1")]
        public int effectSpellClassMaskC_1 { get; set; }

        [Column(Name = "effectSpellClassMaskC_2")]
        public int effectSpellClassMaskC_2 { get; set; }

        [Column(Name = "effectSpellClassMaskC_3")]
        public int effectSpellClassMaskC_3 { get; set; }

        [Column(Name = "spellVisualID_1")]
        public int spellVisualID_1 { get; set; }

        [Column(Name = "spellVisualID_2")]
        public int spellVisualID_2 { get; set; }

        [Column(Name = "spellIconID")]
        public int spellIconID { get; set; }

        [Column(Name = "activeIconID")]
        public int activeIconID { get; set; }

        [Column(Name = "spellPriority")]
        public int spellPriority { get; set; }

        [Column(Name = "name_lang_1")]
        public string name_lang_1 { get; set; }

        [Column(Name = "name_lang_2")]
        public string name_lang_2 { get; set; }

        [Column(Name = "name_lang_3")]
        public string name_lang_3 { get; set; }

        [Column(Name = "name_lang_4")]
        public string name_lang_4 { get; set; }

        [Column(Name = "name_lang_5")]
        public string name_lang_5 { get; set; }

        [Column(Name = "name_lang_6")]
        public string name_lang_6 { get; set; }

        [Column(Name = "name_lang_7")]
        public string name_lang_7 { get; set; }

        [Column(Name = "name_lang_8")]
        public string name_lang_8 { get; set; }

        [Column(Name = "name_lang_9")]
        public string name_lang_9 { get; set; }

        [Column(Name = "name_lang_10")]
        public string name_lang_10 { get; set; }

        [Column(Name = "name_lang_11")]
        public string name_lang_11 { get; set; }

        [Column(Name = "name_lang_12")]
        public string name_lang_12 { get; set; }

        [Column(Name = "name_lang_13")]
        public string name_lang_13 { get; set; }

        [Column(Name = "name_lang_14")]
        public string name_lang_14 { get; set; }

        [Column(Name = "name_lang_15")]
        public string name_lang_15 { get; set; }

        [Column(Name = "name_lang_16")]
        public string name_lang_16 { get; set; }

        [Column(Name = "name_flag")]
        public int name_flag { get; set; }

        [Column(Name = "nameSubtext_lang_1")]
        public string nameSubtext_lang_1 { get; set; }

        [Column(Name = "nameSubtext_lang_2")]
        public string nameSubtext_lang_2 { get; set; }

        [Column(Name = "nameSubtext_lang_3")]
        public string nameSubtext_lang_3 { get; set; }

        [Column(Name = "nameSubtext_lang_4")]
        public string nameSubtext_lang_4 { get; set; }

        [Column(Name = "nameSubtext_lang_5")]
        public string nameSubtext_lang_5 { get; set; }

        [Column(Name = "nameSubtext_lang_6")]
        public string nameSubtext_lang_6 { get; set; }

        [Column(Name = "nameSubtext_lang_7")]
        public string nameSubtext_lang_7 { get; set; }

        [Column(Name = "nameSubtext_lang_8")]
        public string nameSubtext_lang_8 { get; set; }

        [Column(Name = "nameSubtext_lang_9")]
        public string nameSubtext_lang_9 { get; set; }

        [Column(Name = "nameSubtext_lang_10")]
        public string nameSubtext_lang_10 { get; set; }

        [Column(Name = "nameSubtext_lang_11")]
        public string nameSubtext_lang_11 { get; set; }

        [Column(Name = "nameSubtext_lang_12")]
        public string nameSubtext_lang_12 { get; set; }

        [Column(Name = "nameSubtext_lang_13")]
        public string nameSubtext_lang_13 { get; set; }

        [Column(Name = "nameSubtext_lang_14")]
        public string nameSubtext_lang_14 { get; set; }

        [Column(Name = "nameSubtext_lang_15")]
        public string nameSubtext_lang_15 { get; set; }

        [Column(Name = "nameSubtext_lang_16")]
        public string nameSubtext_lang_16 { get; set; }

        [Column(Name = "nameSubtext_flag")]
        public int nameSubtext_flag { get; set; }

        [Column(Name = "description_lang_1")]
        public string description_lang_1 { get; set; }

        [Column(Name = "description_lang_2")]
        public string description_lang_2 { get; set; }

        [Column(Name = "description_lang_3")]
        public string description_lang_3 { get; set; }

        [Column(Name = "description_lang_4")]
        public string description_lang_4 { get; set; }

        [Column(Name = "description_lang_5")]
        public string description_lang_5 { get; set; }

        [Column(Name = "description_lang_6")]
        public string description_lang_6 { get; set; }

        [Column(Name = "description_lang_7")]
        public string description_lang_7 { get; set; }

        [Column(Name = "description_lang_8")]
        public string description_lang_8 { get; set; }

        [Column(Name = "description_lang_9")]
        public string description_lang_9 { get; set; }

        [Column(Name = "description_lang_10")]
        public string description_lang_10 { get; set; }

        [Column(Name = "description_lang_11")]
        public string description_lang_11 { get; set; }

        [Column(Name = "description_lang_12")]
        public string description_lang_12 { get; set; }

        [Column(Name = "description_lang_13")]
        public string description_lang_13 { get; set; }

        [Column(Name = "description_lang_14")]
        public string description_lang_14 { get; set; }

        [Column(Name = "description_lang_15")]
        public string description_lang_15 { get; set; }

        [Column(Name = "description_lang_16")]
        public string description_lang_16 { get; set; }

        [Column(Name = "description_flag")]
        public int description_flag { get; set; }

        [Column(Name = "auraDescription_lang_1")]
        public string auraDescription_lang_1 { get; set; }

        [Column(Name = "auraDescription_lang_2")]
        public string auraDescription_lang_2 { get; set; }

        [Column(Name = "auraDescription_lang_3")]
        public string auraDescription_lang_3 { get; set; }

        [Column(Name = "auraDescription_lang_4")]
        public string auraDescription_lang_4 { get; set; }

        [Column(Name = "auraDescription_lang_5")]
        public string auraDescription_lang_5 { get; set; }

        [Column(Name = "auraDescription_lang_6")]
        public string auraDescription_lang_6 { get; set; }

        [Column(Name = "auraDescription_lang_7")]
        public string auraDescription_lang_7 { get; set; }

        [Column(Name = "auraDescription_lang_8")]
        public string auraDescription_lang_8 { get; set; }

        [Column(Name = "auraDescription_lang_9")]
        public string auraDescription_lang_9 { get; set; }

        [Column(Name = "auraDescription_lang_10")]
        public string auraDescription_lang_10 { get; set; }

        [Column(Name = "auraDescription_lang_11")]
        public string auraDescription_lang_11 { get; set; }

        [Column(Name = "auraDescription_lang_12")]
        public string auraDescription_lang_12 { get; set; }

        [Column(Name = "auraDescription_lang_13")]
        public string auraDescription_lang_13 { get; set; }

        [Column(Name = "auraDescription_lang_14")]
        public string auraDescription_lang_14 { get; set; }

        [Column(Name = "auraDescription_lang_15")]
        public string auraDescription_lang_15 { get; set; }

        [Column(Name = "auraDescription_lang_16")]
        public string auraDescription_lang_16 { get; set; }

        [Column(Name = "auraDescription_flag")]
        public int auraDescription_flag { get; set; }

        [Column(Name = "manaCostPct")]
        public int manaCostPct { get; set; }

        [Column(Name = "startRecoveryCategory")]
        public int startRecoveryCategory { get; set; }

        [Column(Name = "startRecoveryTime")]
        public int startRecoveryTime { get; set; }

        [Column(Name = "maxTargetLevel")]
        public int maxTargetLevel { get; set; }

        [Column(Name = "spellClassSet")]
        public int spellClassSet { get; set; }

        [Column(Name = "spellClassMask_1")]
        public int spellClassMask_1 { get; set; }

        [Column(Name = "spellClassMask_2")]
        public int spellClassMask_2 { get; set; }

        [Column(Name = "spellClassMask_3")]
        public int spellClassMask_3 { get; set; }

        [Column(Name = "maxTargets")]
        public int maxTargets { get; set; }

        [Column(Name = "defenseType")]
        public int defenseType { get; set; }

        [Column(Name = "preventionType")]
        public int preventionType { get; set; }

        [Column(Name = "stanceBarOrder")]
        public int stanceBarOrder { get; set; }

        [Column(Name = "effectChainAmplitude_1")]
        public float effectChainAmplitude_1 { get; set; }

        [Column(Name = "effectChainAmplitude_2")]
        public float effectChainAmplitude_2 { get; set; }

        [Column(Name = "effectChainAmplitude_3")]
        public float effectChainAmplitude_3 { get; set; }

        [Column(Name = "minFactionID")]
        public int minFactionID { get; set; }

        [Column(Name = "minReputation")]
        public int minReputation { get; set; }

        [Column(Name = "requiredAuraVision")]
        public int requiredAuraVision { get; set; }

        [Column(Name = "requiredTotemCategoryID_1")]
        public int requiredTotemCategoryID_1 { get; set; }

        [Column(Name = "requiredTotemCategoryID_2")]
        public int requiredTotemCategoryID_2 { get; set; }

        [Column(Name = "requiredAreasID")]
        public int requiredAreasID { get; set; }

        [Column(Name = "schoolMask")]
        public int schoolMask { get; set; }

        [Column(Name = "runeCostID")]
        public int runeCostID { get; set; }

        [Column(Name = "spellMissileID")]
        public int spellMissileID { get; set; }

        [Column(Name = "powerDisplayID")]
        public int powerDisplayID { get; set; }

        [Column(Name = "unk1_1")]
        public float unk1_1 { get; set; }

        [Column(Name = "unk1_2")]
        public float unk1_2 { get; set; }

        [Column(Name = "unk1_3")]
        public float unk1_3 { get; set; }

        [Column(Name = "spellDescriptionVariableID")]
        public int spellDescriptionVariableID { get; set; }

        [Column(Name = "spellDifficultyID")]
        public int spellDifficultyID { get; set; }
    }

    [Table(Name = "spell_cast_times")]
    public class spell_cast_times
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "base_")]
        public int base_ { get; set; }

        [Column(Name = "perLevel")]
        public int perLevel { get; set; }

        [Column(Name = "minimum")]
        public int minimum { get; set; }
    }

    [Table(Name = "spell_duration")]
    public class spell_duration
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "duration")]
        public int duration { get; set; }

        [Column(Name = "durationPerLevel")]
        public int durationPerLevel { get; set; }

        [Column(Name = "maxDuration")]
        public int maxDuration { get; set; }
    }

    [Table(Name = "spell_focus_object")]
    public class spell_focus_object
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "name_lang_enUS")]
        public string name_lang_enUS { get; set; }

        [Column(Name = "name_lang_enGB")]
        public string name_lang_enGB { get; set; }

        [Column(Name = "name_lang_koKR")]
        public string name_lang_koKR { get; set; }

        [Column(Name = "name_lang_frFR")]
        public string name_lang_frFR { get; set; }

        [Column(Name = "name_lang_deDE")]
        public string name_lang_deDE { get; set; }

        [Column(Name = "name_lang_enCN")]
        public string name_lang_enCN { get; set; }

        [Column(Name = "name_lang_zhCN")]
        public string name_lang_zhCN { get; set; }

        [Column(Name = "name_lang_enTW")]
        public string name_lang_enTW { get; set; }

        [Column(Name = "name_lang_zhTW")]
        public string name_lang_zhTW { get; set; }

        [Column(Name = "name_lang_esES")]
        public string name_lang_esES { get; set; }

        [Column(Name = "name_lang_esMX")]
        public string name_lang_esMX { get; set; }

        [Column(Name = "name_lang_ruRU")]
        public string name_lang_ruRU { get; set; }

        [Column(Name = "name_lang_ptPT")]
        public string name_lang_ptPT { get; set; }

        [Column(Name = "name_lang_ptBR")]
        public string name_lang_ptBR { get; set; }

        [Column(Name = "name_lang_itIT")]
        public string name_lang_itIT { get; set; }

        [Column(Name = "name_lang_Unk")]
        public string name_lang_Unk { get; set; }

        [Column(Name = "name_lang_Mask")]
        public int name_lang_Mask { get; set; }
    }

    [Table(Name = "spell_icon")]
    public class spell_icon
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "textureFilename")]
        public string textureFilename { get; set; }
    }

    [Table(Name = "talent")]
    public class talent
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "tabID")]
        public int tabID { get; set; }

        [Column(Name = "tierID")]
        public int tierID { get; set; }

        [Column(Name = "columnIndex")]
        public int columnIndex { get; set; }

        [Column(Name = "spellRank")]
        public int spellRank { get; set; }

        [Column(Name = "spellRank_1")]
        public int spellRank_1 { get; set; }

        [Column(Name = "spellRank_2")]
        public int spellRank_2 { get; set; }

        [Column(Name = "spellRank_3")]
        public int spellRank_3 { get; set; }

        [Column(Name = "spellRank_4")]
        public int spellRank_4 { get; set; }

        [Column(Name = "spellRank_5")]
        public int spellRank_5 { get; set; }

        [Column(Name = "spellRank_6")]
        public int spellRank_6 { get; set; }

        [Column(Name = "spellRank_7")]
        public int spellRank_7 { get; set; }

        [Column(Name = "spellRank_8")]
        public int spellRank_8 { get; set; }

        [Column(Name = "prereqTalent")]
        public int prereqTalent { get; set; }

        [Column(Name = "prereqTalent_1")]
        public int prereqTalent_1 { get; set; }

        [Column(Name = "prereqTalent_2")]
        public int prereqTalent_2 { get; set; }

        [Column(Name = "prereqRank")]
        public int prereqRank { get; set; }

        [Column(Name = "prereqRank_1")]
        public int prereqRank_1 { get; set; }

        [Column(Name = "prereqRank_2")]
        public int prereqRank_2 { get; set; }

        [Column(Name = "flags")]
        public int flags { get; set; }

        [Column(Name = "requiredSpellID")]
        public int requiredSpellID { get; set; }

        [Column(Name = "categoryMask")]
        public int categoryMask { get; set; }

        [Column(Name = "categoryMask_1")]
        public int categoryMask_1 { get; set; }
    }

    [Table(Name = "talent_tab")]
    public class talent_tab
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "spellIconID")]
        public int spellIconID { get; set; }

        [Column(Name = "raceMask")]
        public int raceMask { get; set; }

        [Column(Name = "classMask")]
        public int classMask { get; set; }

        [Column(Name = "petTalentMask")]
        public int petTalentMask { get; set; }

        [Column(Name = "orderIndex")]
        public int orderIndex { get; set; }

        [Column(Name = "backgroundFile")]
        public string backgroundFile { get; set; }
    }

    [Table(Name = "taxi_nodes")]
    public class taxi_nodes
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "ContinentID")]
        public int ContinentID { get; set; }

        [Column(Name = "X")]
        public float X { get; set; }

        [Column(Name = "Y")]
        public float Y { get; set; }

        [Column(Name = "Z")]
        public float Z { get; set; }

        [Column(Name = "MountCreatureID")]
        public int MountCreatureID { get; set; }

        [Column(Name = "MountCreatureID_1")]
        public int MountCreatureID_1 { get; set; }
    }

    [Table(Name = "taxi_path")]
    public class taxi_path
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "FromTaxiNode")]
        public int FromTaxiNode { get; set; }

        [Column(Name = "ToTaxiNode")]
        public int ToTaxiNode { get; set; }

        [Column(Name = "Cost")]
        public int Cost { get; set; }
    }

    [Table(Name = "world_map_area")]
    public class world_map_area
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapID")]
        public int mapID { get; set; }

        [Column(Name = "areaID")]
        public int areaID { get; set; }

        [Column(Name = "areaName")]
        public string areaName { get; set; }

        [Column(Name = "locLeft")]
        public float locLeft { get; set; }

        [Column(Name = "locRight")]
        public float locRight { get; set; }

        [Column(Name = "locTop")]
        public float locTop { get; set; }

        [Column(Name = "locBottom")]
        public float locBottom { get; set; }

        [Column(Name = "displayMapID")]
        public int displayMapID { get; set; }

        [Column(Name = "defaultDungeonFloor")]
        public int defaultDungeonFloor { get; set; }

        [Column(Name = "parentWorldMapID")]
        public int parentWorldMapID { get; set; }
    }

    [Table(Name = "world_map_continent")]
    public class world_map_continent
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapID")]
        public int mapID { get; set; }

        [Column(Name = "leftBoundary")]
        public int leftBoundary { get; set; }

        [Column(Name = "rightBoundary")]
        public int rightBoundary { get; set; }

        [Column(Name = "topBoundary")]
        public int topBoundary { get; set; }

        [Column(Name = "bottomBoundary")]
        public int bottomBoundary { get; set; }

        [Column(Name = "continentOffsetX")]
        public float continentOffsetX { get; set; }

        [Column(Name = "continentOffsetY")]
        public float continentOffsetY { get; set; }

        [Column(Name = "scale")]
        public float scale { get; set; }

        [Column(Name = "taxiMinX")]
        public float taxiMinX { get; set; }

        [Column(Name = "taxiMinY")]
        public float taxiMinY { get; set; }

        [Column(Name = "taxiMaxX")]
        public float taxiMaxX { get; set; }

        [Column(Name = "taxiMaxY")]
        public float taxiMaxY { get; set; }

        [Column(Name = "worldMapID")]
        public int worldMapID { get; set; }
    }

    [Table(Name = "world_map_overlay")]
    public class world_map_overlay
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapAreaID")]
        public int mapAreaID { get; set; }

        [Column(Name = "areaID_1")]
        public int areaID_1 { get; set; }

        [Column(Name = "areaID_2")]
        public int areaID_2 { get; set; }

        [Column(Name = "areaID_3")]
        public int areaID_3 { get; set; }

        [Column(Name = "areaID_4")]
        public int areaID_4 { get; set; }

        [Column(Name = "mapPointX")]
        public int mapPointX { get; set; }

        [Column(Name = "mapPointY")]
        public int mapPointY { get; set; }

        [Column(Name = "textureName")]
        public string textureName { get; set; }

        [Column(Name = "textureWidth")]
        public int textureWidth { get; set; }

        [Column(Name = "textureHeight")]
        public int textureHeight { get; set; }

        [Column(Name = "offsetX")]
        public int offsetX { get; set; }

        [Column(Name = "offsetY")]
        public int offsetY { get; set; }

        [Column(Name = "hitRectTop")]
        public int hitRectTop { get; set; }

        [Column(Name = "hitRectLeft")]
        public int hitRectLeft { get; set; }

        [Column(Name = "hitRectBottom")]
        public int hitRectBottom { get; set; }

        [Column(Name = "hitRectRight")]
        public int hitRectRight { get; set; }
    }

    [Table(Name = "world_map_transforms")]
    public class world_map_transforms
    {
        [Column(Name = "ID")]
        public int ID { get; set; }

        [Column(Name = "mapID")]
        public int mapID { get; set; }

        [Column(Name = "regionMinX")]
        public float regionMinX { get; set; }

        [Column(Name = "regionMinY")]
        public float regionMinY { get; set; }

        [Column(Name = "regionMaxX")]
        public float regionMaxX { get; set; }

        [Column(Name = "regionMaxY")]
        public float regionMaxY { get; set; }

        [Column(Name = "newMapID")]
        public int newMapID { get; set; }

        [Column(Name = "regionOffsetX")]
        public float regionOffsetX { get; set; }

        [Column(Name = "regionOffsetY")]
        public float regionOffsetY { get; set; }

        [Column(Name = "newDungeonMapID")]
        public int newDungeonMapID { get; set; }
    }
}









