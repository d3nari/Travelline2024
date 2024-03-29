namespace Gladiators.Models.Weapons
{
    public class NoWeapon : IWeapon
    {
        public string Name { get; } = "No weapon";

        public int Damage { get; } = 1;
    }
}
