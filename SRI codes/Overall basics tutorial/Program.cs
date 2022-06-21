using System;
using System.Text;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //---> Basic introduction
            /*
            Console.WriteLine("Hello world!");
            */

            //---> Variables
            /*
            string characterName = "David";
            int characterAge;
            characterAge = 30;

            Console.WriteLine("There was once a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");
            */

            //---> Data Types
            /*
            string str = "What's up?";
            char ch = 'e';
            int num = -98;
            double d = 34.567;
            bool flag = true;
            */

            //---> Working with strings
            /*
            Console.WriteLine("Big Language!");
            Console.WriteLine("Big\nLanguage!");
            Console.WriteLine("Big" + "Language!");
            Console.WriteLine("Big\"Language");
            Console.WriteLine("Big\\Language");
            Console.WriteLine(@"C:\Data\bigfile.txt");

            Console.WriteLine();
            string str = "This code " + "is so cool!";
            Console.WriteLine(str);
            Console.WriteLine("string's length = " + str.Length);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            Console.WriteLine("'cool' exists in str? : " + str.Contains("cool"));
            Console.WriteLine(str.Substring(5, 4));
            Console.WriteLine(str.Split(" ")[0]);
            Console.WriteLine("IndexOf(): " + str.IndexOf("so"));
            Console.WriteLine("Element 1: " + str[0]);
            Console.WriteLine("Element 7: " + str[6]);
            */

            //---> Working with numbers
            /*
            Console.WriteLine(-53.456);
            Console.WriteLine(5.4 + 7);
            Console.WriteLine(23.9 - 45);
            Console.WriteLine(4 * 9);
            Console.WriteLine(22/8);
            Console.WriteLine(245 % 45);
            Console.WriteLine(4 + 9/3);
            Console.WriteLine((4 + 9)/3);

            Console.WriteLine(Math.Abs(-56.5));
            Console.WriteLine(Math.Pow(4.5, 3));
            Console.WriteLine(Math.Sqrt(56));
            Console.WriteLine(Math.Min(5, -9));
            Console.WriteLine(Math.Max(45, 23));
            Console.WriteLine(Math.Round(4.56));
            */

            //---> Getting User Input
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ".");
            */

            //---> Building Basic Calculator
            /*
            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            */

            //---> Building a Mad Libs Game
            /*
            string color, sport, dish;
            Console.Write("Enter your color: ");
            color = Console.ReadLine();

            Console.Write("Enter your sport: ");
            sport = Console.ReadLine();

            Console.Write("Enter your dish: ");
            dish = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine("Children play " + sport);
            Console.WriteLine("I love " + dish);
            */

            //---> Arrays
            /*
            int[] myFavNumbers = { 5, 7, 25, 34, 78 };
            myFavNumbers[3] = 43;
            Console.Write("Favorite numbers: ");
            for (int i = 0; i < myFavNumbers.Length; i++)
            {
                Console.Write(myFavNumbers[i] + " ");
            }
            Console.WriteLine();

            string[] names = new string[5] { "Ben", "Karl", "Paul", "David", "Josh" };
            Console.Write("People: ");
            foreach(string name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            */

            //---> Methods/Functions and Return Statement
            /*
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            SayHi(name);

            int number = 6;
            Console.WriteLine("Is " + number + " prime? " + IsPrime(number));
            */

            //---> If-else blocks
            /*
            bool isMale = false;
            bool isTall = true;

            if(isMale && isTall)
            {
                Console.WriteLine("You are male and tall.");
            }
            else if(isMale && !isTall)
            {
                Console.WriteLine("You are male and not tall.");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are not male and tall.");
            }
            else
            {
                Console.WriteLine("You are not male and not tall.");
            }

            double num1 = 23, num2 = 76;
            Compare(num1, num2);
            */

            //---> Building a better calculator.
            /*
            string key = "y";
            do
            {
                Calculator();
                Console.WriteLine("Press 'n' and ENTER to exit. Or any other key to continue.");
                key = Console.ReadLine();

            } while (key!="n");
            */

            //---> Switch statement
            /*
            int dayNum = 3;
            Console.WriteLine(GetDay(dayNum));
            */

            //---> While loop
            /*
            int index = 1;
            Console.WriteLine("Output of while:");
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            index = 6;
            Console.WriteLine("Output of do-while:");
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            */

            //---> Building a Guessing Game.
            /*
            string secretWord = "magic";
            string guess = "";
            int maxGuesses = 3;

            do
            {
                Console.WriteLine("Guesses left : {0}", maxGuesses);
                Console.Write("Enter your guess: ");
                guess = Console.ReadLine();

                if (guess != secretWord)
                {
                    maxGuesses--;
                    Console.WriteLine("Uh oh, wrong guess. Try again!");
                }
            } while (maxGuesses>0 && guess != secretWord);
            if(maxGuesses > 0)
            {
                Console.WriteLine("Yup! You guessed correctly.");
            }
            else
            {
                Console.WriteLine("You lose. Guess limit reached.");
            }
            */

            //---> For loops
            /*
            int[] arr = { 1, 3, 7, -7, 3, 6 };
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            */

            //---> Building an exponent function (using a for loop)
            /*
            double Base, Exponent;
            Console.WriteLine("Enter the base : ");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the exponent : ");
            Exponent = Convert.ToDouble(Console.ReadLine());

            double result = Power(Base, Exponent);
            Console.WriteLine("Output: " + result);
            */

            //---> 2D arrays
            /*
            int[,] Grid = { { 1, 2}, { 3, 4}, { 5, 6} };
            Console.WriteLine(Grid[0,1]);

            int[,] matrix = new int[3, 3];
            matrix.Initialize();

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            */

            //---> Comments
            // a single line comment using //
            /*
                a
            multi -line
            comment
            */

            //---> Exception Handling
            /*
            // exceptions like divide by 0, type conversion from char to int, etc.
            try
            {
                int a, b;
                Console.Write("Enter one number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This is always executed.");
            }
            */

            //---> Classes and Objects
            /*
            Book book1 = new Book("Harry Porter", "JK Rowling", 359);
            Console.WriteLine("Book1: " + book1.title + " " + book1.author + " " + book1.pages);

            Book book2 = new Book("Panchatantra", "Vishnu Sharma", 234);
            Console.WriteLine("Book2: " + book2.title + " " + book2.author + " " + book2.pages);
            */

            //---> Object Methods
            /*
            Student student1 = new Student("Jacob", "Arts", 7.8);
            Student student2 = new Student("Mary", "Chemistry", 6.7);
            Console.WriteLine("{0} and {1}", student1.HasHonors(), student2.HasHonors());
            */

            //---> Getters and Setters
            /*
            Movie m1 = new Movie("Who killed me?", "JD Ross", "Dog");
            Movie m2 = new Movie("The Curse of Him", "DM Karl", "PG");
            // allowed ratings - G, PG, PG-13, R, NR
            Console.WriteLine("{0} {1}.", m1.Rating, m2.Rating);
            */

            //---> Static class attributes
            /*
            Song money = new Song("Money", "WE Ronald", 6);
            Song dj = new Song("DJ Call", "BD Shawn", 4);

            Console.WriteLine(Song.songCount);
            */

            //---> Static Methods and Classes
            /*
            UsefulTools.Greet("Sonic");
            */

            //---> Inheritance and virtual/override methods
            /*
            Chef c1 = new Chef();
            c1.MakeChicken();
            c1.MakeSpecialDish();
            Console.WriteLine();

            ItalianChef ic1 = new ItalianChef();
            ic1.MakeChicken();
            ic1.MakePasta();
            ic1.MakeSpecialDish();
            */

            Console.ReadLine();
        }

        static double Power(double Base, double Exponent)
        {
            double result = 1;

            for(int i=1; i<=Exponent; i++)
            {
                result = result * Base;
            }

            return result;
        }
        static string GetDay(int dayNum)
        {
            string day;
            switch (dayNum)
            {
                case 0:
                    day = "Sunday";
                    break;

                case 1:
                    day = "Monday";
                    break;

                case 2:
                    day = "Tuesday";
                    break;

                case 3:
                    day = "Wednesday";
                    break;

                case 4:
                    day = "Thursday";
                    break;

                case 5:
                    day = "Friday";
                    break;

                case 6:
                    day = "Saturday";
                    break;

                default:
                    day = "Invalid day number";
                    break;
            }
            return day;
        }
        static void Calculator()
        {
            Console.WriteLine("Welcome!");

            double num1, num2;

            Console.WriteLine("Enter proper choice for your operation.");
            Console.WriteLine("1. a + b");
            Console.WriteLine("2. a - b");
            Console.WriteLine("3. a * b");
            Console.WriteLine("4. a / b");
            Console.WriteLine("5. a % b");
            Console.WriteLine("6. a ^ b (power operation)");
            Console.WriteLine("7. sqrt(a)");

            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", num1 + num2);
            }
            else if(choice == "2")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", num1 - num2);
            }
            else if (choice == "3")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", num1 * num2);
            }
            else if (choice == "4")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", num1 / num2);
            }
            else if (choice == "5")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", num1 % num2);
            }
            else if (choice == "6")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", Math.Pow(num1, num2));
            }
            else if (choice == "7")
            {
                Console.Write("Enter one number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Result = {0}", Math.Sqrt(num1));
            }
            else
            {
                Console.WriteLine("Invalid choice entered.");  
            }
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name + ". Welcome!");
        }

        static bool IsPrime(int num)
        {
            if(num < 2)
                return false;
            if(num == 2)
                return true;

            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                    return false;
            }

            return true;
        }

        static void Compare(double a, double b)
        {
            if (a > b)
                Console.WriteLine("{0} is greater than {1}.", a, b);
            else if (b > a)
                Console.WriteLine("{0} is greater than {1}.", b, a);
            else
                Console.WriteLine("Both are equal to {0}.", a);
        }
    }
}

