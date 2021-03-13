using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;
using UnityEngine;
using MissionTypes;

namespace CustomWhiteout
{
    internal class Patches
    {
        [HarmonyPatch(typeof(Action_WhiteoutGearRequirements))]
        [HarmonyPatch("OnExecute")]
        class PatchWhiteout
        {

            private static void Postfix(Action_WhiteoutGearRequirements __instance)
            {
                if(Dictionaries.NeedsPopulated()) Dictionaries.PopulateDictionaries();
                __instance.daysOfFoodRequired = Settings.options.daysOfFoodRequired;
                __instance.numLitersPotableWater = Settings.options.litersWaterRequired;
                __instance.numLitersKerosene = Settings.options.litersKeroseneRequired;
                __instance.sceneToStockpileItems = Dictionaries.locationNamesByWhiteoutLocation[Settings.options.stockpileLocation];

                //            Implementation.Log("Required location: " + __instance.sceneToStockpileItems);
                //            SetRequirement("GEAR_Softwood,GEAR_Hardwood", Settings.options.hardSoftWoodRequired, __instance);
                //            SetRequirement("GEAR_BearSkinBedRoll", Settings.options.bearSkillBedrollRequired, __instance, "Bearskin Bedroll");
                //            Implementation.Log("Required items now: " + __instance.requiredItemsList.value.Count);

                ClearItemRequirements(__instance);
                AddRequirement(Settings.options.item1, Settings.options.item1amount, __instance);
                AddRequirement(Settings.options.item2, Settings.options.item2amount, __instance);
                AddRequirement(Settings.options.item3, Settings.options.item3amount, __instance);
                AddRequirement(Settings.options.item4, Settings.options.item4amount, __instance);
                AddRequirement(Settings.options.item5, Settings.options.item5amount, __instance);
                AddRequirement(Settings.options.item6, Settings.options.item6amount, __instance);
                AddRequirement(Settings.options.item7, Settings.options.item7amount, __instance);
                AddRequirement(Settings.options.item8, Settings.options.item8amount, __instance);
                AddRequirement(Settings.options.item9, Settings.options.item9amount, __instance);
                AddRequirement(Settings.options.item10, Settings.options.item10amount, __instance);
                AddRequirement(Settings.options.item11, Settings.options.item11amount, __instance);
                AddRequirement(Settings.options.item12, Settings.options.item12amount, __instance);
            }

            

            private static void AddRequirement(WhiteoutItem item, int numberRequired, Action_WhiteoutGearRequirements instance)
            {
                if (item == WhiteoutItem.None)
                {
                    return;
                }

                var displayName = item.ToString().Replace('_', ' ');
                var gearName = Dictionaries.gearItemNamesByWhiteoutItem[item];
                SetRequirement(gearName, numberRequired, instance, displayName);
            }

            private static void ClearItemRequirements(Action_WhiteoutGearRequirements instance)
            {

                for (int i = 0; i < instance.requiredItemsList.value.Count; i++)
                {
                    Implementation.Log("Required items: " + instance.requiredItemsList.value[i].name + " (" + instance.requiredItemsList.value[i].amount + ")");
                    Implementation.Log("Header: " + instance.requiredItemsHeaderList[i]);
                }

                instance.requiredItemsList.value.Clear();
                instance.requiredItemsHeaderList.Clear();
            }

            private static InventoryItemRequirement FirstRequirementWithSameName(Il2CppSystem.Collections.Generic.List<InventoryItemRequirement> list, string gearName)
            {
                if (list == null || list.Count == 0) return null;
                foreach (var item in list)
                {
                    if (item.name == gearName) return item;
                }
                return null;
            }

            private static void SetRequirement(string gearName, bool required, Action_WhiteoutGearRequirements instance, string journalDisplayName = null)
            {
                SetRequirement(gearName, required ? 1 : 0, instance, journalDisplayName);
            }

            private static void SetRequirement(string gearName, int numberRequired, Action_WhiteoutGearRequirements instance, string journalDisplayName = null)
            {
                var itemRequirements = instance.requiredItemsList.value;
                var displayNames = instance.requiredItemsHeaderList;
                //var itemRequirement = itemRequirements.FirstOrDefault(i => i.name == gearName);
                var itemRequirement = FirstRequirementWithSameName(itemRequirements, gearName);
                if (itemRequirement != null)
                {
                    if (numberRequired == 0)
                    {
                        var index = itemRequirements.IndexOf(itemRequirement);
                        itemRequirements.RemoveAt(index);
                        displayNames.RemoveAt(index);
                    }
                    else
                    {
                        itemRequirement.amount = numberRequired;
                    }
                }
                else
                {
                    if (numberRequired == 0)
                    {
                        return;
                    }

                    // TODO: Condition required?
                    var newItemRequirement = new InventoryItemRequirement(gearName, numberRequired, false, null, null);
                    itemRequirements.Add(newItemRequirement);
                    displayNames.Add(journalDisplayName);
                }
            }
        }
    }
}
