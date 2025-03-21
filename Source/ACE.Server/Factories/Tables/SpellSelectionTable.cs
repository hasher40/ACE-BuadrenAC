using System.Collections.Generic;

using ACE.Entity.Enum;
using ACE.Server.Factories.Entity;

namespace ACE.Server.Factories.Tables
{
    /// <summary>
    /// Defines which spells can be found on item types
    /// </summary>
    public static class SpellSelectionTable
    {
        // thanks to Sapphire Knight and Butterflygolem for helping to figure this part out!

        // gems
        private static ChanceTable<SpellId> spellSelectionGroup1 = new ChanceTable<SpellId>()
        {
            ( SpellId.StrengthSelf1,            0.06f ),
            ( SpellId.EnduranceSelf1,           0.06f ),
            ( SpellId.CoordinationSelf1,        0.06f ),
            ( SpellId.QuicknessSelf1,           0.06f ),
            ( SpellId.FocusSelf1,               0.06f ),
            ( SpellId.WillpowerSelf1,           0.06f ),
            ( SpellId.RegenerationSelf1,        0.09f ),
            ( SpellId.RejuvenationSelf1,        0.09f ),
            ( SpellId.ManaRenewalSelf1,         0.09f ),
            ( SpellId.AcidProtectionSelf1,      0.04f ),
            ( SpellId.BludgeonProtectionSelf1,  0.04f ),
            ( SpellId.ColdProtectionSelf1,      0.04f ),
            ( SpellId.LightningProtectionSelf1, 0.04f ),
            ( SpellId.FireProtectionSelf1,      0.04f ),
            ( SpellId.BladeProtectionSelf1,     0.04f ),
            ( SpellId.PiercingProtectionSelf1,  0.04f ),
            ( SpellId.ArmorSelf1,               0.09f ),
        };

        // jewelry
        private static ChanceTable<SpellId> spellSelectionGroup2 = new ChanceTable<SpellId>()
        {
            ( SpellId.FocusSelf1,               0.06f ),
            ( SpellId.WillpowerSelf1,           0.06f ),
            ( SpellId.ArmorSelf1,               0.05f ),
            ( SpellId.AcidProtectionSelf1,      0.05f ),
            ( SpellId.BludgeonProtectionSelf1,  0.05f ),
            ( SpellId.ColdProtectionSelf1,      0.05f ),
            ( SpellId.LightningProtectionSelf1, 0.05f ),
            ( SpellId.FireProtectionSelf1,      0.05f ),
            ( SpellId.BladeProtectionSelf1,     0.05f ),
            ( SpellId.PiercingProtectionSelf1,  0.05f ),
            ( SpellId.StrengthSelf1,            0.04f ),
            ( SpellId.EnduranceSelf1,           0.04f ),
            ( SpellId.CoordinationSelf1,        0.04f ),
            ( SpellId.QuicknessSelf1,           0.04f ),
            ( SpellId.MagicResistanceSelf1,     0.04f ),
            ( SpellId.InvulnerabilitySelf1,     0.04f ),
            ( SpellId.ImpregnabilitySelf1,      0.04f ),
            ( SpellId.ArcaneEnlightenmentSelf1, 0.04f ),
            ( SpellId.ManaMasterySelf1,         0.04f ),
            ( SpellId.RegenerationSelf1,        0.04f ),
            ( SpellId.RejuvenationSelf1,        0.04f ),
            ( SpellId.ManaRenewalSelf1,         0.04f ),
        };

        // crowns
        private static ChanceTable<SpellId> spellSelectionGroup3 = new ChanceTable<SpellId>()
        {
            ( SpellId.FocusSelf1,               0.10f ),
            ( SpellId.WillpowerSelf1,           0.10f ),
            ( SpellId.LeadershipMasterySelf1,   0.10f ),
            ( SpellId.ItemExpertiseSelf1,       0.10f ),
            ( SpellId.ArmorExpertiseSelf1,      0.10f ),
            ( SpellId.WeaponExpertiseSelf1,     0.10f ),
            ( SpellId.MagicItemExpertiseSelf1,  0.10f ),
            ( SpellId.ManaMasterySelf1,         0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1, 0.05f ),
            ( SpellId.ArcanumSalvagingSelf1,    0.05f ),
            ( SpellId.RegenerationSelf1,        0.05f ),
            ( SpellId.RejuvenationSelf1,        0.05f ),
            ( SpellId.ManaRenewalSelf1,         0.05f ),
        };

