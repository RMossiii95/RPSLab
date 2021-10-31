using System;

namespace RockPaperScissorsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new RPSLab.RPSApp();
            game.Game();
        }
        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public static int GetInputInt(string prompt)
        {
            while (true)
            {
                string response = GetInput(prompt);
                try
                {
                    return int.Parse(response);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please input an int.");
                    continue;
                }
            }

        }
    }
}