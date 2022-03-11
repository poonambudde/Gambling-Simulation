using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulation
{
    public class Gambler
    {
        public const int stake = 100;
        public const int bet = 1;

        public static void GamblerWinOrLoose()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 1)
            {
                Console.WriteLine("you won the game $1");
            }
            else
            {
                Console.WriteLine("you lost the game $1");
            }
        }
    }
}
