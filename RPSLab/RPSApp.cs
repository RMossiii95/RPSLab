using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();        
        public Player Opponent { get; set; }

        
        public RPSApp()
        {
            //Later on once we have randa, replace this line with code that 
            //Let's the player choose their opponent 
            


        }
        public void Game()
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors Game!");
            Selection();
            bool goOn = true;
            while (goOn)
            {
                Play();                
            }
            Play();
        }
        public Player Selection()
        {
            Player randa = new Randa();
            Player rocky = new Rocky();
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    {
                        Console.WriteLine("Your opponent will be Randa!");
                        return Opponent = randa;
                    }
                case "2":
                    {
                        Console.WriteLine("Your opponent will be Rocky");
                        return Opponent = rocky;
                    }
                default:
                    {
                        Console.WriteLine("That answer is not correct, please choose between 1 for Randa or 2 for Rocky");
                        return Selection();
                    }
            }
        }
        public Player Play()
        {
            RPSEnum p1 = Player.GenerateRPS();
            RPSEnum p2 = Opponent.GenerateRPS();
            Player winner = null;
            //This cuts out all the draw cases now we just have to worry about 
            //Wins/Loses
            if (p1 == p2)
            {
                Console.WriteLine("Draw!");
                Console.WriteLine("Both Players threw the same value");
                return Play();
                
            }
            else if (p1 == RPSEnum.Rock)
            {
                if (p2 == RPSEnum.Paper)
                {
                    Console.WriteLine(Player.Name + " loses");
                    Console.WriteLine(Opponent.Name + " wins");
                    return Opponent;
                    
                }
            }
            else if (p1 == RPSEnum.Rock && p2 == RPSEnum.Scissors)
            {
                Console.WriteLine(Player.Name + " wins!");
                Console.WriteLine(Opponent.Name + " loses.");
                return Player;
            }
            else if (p1 == RPSEnum.Paper && p2 == RPSEnum.Scissors)
            {
                Console.WriteLine(Player.Name + " loses");
                Console.WriteLine(Opponent.Name + " wins");
                return Opponent;
            }
            else if (p1 == RPSEnum.Paper && p2 == RPSEnum.Rock)
            {
                Console.WriteLine(Player.Name + " wins!");
                Console.WriteLine(Opponent.Name + " loses.");
                return Player;
            }
            else if (p1 == RPSEnum.Scissors && p2 == RPSEnum.Rock)
            {
                Console.WriteLine(Player.Name + " loses");
                Console.WriteLine(Opponent.Name + " wins");
                return Opponent;
            }
            else if (p1 == RPSEnum.Scissors && p2 == RPSEnum.Paper)
            {
                Console.WriteLine(Player.Name + " wins!");
                Console.WriteLine(Opponent.Name + " loses.");
                return Player;
            }
            return Play();
        }

    }
}