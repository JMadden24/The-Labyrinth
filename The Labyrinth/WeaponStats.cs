using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Labyrinth
{
    enum WeaponType
    {
        Sword,
        Axe,
        Greatsword,
        Mace,
        Staff,
        Wand,
        Daggers,
        Rapier,
        Crossbow,
        Grimoire,
        Bow,
        Spear,
        Shortsword,
        Shield
    }
    enum DamageType
    {
        Slashing,
        Piercing,
        Bludgeoning,
        Fire,
        Ice,
        Earth,
        Wind,
        Holy,
        Bashing
    }

    internal class WeaponStats
    {
        public string WeaponName { get; }
        public WeaponType WeaponType { get; }
        public DamageType DamageType { get; }
        public int[] DamageDice { get; }
        public bool IsOneHanded { get; }

        public WeaponStats(string weaponName, WeaponType weaponType, DamageType damageType, int[] damageDice, bool isOneHanded)
        {
            WeaponName = weaponName;
            WeaponType = weaponType;
            DamageType = damageType;
            DamageDice = damageDice;
            IsOneHanded = isOneHanded;
        }


    }

}
