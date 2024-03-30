namespace Gladiators.Models.Classes
{
    public class Mage : IClass
    {
        public string Name { get; } = "Mage";
        public int Damage { get; } = 15;
        public int Health { get; } = 50;
        public int Initiative { get; } = 7;

    }
}
