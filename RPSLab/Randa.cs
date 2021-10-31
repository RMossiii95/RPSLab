using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class Randa : Player
    {
        public Randa() 
        {
            Name = "Randa";
        }
        public override RPSEnum GenerateRPS()
        {
            Random rand = new Random();
            int hand = 0;
            hand = rand.Next(0, 3);
            RPSEnum choice;
            switch (hand)
            {
                case 0:
                    choice = RPSEnum.Rock;
                    break;
                case 1:
                    choice = RPSEnum.Paper;
                    break;
                case 2:
                    choice = RPSEnum.Scissors;
                    break;
            }
            return GenerateRPS();

        }


    }
}

