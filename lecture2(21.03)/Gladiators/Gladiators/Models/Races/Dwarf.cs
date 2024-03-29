namespace Gladiators.Models.Races
{
    public class Dwarf : IRace
    {
        public string Name { get; } = "Dwarf";

        public int Damage { get; } = 7;
        public int Health { get; } = 120;
        public int Armor { get; } = 12;
        public int Initiative { get; } = 5;
    }
}
