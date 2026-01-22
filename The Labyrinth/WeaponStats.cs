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
        None,
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

        public string Attack1 { get; }
        public string Attack2 { get; }
        public string SpecialAttack { get; }

        public DamageType AttackDamage1 { get; }
        public DamageType AttackDamage2 { get; }
        public DamageType AttackDamage3 { get; }

        //damage dice will be saved in this example format 1,4,2 which translates to 1D4 +2 damage
        public int[] DamageDice1 { get; }
        public int[] DamageDice2 { get; }
        public int[] DamageDice3 { get; }
        public bool IsOneHanded { get; }

        public WeaponStats(
            string weaponName,
            WeaponType weaponType,
            string attack1,
            string attack2,
            string specialAttack,
            DamageType attackDamage1,
            DamageType attackDamage2,
            DamageType attackDamage3,
            int[] damageDice1,
            int[] damageDice2,
            int[] damageDice3,
            bool isOneHanded)
        {
            WeaponName = weaponName;
            WeaponType = weaponType;

            Attack1 = attack1;
            Attack2 = attack2;
            SpecialAttack = specialAttack;

            AttackDamage1 = attackDamage1;
            AttackDamage2 = attackDamage2;
            AttackDamage3 = attackDamage3;

            // defensive copy to reduce mutation risk
            DamageDice1 = (int[])damageDice1.Clone();
            DamageDice2 = (int[])damageDice2.Clone();
            DamageDice3 = (int[])damageDice3.Clone();

            IsOneHanded = isOneHanded;
        }
    }

}
