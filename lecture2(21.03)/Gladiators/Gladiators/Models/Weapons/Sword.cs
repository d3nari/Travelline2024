﻿namespace Gladiators.Models.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; } = "Sword";

        public int Damage { get; } = 5;
    }
}
