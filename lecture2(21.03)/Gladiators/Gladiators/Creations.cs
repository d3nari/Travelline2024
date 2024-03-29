using Gladiators.Models.Armors;
using Gladiators.Models.Classes;
using Gladiators.Models.Fighters;
using Gladiators.Models.Races;
using Gladiators.Models.Weapons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gladiators
{
    public class Creations
    {
        private static Random random = new Random();
        public static Fighter CreateFighter()
        {
            Console.Write("Enter fighter's name: ");
            string name = Console.ReadLine();

            IWeapon weapon = CreateWeapon();
            IRace race = CreateRace();
            IArmor armor = CreateArmor();
            IClass gameClass = CreateClass();

            Fighter newFighter = new Fighter(weapon, race, armor, gameClass, name);
            return newFighter;
        }

        private static IWeapon CreateWeapon()
        {
            Console.WriteLine("Choose a weapon:");
            Console.WriteLine("1. Sword");
            Console.WriteLine("2. Knife");
            Console.WriteLine("3. No weapon");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    return new Sword();
                case 2:
                    return new Knife();
                case 3:
                    return new NoWeapon();
                default:
                    return new NoWeapon(); // По умолчанию выбран меч
            }
        }

        private static IRace CreateRace()
        {
            Console.WriteLine("Choose a race:");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Elf");
            Console.WriteLine("3. Dwarf");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    return new Human();
                case 2:
                    return new Elf();
                case 3:
                    return new Dwarf();
                default:
                    return new Human(); // По умолчанию выбран человек
            }
        }

        private static IArmor CreateArmor()
        {
            Console.WriteLine("Choose an armor:");
            Console.WriteLine("1. Leather Armor");
            Console.WriteLine("2. Steel Armor");
            Console.WriteLine("3. No armor");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    return new LeatherArmor();
                case 2:
                    return new SteelArmor();
                case 3:
                    return new NoArmor();
                default:
                    return new NoArmor(); // По умолчанию выбрана легкая броня
            }
        }

        private static IClass CreateClass()
        {
            Console.WriteLine("Choose a class:");
            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Priest");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    return new Mage();
                case 2:
                    return new Priest();
                default:
                    return new Mage(); // По умолчанию выбран воин
            }
        }


        public static Fighter CreateRandomFighter()
        {
            string[] names = { "Aldric", "Elara", "Grom", "Luna", "Thalia", "Varian", "Charlie", "Dalhia" };
            string randomName = names[random.Next(names.Length)];

            IWeapon randomWeapon = GetRandomWeapon();
            IRace randomRace = GetRandomRace();
            IArmor randomArmor = GetRandomArmor();
            IClass randomClass = GetRandomClass();

            Fighter newFighter = new Fighter(randomWeapon, randomRace, randomArmor, randomClass, randomName);
            return newFighter;
        }

        private static IWeapon GetRandomWeapon()
        {
            IWeapon[] weapons = { new Sword(), new Knife(), new NoWeapon() };
            return weapons[random.Next(weapons.Length)];
        }

        private static IRace GetRandomRace()
        {
            IRace[] races = { new Human(), new Elf(), new Dwarf() };
            return races[random.Next(races.Length)];
        }

        private static IArmor GetRandomArmor()
        {
            IArmor[] armors = { new SteelArmor(), new LeatherArmor(), new NoArmor() };
            return armors[random.Next(armors.Length)];
        }

        private static IClass GetRandomClass()
        {
            IClass[] classes = { new Mage(), new Priest() };
            return classes[random.Next(classes.Length)];
        }

        private static int GetChoice(int maxChoice)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > maxChoice)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and " + maxChoice + ".");
            }
            return choice;
        }

        public static int ReadNumberOfFighters()
        {
            int numberOfFighters = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter the number of fighters: ");
                string input = Console.ReadLine();

                try
                {
                    numberOfFighters = int.Parse(input);
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return numberOfFighters;
        }
    }
}
