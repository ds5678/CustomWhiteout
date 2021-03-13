using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhiteout
{
    public static class Dictionaries
    {
        internal static Dictionary<WhiteoutItem, string> gearItemNamesByWhiteoutItem;
        internal static Dictionary<WhiteoutLocation, string> locationNamesByWhiteoutLocation;
        private static bool needsPopulated = true;
        internal static void PopulateDictionaries()
        {
            gearItemNamesByWhiteoutItem = new Dictionary<WhiteoutItem, string>();
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Arrows, "GEAR_Arrow");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Bandages, "GEAR_HeavyBandage,GEAR_OldMansBeardDressing");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Bear_Pelt, "GEAR_BearHide,GEAR_BearHideDried");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Bearskin_Bedroll, "GEAR_BearSkinBedRoll");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Bearskin_Coat, "GEAR_BearSkinCoat");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Birch_Bark, "GEAR_BarkTinder");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Bow, "GEAR_Bow");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Deer_Hide, "GEAR_LeatherHideDried,GEAR_LeatherHide");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Deerskin_Boots, "GEAR_DeerskinBoots");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Deerskin_Pants, "GEAR_DeerskinPants");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Distress_Pistol, "GEAR_FlareGun");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Distress_Pistol_Ammo, "GEAR_FlareGunAmmoSingle");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Firestriker, "GEAR_Firestriker");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Fish, "GEAR_RawCohoSalmon,GEAR_CookedCohoSalmon,GEAR_RawLakeWhiteFish,GEAR_CookedLakeWhiteFish,GEAR_RawRainbowTrout,GEAR_CookedRainbowTrout,GEAR_RawSmallMouthBass,GEAR_CookedSmallMouthBass");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Fish_Cooked, "GEAR_CookedCohoSalmon,GEAR_CookedLakeWhiteFish,GEAR_CookedRainbowTrout,GEAR_CookedSmallMouthBass");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Hacksaw, "GEAR_Hacksaw");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Hatchet, "GEAR_Hatchet,GEAR_HatchetImprovised");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.HeavyHammer, "GEAR_Hammer");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Knife, "GEAR_Knife,GEAR_KnifeImprovised");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Lantern, "GEAR_KeroseneLampB");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Matches, "GEAR_PackMatches,GEAR_WoodMatches");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Milton_Farm_Key, "GEAR_RuralRegionFarmKey");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Moose_Hide, "GEAR_MooseHide,GEAR_MooseHideDried");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Moose_Hide_Bag, "GEAR_MooseHideBag");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Moose_Hide_Cloak, "GEAR_MooseHideCloak");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Mountaineering_Rope, "GEAR_Rope");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rabbit_Pelt, "GEAR_RabbitPelt,GEAR_RabbitPeltDried");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rabbitskin_Hat, "GEAR_RabbitskinHat");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rabbitskin_Mittens, "GEAR_RabbitSkinMittens");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Reclaimed_Wood, "GEAR_ReclaimedWoodB");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Reishi_Tea, "GEAR_ReishiTea");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Revolver, "GEAR_Revolver");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Revolver_Cartridges, "GEAR_RevolverAmmoBox,GEAR_RevolverAmmoSingle");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rifle, "GEAR_Rifle");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rifle_Cartridges, "GEAR_RifleAmmoBox,GEAR_RifleAmmoSingle");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Rosehip_Tea, "GEAR_RoseHipTea");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Soft_or_Hard_Wood, "GEAR_Softwood,GEAR_Hardwood");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Stick, "GEAR_Stick");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Tinder, "GEAR_NewsprintRoll,GEAR_PaperStack,GEAR_Newsprint,GEAR_CashBundle,GEAR_BarkTinder,GEAR_Tinder,GEAR_CattailTinder");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Toolbox, "GEAR_SimpleTools,GEAR_HighQualityTools");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Wolf_Pelt, "GEAR_WolfPelt,GEAR_WolfPeltDried");
            gearItemNamesByWhiteoutItem.Add(WhiteoutItem.Wolfskin_Coat, "GEAR_WolfSkinCape");

            locationNamesByWhiteoutLocation = new Dictionary<WhiteoutLocation, string>();
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.AC_AnglersDen, "AshCabinF");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.AC_ForemansRetreat, "WoodCabinB");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.AC_HomesteadersRespite, "AshWoodCabinA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.BI_CanneryWorkshop, "MaintenanceShedB");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.BR_HuntingLodge, "HuntingLodgeA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.CH_QuonsetGarage, "QuonsetGasStation");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.DP_Lighthouse, "LighthouseA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.ML_CampOffice, "CampOffice");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.ML_Dam, "Dam");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.ML_TrappersCabin, "SafeHouseA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.MT_MiltonHouse, "GreyMothersHouseA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.MT_ParadiseMeadowsFarmhouse, "FarmHouseB");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.PV_CommunityHall, "CommunityHallA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.PV_Farmhouse, "FarmHouseA");
            locationNamesByWhiteoutLocation.Add(WhiteoutLocation.PV_SignalHillRadioControl, "RadioControlHut");

            needsPopulated = false;
        }

        internal static bool NeedsPopulated() => needsPopulated;
    }
}
