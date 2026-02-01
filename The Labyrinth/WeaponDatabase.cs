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
                new WeaponStats("Steel Sword", WeaponType.Sword,
                    "Slash", "Thrust", null,
                    DamageType.Slashing, DamageType.Piercing, DamageType.None,
                    new[] {1,6,0}, new[] {1,6,2}, new[] {0,0,0},
                    true),

                new WeaponStats("Iron Shortsword", WeaponType.Shortsword,
                    "Slash", "Stab", null,
                    DamageType.Slashing, DamageType.Piercing, DamageType.None,
                    new[] {1,6,2}, new[] {1,6,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Hand Axe", WeaponType.Axe,
                    "Chop", null, null,
                    DamageType.Slashing, DamageType.None, DamageType.None,
                    new[] {1,8,0}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Woodcutter Axe", WeaponType.Axe,
                    "Hack", null, null,
                    DamageType.Slashing, DamageType.None, DamageType.None,
                    new[] {1,10,2}, new[] {0,0,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Greatclub", WeaponType.Mace,
                    "Heavy Swing", null, null,
                    DamageType.Bludgeoning, DamageType.None, DamageType.None,
                    new[] {2,6,0}, new[] {0,0,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Light Mace", WeaponType.Mace,
                    "Smash", null, null,
                    DamageType.Bludgeoning, DamageType.None, DamageType.None,
                    new[] {1,6,2}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Hunting Spear", WeaponType.Spear,
                    "Thrust", null, null,
                    DamageType.Piercing, DamageType.None, DamageType.None,
                    new[] {1,8,0}, new[] {0,0,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Steel Dagger", WeaponType.Daggers,
                    "Stab", "Slash", null,
                    DamageType.Piercing, DamageType.Slashing, DamageType.None,
                    new[] {1,6,0}, new[] {1,4,2}, new[] {0,0,0},
                    true),

                new WeaponStats("Hand Crossbow", WeaponType.Daggers,
                    "Simple Shot", null, null,
                    DamageType.Piercing, DamageType.None, DamageType.None,
                    new[] {1,6,2}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Twin Daggers", WeaponType.Daggers,
                    "Double Stab", "Double Slash", null,
                    DamageType.Piercing, DamageType.Slashing, DamageType.None,
                    new[] {2,4,2}, new[] {2,6,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Simple Rapier", WeaponType.Rapier,
                    "Thrust", "Slash", null,
                    DamageType.Piercing, DamageType.Slashing, DamageType.None,
                    new[] {1,6,2}, new[] {1,4,2}, new[] {0,0,0},
                    true),

                new WeaponStats("Fire Staff", WeaponType.Staff,
                    "Strike", "Fire Ball", null,
                    DamageType.Bludgeoning, DamageType.Fire, DamageType.None,
                    new[] {1,6,0}, new[] {2,4,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Ice Staff", WeaponType.Staff,
                    "Strike", "Ice Spear", null,
                    DamageType.Bludgeoning, DamageType.Ice, DamageType.None,
                    new[] {1,6,0}, new[] {1,6,2}, new[] {0,0,0},
                    false),

                new WeaponStats("Earth Wand", WeaponType.Wand,
                    "Stone Bullet", null, null,
                    DamageType.Earth, DamageType.None, DamageType.None,
                    new[] {1,6,0}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Wind Wand", WeaponType.Wand,
                    "Wind Blast", null, null,
                    DamageType.Wind, DamageType.None, DamageType.None,
                    new[] {1,6,2}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Holy Grimoire", WeaponType.Grimoire,
                    "Gods Blessing", "Divine Light", null,
                    DamageType.Holy, DamageType.Holy, DamageType.None,
                    new[] {1,8,0}, new[] {3,3,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Wood Shield", WeaponType.Shield,
                    "Bash", null, null,
                    DamageType.Bludgeoning, DamageType.None, DamageType.None,
                    new[] {1,4,2}, new[] {0,0,0}, new[] {0,0,0},
                    true),

                new WeaponStats("Shortbow", WeaponType.Bow,
                    "Simple Shot", null, null,
                    DamageType.Piercing, DamageType.None, DamageType.None,
                    new[] {1,6,2}, new[] {0,0,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Long Bow", WeaponType.Bow,
                    "Simple Shot", null, null,
                    DamageType.Piercing, DamageType.None, DamageType.None,
                    new[] {1,8,0}, new[] {0,0,0}, new[] {0,0,0},
                    false),

                new WeaponStats("Heavy Crossbow", WeaponType.Crossbow,
                    "Bolt Shot", null, null,
                    DamageType.Piercing, DamageType.None, DamageType.None,
                    new[] {1,8,2}, new[] {0,0,0}, new[] {0,0,0},
                    false)
            }.AsReadOnly();

        }
    }
}