        // orbs and non war/void casters
        private static ChanceTable<SpellId> spellSelectionGroup4 = new ChanceTable<SpellId>()
        {
            ( SpellId.LifeMagicMasterySelf1,           0.35f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.25f ),
            ( SpellId.ManaMasterySelf1,                0.25f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.15f ),
        };

        // wands, staffs, sceptres, batons
        private static ChanceTable<SpellId> spellSelectionGroup5 = new ChanceTable<SpellId>()
        {
            ( SpellId.WarMagicMasterySelf1,            0.25f ),
            ( SpellId.ManaMasterySelf1,                0.15f ),
            ( SpellId.LifeMagicMasterySelf1,           0.15f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.15f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.15f ),
            ( SpellId.SneakAttackMasterySelf1,         0.15f ),
        };

        // one-handed melee weapons
        private static ChanceTable<SpellId> spellSelectionGroup6 = new ChanceTable<SpellId>()
        {
            ( SpellId.DualWieldMasterySelf1,     0.25f ),
            ( SpellId.DirtyFightingMasterySelf1, 0.25f ),
            ( SpellId.SneakAttackMasterySelf1,   0.25f ),
            ( SpellId.ShieldMasterySelf1,        0.25f ),
        };

        // bracers, breastplates, coats, cuirasses, hauberks, pauldrons, chest armor, sleeves
        private static ChanceTable<SpellId> spellSelectionGroup7 = new ChanceTable<SpellId>()
        {
            ( SpellId.StrengthSelf1,              0.20f ),
            ( SpellId.EnduranceSelf1,             0.20f ),
            ( SpellId.SummoningMasterySelf1,      0.10f ),
            ( SpellId.MagicResistanceSelf1,       0.10f ),
            ( SpellId.RecklessnessMasterySelf1,   0.05f ),
            ( SpellId.SneakAttackMasterySelf1,    0.05f ),
            ( SpellId.DeceptionMasterySelf1,      0.05f ),
            ( SpellId.DualWieldMasterySelf1,      0.05f ),
            ( SpellId.DirtyFightingMasterySelf1,  0.05f ),
            ( SpellId.RegenerationSelf1,          0.05f ),
            ( SpellId.RejuvenationSelf1,          0.05f ),
            ( SpellId.ManaRenewalSelf1,           0.05f ),
        };

        // shields
        private static ChanceTable<SpellId> spellSelectionGroup8 = new ChanceTable<SpellId>()
        {
            ( SpellId.ShieldMasterySelf1,       0.25f ),
            ( SpellId.InvulnerabilitySelf1,     0.25f ),
            ( SpellId.ImpregnabilitySelf1,      0.25f ),
            ( SpellId.MagicResistanceSelf1,     0.25f ),
        };

        // gauntlets
        private static ChanceTable<SpellId> spellSelectionGroup9 = new ChanceTable<SpellId>()
        {
            ( SpellId.CoordinationSelf1,          0.20f ),
            ( SpellId.HealingMasterySelf1,        0.10f ),
            ( SpellId.HeavyWeaponsMasterySelf1,   0.05f ),
            ( SpellId.LightWeaponsMasterySelf1,   0.05f ),
            ( SpellId.FinesseWeaponsMasterySelf1, 0.05f ),
            ( SpellId.MissileWeaponsMasterySelf1, 0.05f ),
            ( SpellId.TwoHandedMasterySelf1,      0.05f ),
            ( SpellId.RecklessnessMasterySelf1,   0.05f ),
            ( SpellId.SneakAttackMasterySelf1,    0.05f ),
            ( SpellId.DeceptionMasterySelf1,      0.05f ),
            ( SpellId.DualWieldMasterySelf1,      0.05f ),
            ( SpellId.DirtyFightingMasterySelf1,  0.05f ),
            ( SpellId.LockpickMasterySelf1,       0.05f ),
            ( SpellId.FletchingMasterySelf1,      0.05f ),
            ( SpellId.ShieldMasterySelf1,         0.05f ),
            ( SpellId.ManaMasterySelf1,           0.05f ),
        };

