using Gladiators.Models.Armors;
using Gladiators.Models.Classes;
using Gladiators.Models.Races;
using Gladiators.Models.Weapons;
using System;

namespace Gladiators.Models.Fighters
{
    public class Fighter : IFighter
    {
        public string Name { get; }
        public int MaxHealth => Race.Health + Class.Health;
        public int MaxArmor => Race.Armor + Armor.Armor;
        public int Initiative => Race.Initiative + Class.Initiative;
        public int CurrentHealth { get; private set; }

        public IWeapon Weapon { get; }

        public IRace Race { get; }

        public IArmor Armor { get; }

        public IClass Class { get; }

        public Fighter(IWeapon weapon, IRace race, IArmor armor, IClass gameClass, string name)
        {
            Weapon = weapon;
            Race = race;
            Armor = armor;
            Class = gameClass;
            CurrentHealth = MaxHealth;
            Name = name;
        }

        public int CalculateDamage()
        {
            Random random = new Random();
            int baseDamage = Race.Damage + Weapon.Damage + Class.Damage;
            double criticalChance = 0.15; 
            double criticalMultiplier = 2; 
            double randomFactor = 1 - 0.15 + (random.NextDouble() * 0.3); 

            if (random.NextDouble() < criticalChance)
            {
                return (int)(baseDamage * criticalMultiplier * randomFactor);
            }
            else
            {
                return (int)(baseDamage * randomFactor);
            }
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= Math.Max(damage - MaxArmor, 0);
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void PrintFighterInfo()
        {
            Console.WriteLine($"Name: {Name}, Class: {Class.Name}, Race: {Race.Name}, Weapon: {Weapon.Name}, Armor: {Armor.Name}, Health: {MaxHealth}, Initiative: {Initiative}");
        }
    }
}
