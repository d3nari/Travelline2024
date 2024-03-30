namespace Gladiators.Models.Weapons
{
    public class Knife : IWeapon
    {
        public string Name { get; } = "Knife";

        public int Damage { get; } = 3;
    }
}
