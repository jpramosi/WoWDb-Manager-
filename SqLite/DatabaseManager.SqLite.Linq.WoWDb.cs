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
using DatabaseManager.Tables;
using LinqToDB;
using LinqToDB.Data;


namespace DatabaseManager.SqLite.Linq
{
    /// <summary>
    /// Internal usage
    /// </summary>
    public class WoWDb : DataConnection
    {
        public ITable<access_requirement> access_requirement => GetTable<access_requirement>();

        public ITable<areatrigger_involvedrelation> areatrigger_involvedrelation => GetTable<areatrigger_involvedrelation>();

        public ITable<areatrigger_scripts> areatrigger_scripts => GetTable<areatrigger_scripts>();

        public ITable<areatrigger_teleport> areatrigger_teleport => GetTable<areatrigger_teleport>();

        public ITable<battleground_template> battleground_template => GetTable<battleground_template>();

        public ITable<battlemaster_entry> battlemaster_entry => GetTable<battlemaster_entry>();

        public ITable<creature> creature => GetTable<creature>();

        public ITable<creature_addon> creature_addon => GetTable<creature_addon>();

        public ITable<creature_classlevelstats> creature_classlevelstats => GetTable<creature_classlevelstats>();

        public ITable<creature_loot_template> creature_loot_template => GetTable<creature_loot_template>();

        public ITable<creature_questender> creature_questender => GetTable<creature_questender>();

        public ITable<creature_questitem> creature_questitem => GetTable<creature_questitem>();

        public ITable<creature_queststarter> creature_queststarter => GetTable<creature_queststarter>();

        public ITable<creature_template> creature_template => GetTable<creature_template>();

        public ITable<creature_template_addon> creature_template_addon => GetTable<creature_template_addon>();

        public ITable<disenchant_loot_template> disenchant_loot_template => GetTable<disenchant_loot_template>();

        public ITable<fishing_loot_template> fishing_loot_template => GetTable<fishing_loot_template>();

        public ITable<gameobject> gameobject => GetTable<gameobject>();

        public ITable<gameobject_addon> gameobject_addon => GetTable<gameobject_addon>();

        public ITable<gameobject_loot_template> gameobject_loot_template => GetTable<gameobject_loot_template>();

        public ITable<gameobject_questender> gameobject_questender => GetTable<gameobject_questender>();

        public ITable<gameobject_questitem> gameobject_questitem => GetTable<gameobject_questitem>();

        public ITable<gameobject_queststarter> gameobject_queststarter => GetTable<gameobject_queststarter>();

        public ITable<gameobject_template> gameobject_template => GetTable<gameobject_template>();

        public ITable<gameobject_template_addon> gameobject_template_addon => GetTable<gameobject_template_addon>();

        public ITable<graveyard_zone> graveyard_zone => GetTable<graveyard_zone>();

        public ITable<item_enchantment_template> item_enchantment_template => GetTable<item_enchantment_template>();

        public ITable<item_loot_template> item_loot_template => GetTable<item_loot_template>();

        public ITable<item_template> item_template => GetTable<item_template>();

        public ITable<milling_loot_template> milling_loot_template => GetTable<milling_loot_template>();
        
        public ITable<npc_trainer> npc_trainer => GetTable<npc_trainer>();

        public ITable<npc_vendor> npc_vendor => GetTable<npc_vendor>();

        public ITable<pickpocketing_loot_template> pickpocketing_loot_template => GetTable<pickpocketing_loot_template>();
        
        public ITable<player_xp_for_level> player_xp_for_level => GetTable<player_xp_for_level>();

        public ITable<playercreateinfo> playercreateinfo => GetTable<playercreateinfo>();

        public ITable<points_of_interest> points_of_interest => GetTable<points_of_interest>();
        
        public ITable<quest_offer_reward> quest_offer_reward => GetTable<quest_offer_reward>();

        public ITable<quest_poi> quest_poi => GetTable<quest_poi>();

        public ITable<quest_poi_points> quest_poi_points => GetTable<quest_poi_points>();

        public ITable<quest_request_items> quest_request_items => GetTable<quest_request_items>();

        public ITable<quest_template> quest_template => GetTable<quest_template>();

        public ITable<quest_template_addon> quest_template_addon => GetTable<quest_template_addon>();

        public ITable<reference_loot_template> reference_loot_template => GetTable<reference_loot_template>();

        public ITable<script_spline_chain_meta> script_spline_chain_meta => GetTable<script_spline_chain_meta>();

        public ITable<script_spline_chain_waypoints> script_spline_chain_waypoints => GetTable<script_spline_chain_waypoints>();

        public ITable<script_waypoint> script_waypoint => GetTable<script_waypoint>();

        public ITable<skill_fishing_base_level> skill_fishing_base_level => GetTable<skill_fishing_base_level>();

        public ITable<skinning_loot_template> skinning_loot_template => GetTable<skinning_loot_template>();

        public ITable<spell_area> spell_area => GetTable<spell_area>();

        public ITable<spell_dbc> spell_dbc => GetTable<spell_dbc>();

        public ITable<spell_enchant_proc_data> spell_enchant_proc_data => GetTable<spell_enchant_proc_data>();

        public ITable<spell_group> spell_group => GetTable<spell_group>();

        public ITable<spell_group_stack_rules> spell_group_stack_rules => GetTable<spell_group_stack_rules>();

        public ITable<spell_learn_spell> spell_learn_spell => GetTable<spell_learn_spell>();

        public ITable<spell_linked_spell> spell_linked_spell => GetTable<spell_linked_spell>();

        public ITable<spell_loot_template> spell_loot_template => GetTable<spell_loot_template>();

        public ITable<spell_ranks> spell_ranks => GetTable<spell_ranks>();

        public ITable<spell_required> spell_required => GetTable<spell_required>();

        public ITable<spell_target_position> spell_target_position => GetTable<spell_target_position>();

        public ITable<spell_threat> spell_threat => GetTable<spell_threat>();

        public ITable<transports> transports => GetTable<transports>();

        public ITable<vehicle_accessory> vehicle_accessory => GetTable<vehicle_accessory>();

        public ITable<vehicle_template_accessory> vehicle_template_accessory => GetTable<vehicle_template_accessory>();

        public ITable<waypoint_data> waypoint_data => GetTable<waypoint_data>();

        public ITable<waypoint_scripts> waypoint_scripts => GetTable<waypoint_scripts>();

        public ITable<waypoints> waypoints => GetTable<waypoints>();
        
        public ITable<talent> talent => GetTable<talent>();

        public ITable<talent_tab> talent_tab => GetTable<talent_tab>();

        public ITable<taxi_nodes> taxi_nodes => GetTable<taxi_nodes>();

        public ITable<taxi_path> taxi_path => GetTable<taxi_path>();
        
        public ITable<areatrigger> areatrigger => GetTable<areatrigger>();

    }
}









