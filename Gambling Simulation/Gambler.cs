using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulation
{
    public class Gambler
    {
        public static void GamblerWinOrLoose()      
        {
            const int STAKE = 100;
            const int BET = 1;
            const int LOSE = 0;
            const int WIN = 1;
            int totalAmount = 100;
            Random random = new Random();
            int option = random.Next(0, 2);
            switch (option)
            {
                case LOSE:
                    totalAmount = totalAmount - BET;
                    break;
                case WIN:
                    totalAmount = totalAmount + BET;
                    break;
            }
            Console.WriteLine("TotalAmount is " + totalAmount);
        }
    }
}
