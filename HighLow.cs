using System;
namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int guess = 0;
            int number = rnd.Next(1, 100);

            Console.Write("Guess the number between 1 / 100 : ");

            while (guess != number)
            {
                guess = int.Parse(Console.ReadLine());

                Console.WriteLine(guess > number ? $"{guess} is too high!" : $"{guess} is too low!");
            }
            Console.WriteLine("You win! Press any key to exit");
            Console.ReadKey();
        }
    }
}
