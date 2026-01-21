using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Labyrinth
{
    enum Species
    {
        Human,
        Elf,
        Dwarf,
        Orc
    }

    enum ClassType
    {
        Warrior,
        Thief,
        Mage,
        Cleric,
        Ranger
    }
    internal class Characterstats
    {
        public string name { get; set; }
        public Species species { get; set; }
        public string gender { get; set; }
        public ClassType classType { get; set; }

        public int health { get; set; }
        public int strength { get; set; }
        public int agility { get; set; }
        public int intelligence { get; set; }
        public int charisma { get; set; }
        public int luck { get; set; }
        public int level { get; set; }
        public int xp { get; set; }

    }


}