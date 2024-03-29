﻿using Gladiators.Models.Armors;
using Gladiators.Models.Classes;
using Gladiators.Models.Races;
using Gladiators.Models.Weapons;

namespace Gladiators.Models.Fighters
{
    public interface IFighter
    {
        public string Name { get; }
        public int MaxHealth { get; }
        public int CurrentHealth { get; }
        public int Initiative { get; }

        public IWeapon Weapon { get; }
        public IRace Race { get; }
        public IArmor Armor { get; }
        public IClass Class { get; }

        public void TakeDamage(int damage);
        public int CalculateDamage();
        public void PrintFighterInfo();
    }
}
