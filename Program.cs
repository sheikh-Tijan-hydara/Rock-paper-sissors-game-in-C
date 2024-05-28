using System;
namespace RockPaperSissors{
    public class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! Game");
            Console.WriteLine("*********************************");
            Console.WriteLine("Here are the list of options");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4: Exit");
            Console.WriteLine("*********************************");
            Console.WriteLine("Please enter your choice: ");
            int userChoice = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            while (userChoice != 4)
            {
            if (userChoice == randomNumber)
            {
                Console.WriteLine("Haaaaaaa! It's a tie!");
            }
            else if ((userChoice == 1 && randomNumber == 2) ||
                 (userChoice == 2 && randomNumber == 3) ||
                 (userChoice == 3 && randomNumber == 1))
            {
                Console.WriteLine("Ooooh You lose!");
            }
            else if ((userChoice == 1 && randomNumber == 3) ||
                 (userChoice == 2 && randomNumber == 1) ||
                 (userChoice == 3 && randomNumber == 2))
            {
                Console.WriteLine("Wooooo you won!");
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Let's play again!");
            Console.WriteLine("*********************************");
            Console.WriteLine("Here are the list of options");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4: Exit");

            Console.WriteLine("Please enter your choice: ");
            userChoice = int.Parse(Console.ReadLine());
            randomNumber = random.Next(1, 4);
            }
        }
    }
}