using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomWhiteout
{
    internal enum WhiteoutLocation
    {
        AC_AnglersDen,
        AC_ForemansRetreat,
        AC_HomesteadersRespite,
        BI_CanneryWorkshop,
        BR_HuntingLodge,
        CH_QuonsetGarage,
        DP_Lighthouse,
        ML_CampOffice,
        ML_Dam,
        ML_TrappersCabin,
        MT_MiltonHouse,
        MT_ParadiseMeadowsFarmhouse,
        PV_CommunityHall,
        PV_Farmhouse,
        PV_SignalHillRadioControl

        // Missing regions: 
        /*
         * Forlon Muskeg
         * Hushed River Valley
         * Timber Wolf Mountain
         */
    }

    internal enum WhiteoutPreset
    {
        NormalWhiteout,
        Explorer,
        Fisher,
        FisherHard,
        WeaponCollector,
        Hunter,
        HunterHard,
        RopeCollector,
        Nightmare,
        Custom,
    }

    internal enum WhiteoutItem
    {
        None,
        Arrows,
        Bandages,
        Bear_Pelt,
        Bearskin_Bedroll,
        Bearskin_Coat,
        Birch_Bark,
        Bow,
        Deer_Hide,
        Deerskin_Pants,
        Deerskin_Boots,
        Distress_Pistol,
        Distress_Pistol_Ammo,
        Firestriker,
        Fish,
        Fish_Cooked,
        Hacksaw,
        Hatchet,
        HeavyHammer,
        Knife,
        Lantern,
        Matches,
        Milton_Farm_Key,
        Moose_Hide,
        Moose_Hide_Bag,
        Moose_Hide_Cloak,
        Mountaineering_Rope,
        Rabbit_Pelt,
        Rabbitskin_Mittens,
        Rabbitskin_Hat,
        Reclaimed_Wood,
        Reishi_Tea,
        Revolver,
        Revolver_Cartridges,
        Rifle,
        Rifle_Cartridges,
        Rosehip_Tea,
        Soft_or_Hard_Wood,
        Stick,
        Tinder,
        Toolbox,
        Wolfskin_Coat,
        Wolf_Pelt
    }
    // More ideas:
    /*
     * flashlight
     * mag lens
     * prybar
     * Sewing kit
     * Whetstone
     */

    /* Probably not:
     * Can opener
     * Charcoal
     * Cooking pot
     * Flare
     * recycled can
     * snare
     * Stone
     * Torch
     * */
}