        // helms, basinets, helmets, coifs, cowls, heaumes, kabutons
        private static ChanceTable<SpellId> spellSelectionGroup10 = new ChanceTable<SpellId>()
        {
            ( SpellId.ImpregnabilitySelf1,         0.10f ),
            ( SpellId.InvulnerabilitySelf1,        0.10f ),
            ( SpellId.HealingMasterySelf1,         0.10f ),
            ( SpellId.FletchingMasterySelf1,       0.10f ),
            ( SpellId.LockpickMasterySelf1,        0.10f ),
            ( SpellId.LifeMagicMasterySelf1,       0.05f ),
            ( SpellId.ItemEnchantmentMasterySelf1, 0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1,    0.05f ),
            ( SpellId.DualWieldMasterySelf1,       0.05f ),
            ( SpellId.DirtyFightingMasterySelf1,   0.05f ),
            ( SpellId.RecklessnessMasterySelf1,    0.05f ),
            ( SpellId.SneakAttackMasterySelf1,     0.05f ),
            ( SpellId.DeceptionMasterySelf1,       0.05f ),
            ( SpellId.ShieldMasterySelf1,          0.05f ),
            ( SpellId.ManaMasterySelf1,            0.05f ),
        };

        // boots, chiran sandals, sollerets
        private static ChanceTable<SpellId> spellSelectionGroup11 = new ChanceTable<SpellId>()
        {
            ( SpellId.QuicknessSelf1,              0.20f ),
            ( SpellId.HealingMasterySelf1,         0.10f ),
            ( SpellId.LifeMagicMasterySelf1,       0.05f ),
            ( SpellId.ItemEnchantmentMasterySelf1, 0.05f ),
            ( SpellId.HeavyWeaponsMasterySelf1,    0.05f ),
            ( SpellId.FinesseWeaponsMasterySelf1,  0.05f ),
            ( SpellId.MissileWeaponsMasterySelf1,  0.05f ),
            ( SpellId.LightWeaponsMasterySelf1,    0.05f ),
            ( SpellId.TwoHandedMasterySelf1,       0.05f ),
            ( SpellId.ImpregnabilitySelf1,         0.05f ),
            ( SpellId.InvulnerabilitySelf1,        0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1,    0.05f ),
            ( SpellId.LockpickMasterySelf1,        0.05f ),
            ( SpellId.FletchingMasterySelf1,       0.05f ),
            ( SpellId.JumpingMasterySelf1,         0.05f ),
            ( SpellId.SprintSelf1,                 0.05f ),
        };

        // breeches, jerkins, shirts, pants, tunics, doublets, trousers, pantaloons
        private static ChanceTable<SpellId> spellSelectionGroup12 = new ChanceTable<SpellId>()
        {
            ( SpellId.ArmorSelf1,               0.125f ),
            ( SpellId.AcidProtectionSelf1,      0.125f ),
            ( SpellId.BludgeonProtectionSelf1,  0.125f ),
            ( SpellId.ColdProtectionSelf1,      0.125f ),
            ( SpellId.LightningProtectionSelf1, 0.125f ),
            ( SpellId.FireProtectionSelf1,      0.125f ),
            ( SpellId.BladeProtectionSelf1,     0.125f ),
            ( SpellId.PiercingProtectionSelf1,  0.125f ),
        };

