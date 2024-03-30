namespace Gladiators.Models.Armors
{
    public class SteelArmor : IArmor 
    {
        public string Name { get; } = "Steel armor";

        public int Armor { get; } = 10;
    }
}
