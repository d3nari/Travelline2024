using System;
using System.Collections.Generic;
using System.Linq;

namespace Gladiators.Models.Fighters
{
    public class GameMaster
    {
        private List<Fighter> fighters;
        private int currentRound = 1;

        public GameMaster(List<Fighter> fighters)
        {
            this.fighters = fighters;
        }

        public bool IsDefeated(Fighter fighter)
        {
            return fighter.CurrentHealth <= 0;
        }

        public void StartBattle()
        {
            Random random = new Random();
            List<Fighter> fightersCopy = new List<Fighter>(fighters);
            List<Fighter> defeatedFighters = new List<Fighter>();

            while (fightersCopy.Count > 1)
            {
                Console.WriteLine($"Round {currentRound}:");

                fightersCopy = fightersCopy.OrderByDescending(f => f.Initiative).ToList();

                foreach (Fighter attacker in fightersCopy)
                {
                    //выбор подходящей цели для атаки
                    if(!defeatedFighters.Contains(attacker))
                    {
                        Fighter target = fightersCopy[random.Next(fightersCopy.Count)];
                        while (attacker == target || defeatedFighters.Contains(target))
                        {
                            target = fightersCopy[random.Next(fightersCopy.Count)];
                        }

                        AttackAndCheckIfOpponentDead(attacker, target);

                        if (IsDefeated(target))
                        {
                            defeatedFighters.Add(target);
                        }
                    }
                }

                foreach (Fighter defeatedFighter in defeatedFighters)
                {
                    fightersCopy.Remove(defeatedFighter);
                }

                currentRound++;
            }

            Console.WriteLine($"{fightersCopy[0].Name} is the last fighter standing!");
        }

        public void AttackAndCheckIfOpponentDead(Fighter attacker, Fighter target)
        {
            int damage = attacker.CalculateDamage();
            target.TakeDamage(damage);

            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage. {target.Name}'s health: {target.CurrentHealth}");

            if (IsDefeated(target))
            {
                Console.WriteLine($"{target.Name} has been defeated!");
            }
        }

    }
}