        // caps, qafiyas, turbans, fezs, berets
        private static ChanceTable<SpellId> spellSelectionGroup13 = new ChanceTable<SpellId>()
        {
            ( SpellId.FocusSelf1,                      0.06f ),
            ( SpellId.WillpowerSelf1,                  0.06f ),
            ( SpellId.HealingMasterySelf1,             0.04f ),
            ( SpellId.InvulnerabilitySelf1,            0.04f ),
            ( SpellId.ImpregnabilitySelf1,             0.04f ),
            ( SpellId.MagicResistanceSelf1,            0.04f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.04f ),
            ( SpellId.LifeMagicMasterySelf1,           0.04f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.04f ),
            ( SpellId.ManaMasterySelf1,                0.04f ),
            ( SpellId.RejuvenationSelf1,               0.04f ),
            ( SpellId.RegenerationSelf1,               0.04f ),
            ( SpellId.ManaRenewalSelf1,                0.04f ),
            ( SpellId.DualWieldMasterySelf1,           0.03f ),
            ( SpellId.DirtyFightingMasterySelf1,       0.03f ),
            ( SpellId.RecklessnessMasterySelf1,        0.03f ),
            ( SpellId.SneakAttackMasterySelf1,         0.03f ),
            ( SpellId.AlchemyMasterySelf1,             0.03f ),
            ( SpellId.CookingMasterySelf1,             0.03f ),
            ( SpellId.FletchingMasterySelf1,           0.03f ),
            ( SpellId.LockpickMasterySelf1,            0.03f ),
            ( SpellId.DeceptionMasterySelf1,           0.03f ),
            ( SpellId.ArcanumSalvagingSelf1,           0.03f ),
            ( SpellId.ArmorExpertiseSelf1,             0.03f ),
            ( SpellId.MagicItemExpertiseSelf1,         0.03f ),
            ( SpellId.ItemExpertiseSelf1,              0.03f ),
            ( SpellId.WeaponExpertiseSelf1,            0.03f ),
            ( SpellId.FealtySelf1,                     0.02f ),
        };

        // cloth gloves (1 entry?)
        private static ChanceTable<SpellId> spellSelectionGroup14 = new ChanceTable<SpellId>()
        {
            ( SpellId.CoordinationSelf1,               0.07f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.05f ),
            ( SpellId.LifeMagicMasterySelf1,           0.05f ),
            ( SpellId.ManaMasterySelf1,                0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.05f ),
            ( SpellId.HeavyWeaponsMasterySelf1,        0.05f ),
            ( SpellId.LightWeaponsMasterySelf1,        0.05f ),
            ( SpellId.FinesseWeaponsMasterySelf1,      0.05f ),
            ( SpellId.MissileWeaponsMasterySelf1,      0.05f ),
            ( SpellId.TwoHandedMasterySelf1,           0.05f ),
            ( SpellId.DualWieldMasterySelf1,           0.05f ),
            ( SpellId.DirtyFightingMasterySelf1,       0.05f ),
            ( SpellId.RecklessnessMasterySelf1,        0.05f ),
            ( SpellId.SneakAttackMasterySelf1,         0.05f ),
            ( SpellId.DeceptionMasterySelf1,           0.05f ),
            ( SpellId.ShieldMasterySelf1,              0.05f ),
            ( SpellId.FletchingMasterySelf1,           0.05f ),
            ( SpellId.HealingMasterySelf1,             0.05f ),
            ( SpellId.LockpickMasterySelf1,            0.05f ),
            ( SpellId.ArcanumSalvagingSelf1,           0.03f ),
        };

        // girths, greaves, leggings, tassets, leather pants
        private static ChanceTable<SpellId> spellSelectionGroup15 = new ChanceTable<SpellId>()
        {
            ( SpellId.SummoningMasterySelf1,       0.15f ),
            ( SpellId.ItemEnchantmentMasterySelf1, 0.10f ),
            ( SpellId.LifeMagicMasterySelf1,       0.10f ),
            ( SpellId.FocusSelf1,                  0.09f ),
            ( SpellId.WillpowerSelf1,              0.09f ),
            ( SpellId.CoordinationSelf1,           0.06f ),
            ( SpellId.QuicknessSelf1,              0.06f ),
            ( SpellId.HeavyWeaponsMasterySelf1,    0.05f ),
            ( SpellId.FinesseWeaponsMasterySelf1,  0.05f ),
            ( SpellId.LightWeaponsMasterySelf1,    0.05f ),
            ( SpellId.MissileWeaponsMasterySelf1,  0.05f ),
            ( SpellId.TwoHandedMasterySelf1,       0.05f ),
            ( SpellId.JumpingMasterySelf1,         0.05f ),
            ( SpellId.SprintSelf1,                 0.05f ),
        };

