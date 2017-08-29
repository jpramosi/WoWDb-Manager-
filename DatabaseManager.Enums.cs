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


namespace DatabaseManager.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum MovementType
    {
        Stay = 0,
        SpawnRandomMovement = 1,
        Waypoint = 2,
    }
    
    /// <summary>
    /// Id 0
    /// </summary>
    public enum Consumable
    {
        All = -1,
        Consumable,
        Potion,
        Elixir,
        Flask,
        Scroll,
        FoodDrink,
        ItemEnhancement,
        Bandage,
        Other,
    }

    /// <summary>
    /// Id 1
    /// </summary>
    public enum Container
    {
        All = -1,
        Bag,
        SoulBag,
        HerbBag,
        EnchantingBag,
        EngineeringBag,
        GemBag,
        MiningBag,
        LeatherworkingBag,
        InscriptionBag,
    }

    /// <summary>
    /// <para>Id 2</para>
    /// <para>Exotic: special</para>
    /// <para>Miscellaneous: Blacksmith Hammer, Mining Pick, etc.</para>
    /// </summary>
    public enum Weapon
    {
        All = -1,
        Axe1Hand,
        Axe2Hand,
        Bow,
        Gun,
        Mace1Hand,
        Mace2Hand,
        Polearm,
        Sword1Hand,
        Sword2Hand,
        Staff = 10,
        Exotic1,
        Exotic2,
        Fist,
        Miscellaneous,
        Dagger,
        Thrown,
        Spear,
        Crossbow,
        Wand,
        FishingPole,
    }

    /// <summary>
    /// Id 3
    /// </summary>
    public enum Gem
    {
        All = -1,
        Red,
        Blue,
        Yellow,
        Purple,
        Green,
        Orange,
        Meta,
        Simple,
        Prismatic,
    }

    /// <summary>
    /// Id 4
    /// </summary>
    public enum Armor
    {
        All = -1,
        Miscellaneous,
        Cloth,
        Leather,
        Mail,
        Plate,
        Shield = 6,
        Libram,
        Idol,
        Totem,
        Sigil,
    }

    /// <summary>
    /// Id 5
    /// </summary>
    public enum Reagent
    {
        All
    }

    /// <summary>
    /// Id 6
    /// </summary>
    public enum Projectile
    {
        All = -1,
        Arrow = 2,
        Bullet,
        Thrown,
    }

    /// <summary>
    /// Id 7
    /// </summary>
    public enum TradeGoods
    {
        All = -1,
        TradeGoods,
        Parts,
        Explosives,
        Devices,
        Jewelcrafting,
        Cloth,
        Leather,
        MetalStone,
        Meat,
        Herb,
        Elemental,
        Other,
        Enchanting,
        Materials,
        ArmorEnchantment,
        WeaponEnchantment,
    }

    /// <summary>
    /// Id 9
    /// </summary>
    public enum Recipe
    {
        All = -1,
        Book,
        Leatherworking,
        Tailoring,
        Engineering,
        Blacksmithing,
        Cooking,
        Alchemy,
        FirstAid,
        Enchanting,
        Fishing,
        Jewelcrafting,
    }

    /// <summary>
    /// Id 11
    /// </summary>
    public enum Quiver
    {
        All = -1,
        Quiver = 2,
        AmmoPouch,
    }

    /// <summary>
    /// Id 12
    /// </summary>
    public enum Quest
    {
        All
    }

    /// <summary>
    /// Id 13
    /// </summary>
    public enum Key
    {
        All = -1,
        Key,
        Lockpick,
    }

    /// <summary>
    /// Id 15
    /// </summary>
    public enum Miscellaneous
    {
        All = -1,
        Junk,
        Reagent,
        Pet,
        Holiday,
        Other,
        Mount
    }

    /// <summary>
    /// Id 16
    /// </summary>
    public enum Glyph
    {
        All = -1,
        Warrior,
        Paladin,
        Hunter,
        Rogue,
        Priest,
        DeathKnight,
        Shaman,
        Mage,
        Warlock,
        Monk,
        Druid,
        DemonHunter,
    }
    
    /// <summary>
    /// result = 2^(Mechanics-1)
    /// </summary>
    public enum Mechanics
    {
        MECHANIC_NONE = 0,
        MECHANIC_CHARM = 1,
        MECHANIC_DISORIENTED = 2,
        MECHANIC_DISARM = 3,
        MECHANIC_DISTRACT = 4,
        MECHANIC_FEAR = 5,
        MECHANIC_GRIP = 6,
        MECHANIC_ROOT = 7,
        MECHANIC_SLOW_ATTACK = 8,
        MECHANIC_SILENCE = 9,
        MECHANIC_SLEEP = 10,
        MECHANIC_SNARE = 11,
        MECHANIC_STUN = 12,
        MECHANIC_FREEZE = 13,
        MECHANIC_KNOCKOUT = 14,
        MECHANIC_BLEED = 15,
        MECHANIC_BANDAGE = 16,
        MECHANIC_POLYMORPH = 17,
        MECHANIC_BANISH = 18,
        MECHANIC_SHIELD = 19,
        MECHANIC_SHACKLE = 20,
        MECHANIC_MOUNT = 21,
        MECHANIC_INFECTED = 22,
        MECHANIC_TURN = 23,
        MECHANIC_HORROR = 24,
        MECHANIC_INVULNERABILITY = 25,
        MECHANIC_INTERRUPT = 26,
        MECHANIC_DAZE = 27,
        MECHANIC_DISCOVERY = 28,
        MECHANIC_IMMUNE_SHIELD = 29, // Divine (Blessing) Shield/Protection and Ice Block
        MECHANIC_SAPPED = 30,
        MECHANIC_ENRAGED = 31
    };

    /// <summary>
    /// 
    /// </summary>
    public enum ReactionType
    {
        None,
        Neutral,
        Hostile,
        Friendly,
    }
    
    /// <summary>
    /// <para>Operator.And: if a table-object contains condition1 and condtion2 at the same time</para>
    /// <para>Operator.Or: if a table-object contains condition1 or condtion2 at the same time</para>
    /// <para>Operator.Equal: if a table-object contains only the result of condition1 and condition2 at the same time</para>
    /// </summary>
    public enum Operator
    {
        And = 0,
        Or = 1,
        Equal = 2,
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ContainedIn
    {
        Loot = 0,
        Merchant = 1
    }

    /// <summary>
    /// 
    /// </summary>
    public enum Table
    {
        All,
        Creature,
        GameOjbect,
        Item,
    }
    
    /// <summary>
    /// 
    /// </summary>
    public enum ItemQuality
    {
        All = -1,
        Poor,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Artifact,
        Heirloom,
    }

    /// <summary>
    /// 
    /// </summary>
    [Flags]
    public enum RaceFlags
    {
        Human              = 1,
        Orc                = 2,
        Dwarf              = 4,
        Nightelf           = 8,
        Undead             = 16,
        Tauren             = 32,
        Gnome              = 64,
        Troll              = 128,
        Bloodelf           = 512,
        Draenei            = 1024,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum QuestMark
    {
        All,
        PickUp,
        TurnIn
    }

    /// <summary>
    /// 
    /// </summary>
    public enum QuestData
    {
        Data_areatrigger,
        Data_quest_template_addon,
        PickUp,
        TurnIn,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum QuestFlags
    {
        QUEST_FLAGS_NONE                    = 0x00000000,
        QUEST_FLAGS_STAY_ALIVE              = 0x00000001,   // Not used currently
        QUEST_FLAGS_PARTY_ACCEPT            = 0x00000002,   // Not used currently. If player in party, all players that can accept this quest will receive confirmation box to accept quest CMSG_QUEST_CONFIRM_ACCEPT/SMSG_QUEST_CONFIRM_ACCEPT
        QUEST_FLAGS_EXPLORATION             = 0x00000004,   // Not used currently
        QUEST_FLAGS_SHARABLE                = 0x00000008,   // Can be shared: Player::CanShareQuest()
        QUEST_FLAGS_HAS_CONDITION           = 0x00000010,   // Not used currently
        QUEST_FLAGS_HIDE_REWARD_POI         = 0x00000020,   // Not used currently: Unsure of content
        QUEST_FLAGS_RAID                    = 0x00000040,   // Can be completed while in raid
        QUEST_FLAGS_TBC                     = 0x00000080,   // Not used currently: Available if TBC expansion enabled only
        QUEST_FLAGS_NO_MONEY_FROM_XP        = 0x00000100,   // Not used currently: Experience is not converted to gold at max level
        QUEST_FLAGS_HIDDEN_REWARDS          = 0x00000200,   // Items and money rewarded only sent in SMSG_QUESTGIVER_OFFER_REWARD (not in SMSG_QUESTGIVER_QUEST_DETAILS or in client quest log(SMSG_QUEST_QUERY_RESPONSE))
        QUEST_FLAGS_TRACKING                = 0x00000400,   // These quests are automatically rewarded on quest complete and they will never appear in quest log client side.
        QUEST_FLAGS_DEPRECATE_REPUTATION    = 0x00000800,   // Not used currently
        QUEST_FLAGS_DAILY                   = 0x00001000,   // Used to know quest is Daily one
        QUEST_FLAGS_FLAGS_PVP               = 0x00002000,   // Having this quest in log forces PvP flag
        QUEST_FLAGS_UNAVAILABLE             = 0x00004000,   // Used on quests that are not generically available
        QUEST_FLAGS_WEEKLY                  = 0x00008000,
        QUEST_FLAGS_AUTOCOMPLETE            = 0x00010000,   // Quests with this flag player submit automatically by special button in player gui
        QUEST_FLAGS_DISPLAY_ITEM_IN_TRACKER = 0x00020000,   // Displays usable item in quest tracker
        QUEST_FLAGS_OBJ_TEXT                = 0x00040000,   // use Objective text as Complete text
        QUEST_FLAGS_AUTO_ACCEPT             = 0x00080000,   // The client recognizes this flag as auto-accept. However, NONE of the current quests (3.3.5a) have this flag. Maybe blizz used to use it, or will use it in the future.
        QUEST_FLAGS_UNK1                    = 0x00100000,   //
        QUEST_FLAGS_AUTO_TAKE               = 0x00200000,   // Automatically suggestion of accepting quest. Not from npc.
    }

    /// <summary>
    /// 
    /// </summary>
    public enum QuestState
    {
        All = -1,
        EnabledAutocomplete = 0,
        NotImplemented = 1,
        EnabledNoAutocomplete = 2,
        WorldQuest = 3,
    }

    public enum NBool
    {
        Ignore,
        True,
        False,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum QuestInfo
    {
        All = -1,
        QUEST_INFO_GROUP               = 1,
        QUEST_INFO_CLASS               = 21,
        QUEST_INFO_PVP                 = 41,
        QUEST_INFO_RAID                = 62,
        QUEST_INFO_DUNGEON             = 81,
        QUEST_INFO_WORLD_EVENT         = 82,
        QUEST_INFO_LEGENDARY           = 83,
        QUEST_INFO_ESCORT              = 84,
        QUEST_INFO_HEROIC              = 85,
        QUEST_INFO_RAID_10             = 88,
        QUEST_INFO_RAID_25             = 89,
        QUEST_INFO_SCENARIO            = 98,
        QUEST_INFO_ACCOUNT             = 102,
        QUEST_INFO_SIDE_QUEST          = 104
    };

    /// <summary>
    /// 
    /// </summary>
    public enum Train : uint
    {
        All = 0,
        Class_Warrior = 1,
        Class_Paladin = 2,
        Class_Hunter = 3,
        Class_Rogue = 4,
        Class_Priest = 5,
        Class_DeathKnight = 6,
        Class_Shaman = 7,
        Class_Mage = 8,
        Class_Warlock = 9,
        Class_Monk = 10,
        Class_Druid = 11,
        Class_DemonHunter = 12,
        Primary_Alchemy = 21,
        Primary_Blacksmithing = 22,
        Primary_Enchanting = 23,
        Primary_Engineering = 24,
        Primary_Herbalism = 25,
        Primary_Inscription = 26,
        Primary_Jewelcrafting = 27,
        Primary_Leatherworking = 28,
        Primary_Mining = 29,
        Primary_Skinning = 30,
        Primary_Tailoring = 31,
        Secondary_Archaeology = 32,
        Secondary_Cooking = 33,
        Secondary_FirstAid = 34,
        Secondary_Fishing = 35,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum GameObjectType : uint
    {
        None = 99,
        Door = 0,
        Button = 1,
        Questgiver = 2,
        Chest = 3,
        Binder = 4,
        Generic = 5,
        Trap = 6,
        SpellFocus = 7,
        Chair = 8,
        Text = 9,
        Goober = 10,
        Transport = 11,
        AreaDamage = 12,
        Camera = 13,
        MapObject = 14,
        MoTransport = 15,
        DuelArbiter = 16,
        FishingNode = 17,
        Ritual = 18,
        Mailbox = 19,
        AuctionHouse = 20,
        GuardPost = 21,
        SpellCaster = 22,
        MeetingStone = 23,
        FlagStand = 24,
        FishingHole = 25,
        FlagDrop = 26,
        MiniGame = 27,
        LotteryKiosk = 28,
        CapturePoint = 29,
        AuraGenerator = 30,
        DungeonDifficulty = 31,
        DestructiveBuilding = 32,
        GuildBank = 34,
        TrapDoor = 35,
        FlagHorde = 36,
        FlagAlliance = 37,
    }
}









