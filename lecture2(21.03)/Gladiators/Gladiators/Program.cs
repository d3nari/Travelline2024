using Gladiators;
using Gladiators.Models.Armors;
using Gladiators.Models.Classes;
using Gladiators.Models.Fighters;
using Gladiators.Models.Races;
using Gladiators.Models.Weapons;

namespace Fighters
{
    public class Program
    {
        public static void Main()
        {

            int numberOfFighters = Creations.ReadNumberOfFighters();

            List<Fighter> fighters = new List<Fighter>();

            Fighter firstFighter = Creations.CreateFighter();
            fighters.Add(firstFighter);
            fighters[0].PrintFighterInfo();

            for (int i = 1; i < numberOfFighters; i++)
            {
                Fighter newFighter = Creations.CreateRandomFighter();
                fighters.Add(newFighter);
                fighters[i].PrintFighterInfo();
            }

            var gameMaster = new GameMaster(fighters);
            gameMaster.StartBattle();

        }
    }
}
