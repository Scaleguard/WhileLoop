using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int myRandomNumber = rnd.Next(1, 11);
            //Console.Write($"Your number is {myRandomNumber}");
            Console.WriteLine("What is my number from 1 to 10: ");
            int userGuess = Int32.Parse(Console.ReadLine());

            if(myRandomNumber == userGuess)
            {
                Console.WriteLine("Congratulations! You've played me!");
            }else
            {
                Console.WriteLine("Heheehehehheheeheh, you failed! Try again ya wee bastard!");
            }
        }
    }
}
