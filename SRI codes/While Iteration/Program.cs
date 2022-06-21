using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;

            while(play)
            {
                play = MainMenu();
            }

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }

        private static bool MainMenu()
        {
            Console.Clear();            // this clears out output screen.
            Console.WriteLine("Welcome, it's time to play some games. Choose your option among the following.");
            Console.WriteLine("1. Printing numbers");
            Console.WriteLine("2. Getting multiples");
            Console.WriteLine("3. Guessing numbers");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());     // way to convert string to int
            if (choice == 1)
            {
                PrintNumbers();
            }
            else if (choice == 2)
            {
                Multiples();
            }
            else if (choice == 3)
            {
                GuessNumbers();
            }
            else if (choice == 4)
                return false;
            
            return true;
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Printing Numbers game!");
            Console.Write("Type a number: ");
            
            int n = int.Parse(Console.ReadLine());
            int counter = 1;

            Console.WriteLine("Output:");
            while(counter <= n)
            {
                if(counter == n)
                {
                    Console.WriteLine(counter);
                }
                else
                    Console.Write("{0} ", counter);
                counter++;
            }

            Console.ReadLine();
        }

        private static void Multiples()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Multiples games.");
            Console.Write("Enter a number whose multiples you need. ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Enter how many multiples of it you want. ");
            int multiples = int.Parse(Console.ReadLine());

            for (int i = 1; i <= multiples; i++)
                Console.WriteLine("{0} x {1} = {2}", num, i, num*i);

            Console.ReadLine();
        }
        private static void GuessNumbers()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the guessing number game!");

            Random myRandom = new Random();
            int randomNum = myRandom.Next(1, 11);       // give a random number from 1  to 11-1.

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Enter your guess of a number from 1 to 10.");
                string choice = Console.ReadLine();
                guesses++;

                if (choice == randomNum.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong! Try again.");
            } while (incorrect);

            Console.WriteLine("Yay, you did it. It took you {0} guesses.", guesses);
            Console.ReadLine();
        }

    }
}

