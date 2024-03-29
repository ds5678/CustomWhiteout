﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ModSettings;

namespace CustomWhiteout
{
    internal class WhiteoutGearSettings : JsonModSettings
    {
        [Name("Preset Challenge")]
        [Description("Preset challenges")]
        public WhiteoutPreset presetChallenge = WhiteoutPreset.NormalWhiteout;

        [Section("Customise")]
        [Name("Stockpile location")]
        [Description("Where to set up your stockpile and collect items (default: CH Quonset Garage)")]
        public WhiteoutLocation stockpileLocation = WhiteoutLocation.CH_QuonsetGarage;

        [Name("Days of food")]
        [Description("Days of food required (default 15)")]
        [Slider(5, 100, 20)]
        public int daysOfFoodRequired = 15;

        [Name("Liters of water required")]
        [Description("Liters of water required (default 25)")]
        [Slider(10, 100, 19)]
        public int litersWaterRequired = 25;

        [Name("Liters of kerosene required")]
        [Description("Liters of kerosene (lamp oil) required (default 5)")]
        [Slider(1, 20)]
        public int litersKeroseneRequired = 5;


        [Name("Item 1")]
        public WhiteoutItem item1 = WhiteoutItem.Soft_or_Hard_Wood;

        [Name("Item 1 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item1amount = 20;

        [Name("Item 2")]
        public WhiteoutItem item2 = WhiteoutItem.Reclaimed_Wood;

        [Name("Item 2 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item2amount = 30;


        [Name("Item 3")]
        public WhiteoutItem item3 = WhiteoutItem.Stick;

        [Name("Item 3 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item3amount = 50;


        [Name("Item 4")]
        public WhiteoutItem item4 = WhiteoutItem.Tinder;

        [Name("Item 4 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item4amount = 25;


        [Name("Item 5")]
        public WhiteoutItem item5 = WhiteoutItem.Bandages;

        [Name("Item 5 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item5amount = 10;


        [Name("Item 6")]
        public WhiteoutItem item6 = WhiteoutItem.Matches;

        [Name("Item 6 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item6amount = 25;


        [Name("Item 7")]
        public WhiteoutItem item7 = WhiteoutItem.Rifle;

        [Name("Item 7 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item7amount = 1;


        [Name("Item 8")]
        public WhiteoutItem item8 = WhiteoutItem.Rifle_Cartridges;

        [Name("Item 8 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item8amount = 10;


        [Name("Item 9")]
        public WhiteoutItem item9 = WhiteoutItem.Hatchet;

        [Name("Item 9 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item9amount = 1;


        [Name("Item 10")]
        public WhiteoutItem item10 = WhiteoutItem.Lantern;

        [Name("Item 10 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item10amount = 1;


        [Name("Item 11")]
        public WhiteoutItem item11 = WhiteoutItem.None;

        [Name("Item 11 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item11amount = 1;

        [Name("Item 12")]
        public WhiteoutItem item12 = WhiteoutItem.None;

        [Name("Item 12 Number required")]
        [Description("Number of this item required")]
        [Slider(1, 100)]
        public int item12amount = 1;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == "presetChallenge")
            {
                var preset = (WhiteoutPreset)newValue;
                if (preset != WhiteoutPreset.Custom)
                {
                    ResetValues();
                }

                switch (preset)
                {
                    case WhiteoutPreset.NormalWhiteout:
                        daysOfFoodRequired = 15;
                        litersWaterRequired = 25;
                        litersKeroseneRequired = 5;
                        AddRequirement(WhiteoutItem.Soft_or_Hard_Wood, 20);
                        AddRequirement(WhiteoutItem.Reclaimed_Wood, 30);
                        AddRequirement(WhiteoutItem.Stick, 50);
                        AddRequirement(WhiteoutItem.Tinder, 25);
                        AddRequirement(WhiteoutItem.Bandages, 10);
                        AddRequirement(WhiteoutItem.Matches, 25);
                        AddRequirement(WhiteoutItem.Rifle, 1);
                        AddRequirement(WhiteoutItem.Rifle_Cartridges, 10);
                        AddRequirement(WhiteoutItem.Hatchet, 1);
                        AddRequirement(WhiteoutItem.Lantern, 1);
                        break;
                    case WhiteoutPreset.WeaponCollector:
                        stockpileLocation = WhiteoutLocation.PV_SignalHillRadioControl;
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 1;
                        AddRequirement(WhiteoutItem.Distress_Pistol, 2);
                        AddRequirement(WhiteoutItem.Rifle, 2);
                        AddRequirement(WhiteoutItem.Rifle_Cartridges, 20);
                        AddRequirement(WhiteoutItem.Bow, 2);
                        AddRequirement(WhiteoutItem.Arrows, 10);
                        AddRequirement(WhiteoutItem.Hatchet, 1);
                        break;
                    case WhiteoutPreset.Fisher:
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 10;
                        AddRequirement(WhiteoutItem.Fish, 50);
                        break;
                    case WhiteoutPreset.FisherHard:
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 20;
                        AddRequirement(WhiteoutItem.Fish, 100);
                        break;
                    case WhiteoutPreset.Explorer:
                        stockpileLocation = WhiteoutLocation.BR_HuntingLodge;
                        daysOfFoodRequired = 25;
                        litersWaterRequired = 25;
                        litersKeroseneRequired = 3;
                        AddRequirement(WhiteoutItem.Milton_Farm_Key, 1);
                        AddRequirement(WhiteoutItem.Distress_Pistol, 1);
                        AddRequirement(WhiteoutItem.Bow, 1);
                        AddRequirement(WhiteoutItem.Arrows, 20);
                        AddRequirement(WhiteoutItem.Birch_Bark, 10);
                        AddRequirement(WhiteoutItem.Rosehip_Tea, 10);
                        AddRequirement(WhiteoutItem.Reishi_Tea, 10);
                        AddRequirement(WhiteoutItem.Rifle, 1);
                        AddRequirement(WhiteoutItem.Hatchet, 1);
                        break;
                    case WhiteoutPreset.Hunter:
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 1;
                        AddRequirement(WhiteoutItem.Bear_Pelt, 1);
                        AddRequirement(WhiteoutItem.Wolf_Pelt, 5);
                        AddRequirement(WhiteoutItem.Deer_Hide, 10);
                        AddRequirement(WhiteoutItem.Rabbit_Pelt, 10);
                        break;
                    case WhiteoutPreset.HunterHard:
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 1;
                        AddRequirement(WhiteoutItem.Bear_Pelt, 2);
                        AddRequirement(WhiteoutItem.Moose_Hide, 2);
                        AddRequirement(WhiteoutItem.Wolf_Pelt, 10);
                        AddRequirement(WhiteoutItem.Deer_Hide, 20);
                        AddRequirement(WhiteoutItem.Rabbit_Pelt, 20);
                        break;
                    case WhiteoutPreset.RopeCollector:
                        daysOfFoodRequired = 10;
                        litersWaterRequired = 10;
                        litersKeroseneRequired = 1;
                        AddRequirement(WhiteoutItem.Mountaineering_Rope, 10);
                        break;
                    case WhiteoutPreset.Nightmare:
                        daysOfFoodRequired = 30;
                        litersWaterRequired = 50;
                        litersKeroseneRequired = 10;
                        AddRequirement(WhiteoutItem.Distress_Pistol, 1);
                        AddRequirement(WhiteoutItem.Bearskin_Bedroll, 1);   // 12 days to cure, 17.5 hours to craft
                        AddRequirement(WhiteoutItem.Moose_Hide_Bag, 1);     // 10 days to cure, 10 hours to craft
                        AddRequirement(WhiteoutItem.Deerskin_Pants, 1);     // 5 days to cure, 12.5 hours to craft
                        AddRequirement(WhiteoutItem.Rabbitskin_Hat, 1);     // 3.5 hours to craft
                        AddRequirement(WhiteoutItem.Arrows, 30);            // 15 hours to craft at forge, plus time to collect 15 scrap metal
                        AddRequirement(WhiteoutItem.Birch_Bark, 10);
                        AddRequirement(WhiteoutItem.Soft_or_Hard_Wood, 30); // 45 mins for a limb of 3 pieces so this is 450 mins = about 8 hours of chopping
                        AddRequirement(WhiteoutItem.Rosehip_Tea, 10);
                        AddRequirement(WhiteoutItem.Reclaimed_Wood, 50);    // collecting from crates etc gives 8 per hour roughly using hatchet, so this is 6 hours of breaking down
                        AddRequirement(WhiteoutItem.Matches, 100);
                        AddRequirement(WhiteoutItem.Bandages, 25);          // cloth = 2 bandages during 20 mins. 6 per hour = 4 hours
                        break;
                    case WhiteoutPreset.Custom:
                        break;
                }
            }
            else
            {
                presetChallenge = WhiteoutPreset.Custom;
            }

            // Call this method to make the newly set field values show up in the GUI!
            RefreshGUI();
        }

        private void AddRequirement(WhiteoutItem item, int number)
        {
            if (item1 == WhiteoutItem.None)
            {
                item1 = item;
                item1amount = number;
                return;
            }

            if (item2 == WhiteoutItem.None)
            {
                item2 = item;
                item2amount = number;
                return;
            }

            if (item3 == WhiteoutItem.None)
            {
                item3 = item;
                item3amount = number;
                return;
            }

            if (item4 == WhiteoutItem.None)
            {
                item4 = item;
                item4amount = number;
                return;
            }

            if (item5 == WhiteoutItem.None)
            {
                item5 = item;
                item5amount = number;
                return;
            }

            if (item6 == WhiteoutItem.None)
            {
                item6 = item;
                item6amount = number;
                return;
            }

            if (item7 == WhiteoutItem.None)
            {
                item7 = item;
                item7amount = number;
                return;
            }

            if (item8 == WhiteoutItem.None)
            {
                item8 = item;
                item8amount = number;
                return;
            }

            if (item9 == WhiteoutItem.None)
            {
                item9 = item;
                item9amount = number;
                return;
            }

            if (item10 == WhiteoutItem.None)
            {
                item10 = item;
                item10amount = number;
                return;
            }

            if (item11 == WhiteoutItem.None)
            {
                item11 = item;
                item11amount = number;
                return;
            }

            if (item12 == WhiteoutItem.None)
            {
                item12 = item;
                item12amount = number;
                return;
            }
        }

        private void ResetValues()
        {
            stockpileLocation = WhiteoutLocation.CH_QuonsetGarage;
            daysOfFoodRequired = 10;
            litersWaterRequired = 10;
            litersKeroseneRequired = 1;
            item1 = WhiteoutItem.None;
            item1amount = 1;
            item2 = WhiteoutItem.None;
            item2amount = 1;
            item3 = WhiteoutItem.None;
            item3amount = 1;
            item4 = WhiteoutItem.None;
            item4amount = 1;
            item5 = WhiteoutItem.None;
            item5amount = 1;
            item6 = WhiteoutItem.None;
            item6amount = 1;
            item7 = WhiteoutItem.None;
            item7amount = 1;
            item8 = WhiteoutItem.None;
            item8amount = 1;
            item9 = WhiteoutItem.None;
            item9amount = 1;
            item10 = WhiteoutItem.None;
            item10amount = 1;
            item11 = WhiteoutItem.None;
            item11amount = 1;
            item12 = WhiteoutItem.None;
            item12amount = 1;
        }
    }


    internal static class Settings
    {
        internal static WhiteoutGearSettings options;

        internal static void OnLoad()
        {
            options = new WhiteoutGearSettings();
            options.AddToModSettings("Custom Whiteout Challenge",MenuType.MainMenuOnly);
        }
    }
}
