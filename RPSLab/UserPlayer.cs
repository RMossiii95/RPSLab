using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class UserPlayer : Player
    {
        

        public UserPlayer()
        {
            this.Name = Name;
        }

        

        public override RPSEnum GenerateRPS()
        {
            Console.WriteLine("Please select rock paper or scissor (or r p or s for short");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I'm sorry I do not understand your input, please try again!");
                    return GenerateRPS();

            }
        }
    }
}
