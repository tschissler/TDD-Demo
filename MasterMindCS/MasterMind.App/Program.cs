using System;
using System.Text;

namespace MasterMind.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the great game of MasterMind!");
            Console.WriteLine();
            Console.WriteLine("Which level do you want to play (1-9)?");

            int level;
            do
            {
                var levelChar = Console.ReadKey().KeyChar;
                int.TryParse(levelChar.ToString(), out level);
            } while (level < 1 || level > 9);

            Console.WriteLine();
            Console.WriteLine();

            char upperOption = (char)('A' + level + 2);
            Console.WriteLine($"Great, we will play on level {level}. This means the options for each position are 'A' - '{upperOption}'");
            Console.WriteLine();
            Console.WriteLine("I have received the code. It has 4 positions. Please start your quest in guessing it.");

            bool codeCorrect = false;
            int round = 1;

            var code = MasterMindLogic.ReceiveCode(level);
            string input;

            do
            {
                Console.WriteLine($"--- Round {round} ---");
                Console.Write("Enter your guess (4 positions): ");
                input = Console.ReadLine().ToUpper();
                Console.WriteLine($"Your guess delivers this result (C=correct input | P=correct position): {MasterMindLogic.GetGuessFeedback(code, input)}");
                round++;
            } while (input != code);

            Console.WriteLine();
            Console.WriteLine("###############################################################");
            Console.WriteLine("Congratulations, you found the secret code!");
            Console.WriteLine($"It took you {round-1} rounds.");
            Console.WriteLine("###############################################################");
        }
    }
}