        // dinnerware
        private static ChanceTable<SpellId> spellSelectionGroup16 = new ChanceTable<SpellId>()
        {
            ( SpellId.AlchemyMasterySelf1,     0.09f ),
            ( SpellId.CookingMasterySelf1,     0.09f ),
            ( SpellId.FletchingMasterySelf1,   0.09f ),
            ( SpellId.LockpickMasterySelf1,    0.09f ),
            ( SpellId.ArcanumSalvagingSelf1,   0.08f ),
            ( SpellId.ArmorExpertiseSelf1,     0.08f ),
            ( SpellId.ItemExpertiseSelf1,      0.08f ),
            ( SpellId.MagicItemExpertiseSelf1, 0.08f ),
            ( SpellId.WeaponExpertiseSelf1,    0.08f ),
            ( SpellId.WillpowerSelf1,          0.04f ),
            ( SpellId.StrengthSelf1,           0.04f ),
            ( SpellId.EnduranceSelf1,          0.04f ),
            ( SpellId.CoordinationSelf1,       0.04f ),
            ( SpellId.QuicknessSelf1,          0.04f ),
            ( SpellId.FocusSelf1,              0.04f ),
        };

        // added

        // missile weapons, two-handed weapons
        private static ChanceTable<SpellId> spellSelectionGroup17 = new ChanceTable<SpellId>()
        {
            ( SpellId.DirtyFightingMasterySelf1, 0.33f ),
            ( SpellId.RecklessnessMasterySelf1,  0.33f ),
            ( SpellId.SneakAttackMasterySelf1,   0.34f ),
        };

        // shoes, loafers, slippers, sandals
        private static ChanceTable<SpellId> spellSelectionGroup18 = new ChanceTable<SpellId>()
        {
            ( SpellId.QuicknessSelf1,               0.18f ),
            ( SpellId.ImpregnabilitySelf1,          0.05f ),
            ( SpellId.InvulnerabilitySelf1,         0.05f ),
            ( SpellId.LockpickMasterySelf1,         0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1,     0.05f ),
            ( SpellId.FletchingMasterySelf1,        0.05f ),
            ( SpellId.HealingMasterySelf1,          0.05f ),
            ( SpellId.LifeMagicMasterySelf1,        0.05f ),
            ( SpellId.ItemEnchantmentMasterySelf1,  0.05f ),
            ( SpellId.JumpingMasterySelf1,          0.05f ),
            ( SpellId.SprintSelf1,                  0.05f ),
            ( SpellId.HeavyWeaponsMasterySelf1,     0.05f ),
            ( SpellId.LightWeaponsMasterySelf1,     0.05f ),
            ( SpellId.FinesseWeaponsMasterySelf1,   0.05f ),
            ( SpellId.MissileWeaponsMasterySelf1,   0.05f ),
            ( SpellId.TwoHandedMasteryOther1,       0.05f ),
            ( SpellId.FealtySelf1,                  0.04f ),
            ( SpellId.ArcanumSalvagingSelf1,        0.03f ),
        };

        // nether caster
        private static ChanceTable<SpellId> spellSelectionGroup19 = new ChanceTable<SpellId>()
        {
            ( SpellId.VoidMagicMasterySelf1,           0.25f ),
            ( SpellId.ManaMasterySelf1,                0.15f ),
            ( SpellId.LifeMagicMasterySelf1,           0.15f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.15f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.15f ),
            ( SpellId.SneakAttackMasterySelf1,         0.15f ),
        };

