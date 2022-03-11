using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling_Simulation
{
    public class Gambler
    {
        const int STAKE = 100;
        const int BET = 1;
        const int LOSE = 0;
        const int WIN = 1;
        int totalAmount = 100;
        public void GamblerWinOrLoose()
        {

            Random random = new Random();
            int option = random.Next(0, 2);
            while (totalAmount > 50 && totalAmount < 150)
            {
                switch (option)
                {
                    case LOSE:
                        totalAmount = totalAmount - BET;
                        break;
                    case WIN:
                        totalAmount = totalAmount + BET;
                        break;
                }
            }
            Console.WriteLine("TotalAmount is :- " + totalAmount);
        }
    }
}
