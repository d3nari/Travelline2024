namespace Gladiators.Models.Classes
{
    public class Priest : IClass
    {
        public string Name { get; } = "Priest";
        public int Damage { get; } = 8;
        public int Health { get; } = 40;
        public int Initiative { get; } = 4;

    }
}
