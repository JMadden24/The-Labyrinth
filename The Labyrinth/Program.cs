using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace The_Labyrinth
{
    internal class Program
    {
        static Characterstats character = new Characterstats();
        static Random diceroll = new Random();
        static void Main(string[] args)
        {
            SetupCharacter();

            DisplayCharacterStats();
            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }

        static void DisplayCharacterStats()
        {
            Console.Clear();
            Console.WriteLine(character.name);
            Console.WriteLine(character.species + " " + character.classType);
            Console.WriteLine("Health: " + character.health);
            Console.WriteLine("Strength: " + character.strength + " | Agility: " + character.agility + " | Intelligence: " + character.intelligence + " | Charisma: " + character.charisma + " | Luck: " + character.luck);
            Console.WriteLine("Level: " + character.level + " | XP: " + character.xp + "/" + (character.level * 10));
        }

        static void SetupCharacter()
        {
            Console.WriteLine("Welcome Player.");

            //set player name
            Console.Write("Enter your name: ");
            character.name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Welcome " + character.name);

            //set player gender
            Console.WriteLine("Choose your gender:\n1: Male\n2: Female");
            int genderselect = getintinput(1, 2);
            if (genderselect == 1)
            {
                character.gender = "Male";
            }
            else
            {
                character.gender = "Female";
            }
            Console.Clear();

            //set player species
            Console.WriteLine("Choose your species:\n1: Human\n2: Elf\n3: Dwarf\n4: Orc");
            int speciesselect = getintinput(1, 4);
            if (speciesselect == 1)
            {
                character.species = Species.Human;
            }
            else if (speciesselect == 2)
            {
                character.species = Species.Elf;
            }
            else if (speciesselect == 3)
            {
                character.species = Species.Dwarf;
            }
            else
            {
                character.species = Species.Orc;
            }

            Console.Clear();

            //set player class
            Console.WriteLine("Choose your class:\n1: Warrior\n2: Thief\n3: Mage\n4: Cleric\n5: Ranger");
            int classselect = getintinput(1, 5);
            if (classselect == 1)
            {
                character.classType = ClassType.Warrior;
            }
            else if (classselect == 2)
            {
                character.classType = ClassType.Thief;
            }
            else if (classselect == 3)
            {
                character.classType = ClassType.Mage;
            }
            else if (classselect == 4)
            {
                character.classType = ClassType.Cleric;
            }
            else
            {
                character.classType = ClassType.Ranger;
            }
            Console.Clear();

            Console.WriteLine("You are " + character.name + " the " + character.species + " " + character.classType + "\nPress any key to roll stats: ");
            Console.ReadKey();



            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Rolling dice.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Rolling dice..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Rolling dice...");
                Thread.Sleep(500);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Adding total.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Adding total..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Adding total...");
                Thread.Sleep(500);
            }

            character.strength = rollmultidice(4, 6);
            character.agility = rollmultidice(4, 6);
            character.intelligence = rollmultidice(4, 6);
            character.charisma = rollmultidice(4, 6);
            character.luck = rollmultidice(4, 6);

            //add species based modifiers
            if (character.species == Species.Human)
            {
                character.health = 25;
            }
            else if (character.species == Species.Elf)
            {
                character.health = 20;
                character.agility += 3;
                character.charisma += 5;
            }
            else if (character.species == Species.Dwarf)
            {
                character.health = 30;
                character.strength += 3;
                character.luck += 3;
            }
            else
            {
                character.health = 35;
                character.strength += 5;
                character.intelligence -= 5;
            }


            character.level = 1;
            character.xp = 0;

            //set class based modifiers
            if (character.classType == ClassType.Warrior)
            {
                character.strength += 5;
                character.intelligence -= 2;
            }
            else if (character.classType == ClassType.Thief)
            {
                character.agility += 5;
                character.luck += 5;
                character.strength -= 2;
            }
            else if (character.classType == ClassType.Mage)
            {
                character.agility += 5;
                character.intelligence += 5;
                character.strength -= 5;
            }
            else if (character.classType == ClassType.Cleric)
            {
                character.charisma += 5;
                character.luck += 5;
            }
            else
            {
                character.agility += 3;
                character.strength += 3;
            }

            //sets to a default value if values fall below 0
            if (character.strength <= 0)
            {
                character.strength = 3;
            }
            if (character.agility <= 0)
            {
                character.agility = 3;
            }
            if (character.intelligence <= 0)
            {
                character.intelligence = 3;
            }
            if (character.charisma <= 0)
            {
                character.charisma = 3;
            }
            if (character.luck <= 0)
            {
                character.luck = 3;
            }
        }

        static int rollmultidice(int numberofdice, int dicenumber)
        {
            int totaldiceroll = 0;

            for (int i = 0; i < numberofdice; i++)
            {
                totaldiceroll += diceroll.Next(1, dicenumber + 1);
            }

            return totaldiceroll;
        }

        static int getintinput(int min, int max)
        {
            string choice = "0";
            int output;
            while (true)
            {
                Console.Write("Please enter a number between " + min + " and " + max + ": ");
                choice = Console.ReadLine();
                while (!int.TryParse(choice, out output))
                {
                    Console.Write("Please enter a valid number: ");
                    choice = Console.ReadLine();
                }
                if (int.Parse(choice) >= min && int.Parse(choice) <= max)
                {
                    output = int.Parse(choice);
                    break;
                }
            }
            return output;
        }

    }
}
