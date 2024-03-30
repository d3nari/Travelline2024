namespace Gladiators.Models.Races
{
    public class Elf : IRace
    {
        public string Name { get; } = "Elf";

        public int Damage { get; } = 10;
        public int Health { get; } = 90;
        public int Armor { get; } = 8;
        public int Initiative { get; } = 8;

    }
}