        // leather cap (1 entry?)
        private static ChanceTable<SpellId> spellSelectionGroup20 = new ChanceTable<SpellId>()
        {
            ( SpellId.FocusSelf1,                      0.05f ),
            ( SpellId.WillpowerSelf1,                  0.05f ),
            ( SpellId.ArcaneEnlightenmentSelf1,        0.05f ),
            ( SpellId.ManaMasterySelf1,                0.05f ),
            ( SpellId.HealingMasterySelf1,             0.05f ),
            ( SpellId.LockpickMasterySelf1,            0.05f ),
            ( SpellId.FletchingMasterySelf1,           0.05f ),
            ( SpellId.LifeMagicMasterySelf1,           0.05f ),
            ( SpellId.ItemEnchantmentMasterySelf1,     0.05f ),
            ( SpellId.RecklessnessMasterySelf1,        0.05f ),
            ( SpellId.SneakAttackMasterySelf1,         0.05f ),
            ( SpellId.DeceptionMasterySelf1,           0.05f ),
            ( SpellId.DualWieldMasterySelf1,           0.05f ),
            ( SpellId.DirtyFightingMasterySelf1,       0.05f ),
            ( SpellId.MagicResistanceSelf1,            0.05f ),
            ( SpellId.AlchemyMasterySelf1,             0.05f ),
            ( SpellId.CookingMasterySelf1,             0.05f ),
            ( SpellId.RegenerationSelf1,               0.03f ),
            ( SpellId.RejuvenationSelf1,               0.03f ),
            ( SpellId.ManaRenewalSelf1,                0.03f ),
            ( SpellId.FealtySelf1,                     0.03f ),
            ( SpellId.ArcanumSalvagingSelf1,           0.03f ),
        };

        // tinker set
        private static ChanceTable<SpellId> spellSelectionGroup21 = new ChanceTable<SpellId>()
        {
            ( SpellId.ArmorExpertiseSelf1,      0.15f ),
            ( SpellId.WeaponExpertiseSelf1,     0.15f ),
            ( SpellId.MagicItemExpertiseSelf1,  0.15f ),
            ( SpellId.ItemExpertiseSelf1,       0.15f ),
            ( SpellId.StrengthSelf1,            0.10f ),
            ( SpellId.EnduranceSelf1,           0.10f ),
            ( SpellId.CoordinationSelf1,        0.10f ),
            ( SpellId.FocusSelf1,               0.10f ),
        };

        // crafter set
        private static ChanceTable<SpellId> spellSelectionGroup22 = new ChanceTable<SpellId>()
        {
            ( SpellId.AlchemyMasterySelf1,      0.15f ),
            ( SpellId.CookingMasterySelf1,      0.15f ),
            ( SpellId.FletchingMasterySelf1,    0.15f ),
            ( SpellId.LockpickMasterySelf1,     0.15f ),
            ( SpellId.CoordinationSelf1,        0.15f ),
            ( SpellId.FocusSelf1,               0.15f ),
            ( SpellId.ItemExpertiseSelf1,       0.10f ),
        };

        /// <summary>
        /// Key is (PropertyInt.TsysMutationData >> 24) - 1
        /// </summary>
        private static readonly List<ChanceTable<SpellId>> spellSelectionGroup = new List<ChanceTable<SpellId>>()
        {
            spellSelectionGroup1,
            spellSelectionGroup2,
            spellSelectionGroup3,
            spellSelectionGroup4,
            spellSelectionGroup5,
            spellSelectionGroup6,
            spellSelectionGroup7,
            spellSelectionGroup8,
            spellSelectionGroup9,
            spellSelectionGroup10,
            spellSelectionGroup11,
            spellSelectionGroup12,
            spellSelectionGroup13,
            spellSelectionGroup14,
            spellSelectionGroup15,
            spellSelectionGroup16,
            spellSelectionGroup17,
            spellSelectionGroup18,
            spellSelectionGroup19,
            spellSelectionGroup20,
            spellSelectionGroup21,
            spellSelectionGroup22,
        };

        /// <summary>
        /// Rolls for a creature / life spell for an item
        /// </summary>
        /// <param name="spellCode">the SpellCode from WorldObject</param>
        public static SpellId Roll(int spellCode)
        {
            return spellSelectionGroup[spellCode - 1].Roll();
        }
    }
}
