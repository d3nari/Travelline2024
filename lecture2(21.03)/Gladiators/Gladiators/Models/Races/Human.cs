﻿namespace Gladiators.Models.Races
{
    public class Human : IRace
    {
        public string Name { get; } = "Human";
        public int Damage { get; } = 10;
        public int Health { get; } = 100;
        public int Armor { get; } = 10;
        public int Initiative { get; } = 6;

    }
}
