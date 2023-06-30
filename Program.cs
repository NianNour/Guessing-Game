using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome !");
            do
            {
                Console.WriteLine("Which number do i have in my mind ? Can you guess?");
                int chance = 3;
                int guessCount = 0;
                Random random = new Random();
                int computerNumber = random.Next(0, 11); //maling a random number 
                while (guessCount < chance)
                {
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    if (userNumber == computerNumber) // the win situation :
                    {
                        Console.WriteLine("You beat me!");
                        break;
                    }
                    else if (computerNumber != userNumber && guessCount == 2) //checking the last input number : 
                    {
                        Console.WriteLine("\n **GAME OVER!** \n The number was : " + computerNumber);
                    }
                    guessCount++;
                }
                Console.WriteLine("Do want to try again? yes/no"); 
            }
            while (Console.ReadLine().ToUpper() == "YES");
        }
    }
}
