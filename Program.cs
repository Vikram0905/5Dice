using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Dice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press enter to Start Game");
            Console.ReadKey();
            Console.Clear();


            bool gameProg = false;
            while (gameProg == false)
            {
                Console.WriteLine("Press Enter to roll your 5 Dice");
                Console.ReadKey();
                Console.WriteLine();
                Dice.DiceGen();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    public class Dice
    {
        public static void DiceGen()
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 6 + 1);
            int dice2 = rnd.Next(1, 6 + 1);
            int dice3 = rnd.Next(1, 6 + 1);
            int dice4 = rnd.Next(1, 6 + 1);
            int dice5 = rnd.Next(1, 6 + 1);
            Console.WriteLine("You Rolled:");
            Console.WriteLine("Dice 1 :{0}", dice1);
            Console.WriteLine("Dice 2 :{0}", dice2);
            Console.WriteLine("Dice 3 :{0}", dice3);
            Console.WriteLine("Dice 4 :{0}", dice4);
            Console.WriteLine("Dice 5 :{0}", dice5);

            int sum = dice1 + dice2 + dice3 + dice4 + dice5;

            Console.WriteLine("Your Score: {0}", sum);
        }
    }
}
