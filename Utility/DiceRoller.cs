using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature_Manager
{
    public class DiceRoller
    {

        public static int RollDice(int amountOfDice, int dieSides){

            int finalCount = 0;

            Random rng = new Random();

            for (int i = 0; i < amountOfDice; i++) {
                finalCount += rng.Next(1, dieSides + 1);
            }
            
            return finalCount;

        }

    }
}
