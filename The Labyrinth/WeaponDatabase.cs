using System.Collections.Generic;

namespace The_Labyrinth
{
    internal static class WeaponDatabase
    {
        public static IReadOnlyList<WeaponStats> Weapons { get; }

        static WeaponDatabase()
        {
            Weapons = new List<WeaponStats>
            {
                new WeaponStats(
                    weaponName: "Simple Dagger",
                    weaponType: WeaponType.Daggers,

                    attack1: "Slash",
                    attack2: "Stab",
                    specialAttack: null,

                    attackDamage1: DamageType.Slashing,
                    attackDamage2: DamageType.Piercing,
                    attackDamage3: DamageType.None,

                    damageDice1: new[] { 1,4,2 },
                    damageDice2: new[] { 1,6,0 },
                    damageDice3: new[] { 0,0,0 },

                    isOneHanded: true
                ),
                new WeaponStats(
                    weaponName: "Simple Rapier",
                    weaponType: WeaponType.Rapier,

                    attack1: "Thrust",
                    attack2: "Cut",
                    specialAttack: null,

                    attackDamage1: DamageType.Piercing,
                    attackDamage2: DamageType.Slashing,
                    attackDamage3: DamageType.None,

                    damageDice1: new[] { 1,6,2 },
                    damageDice2: new[] { 1,4,2 },
                    damageDice3: new[] { 0,0,0 },

                    isOneHanded: true
                ),
                new WeaponStats(
                    weaponName: "Shortsword",
                    weaponType: WeaponType.Sword,

                    attack1: "Slash",
                    attack2: "Stab",
                    specialAttack: null,

                    attackDamage1: DamageType.Slashing,
                    attackDamage2: DamageType.Piercing,
                    attackDamage3: DamageType.None,

                    damageDice1: new[] { 1,6,2 },
                    damageDice2: new[] { 1,6,2 },
                    damageDice3: new[] { 0,0,0 },

                    isOneHanded: true
                ),
            }.AsReadOnly();
        }
    }
}
