using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Learning the usage of 'if' statement.
            Console.WriteLine("Welcome to the GameShow.");
            Console.Write("Choose a number from 1, 2, 3: ");
            string choice = Console.ReadLine();

            if(choice == "2")
            {
                Console.WriteLine("Congratulations. You have won a million dollars.");
            }
            

            // Learning 'if-else'
            Console.WriteLine("Lets check if a number you enter is an odd or even number.");
            Console.Write("Type a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You entered " + x);
            if (x % 2 == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");
            
            // Learning with 'else-if' mid-constructs
            Console.WriteLine("Let's find out how lucky you are.");
            Console.Write("Type a number among 1, 2, or 3: ");

            string num = Console.ReadLine();
            
            if (num == "1")
                Console.WriteLine("Congrats! You should buy a lottery");
            else if (num == "2")
                Console.WriteLine("You are lucky enough to score in an exam.");
            else if (num == "3")
                Console.WriteLine("You have small chances with luck.");
            else
                Console.WriteLine("Sorry, invalid input provided.");

            // Let's learn some conditional and replacement techniques in WriteLine().
            Console.WriteLine("Now, out of three doors (1,2,3), one hides a luxury car and other two have nothing behind them.");
            Console.Write("Enter your choice: ");
            string Choice = Console.ReadLine();

            // conditional assignment - based on sole if-else logic
            string message = (Choice == "3") ? "Congrats! You won a luxury car." : "Alas! You lose.";

            // many other operators are similar to C/C++.
            // printing
            Console.WriteLine("Your result is: {0}", message);
            Console.WriteLine("Your choice is Door {0} and hence the result is {1}", Choice, message);

            // use {i} for ith variable printing.
            Console.ReadLine();
        }
    }
}

