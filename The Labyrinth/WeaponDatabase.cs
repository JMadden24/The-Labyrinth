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
                    weaponName: "Dagger",
                    weaponType: WeaponType.Daggers,
                    damageType: DamageType.Slashing,
                    damageDice: new[] { 1,4,2 },
                    isOneHanded: true
                ),
            }.AsReadOnly();
        }
    }
}
