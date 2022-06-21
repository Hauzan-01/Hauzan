using System;

namespace WeeklyProject
{
    class Program
    {
        static private List<Player> players = new List<Player>();
        static private IndianChef IndChef = new IndianChef();
        static private ItalianChef ItaChef = new ItalianChef();
        static private ChineseChef ChiChef = new ChineseChef();
        static void Main(string[] args)
        {
            Initialize();
            string key = "default";
            bool flag = true;

            do
            {
                HomePage();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Press X to quit the game. Any other key to continue.");
                key = Console.ReadLine();

                if(key=="x" || key=="X")
                {
                    flag = false;
                }
            } while (flag);

            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
        static void HomePage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            string name = "";
            Player p1;
            if (Player.usercount == 0)
            {
                Console.WriteLine("NEW USER");
                NewUser(ref name);
                p1 = new Player(name);
                players.Add(p1);
                Console.Clear();
            }
            else
            {
                p1 = players.Last();
                name = p1.name;
            }
            
            Console.WriteLine("Welcome to the GAME ZONE, {0}!", name);
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Game options:");
            Console.WriteLine("1. Predict the next number.");
            Console.WriteLine("2. Balloon Theft.");
            Console.WriteLine("3. Find the number of Trees in each row.");
            Console.WriteLine("4. Predict the operator.");
            Console.WriteLine("5. Making meals");
            Console.WriteLine();
            Console.WriteLine("User options:");
            Console.WriteLine("6. Change user name.");
            Console.WriteLine("7. Get total score.");
            Console.WriteLine();

            string choice;
            Console.Write("Enter a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PredictNext(p1);
                    break;

                case "2":
                    BalloonTheft(p1);
                    break;

                case "3":
                    FindTrees(p1);
                    break;

                case "4":
                    PredictOperator(p1);
                    break;

                case "5":
                    MakingMeals(p1);
                    break;

                case "6":
                    ChangeUserName(p1);
                    break;

                case "7":
                    Console.WriteLine("Your current score is: {0}", p1.GetScore());
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        static void NewUser(ref string name)
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }
        static void ChangeUserName(Player p)
        {
            players.Remove(p);
            
            string NewName;
            Console.WriteLine("Enter your new name.");
            NewName = Console.ReadLine();

            p.name = NewName;
            players.Add(p);
        }

        static void PredictNext(Player p)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User: {0} \t\t\t\t\t Score: {1}", p.name, p.GetScore());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the PREDICT NEXT NUMBER game.");

            Random rnd = new Random();
            int first = rnd.Next(-100, 100);
            int difference = rnd.Next(-25, 40);

            int i;
            for(i=0; i<5; i++)
            {
                Console.Write("{0} ", first + i*difference);
            }
            Console.Write("__?__");
            Console.WriteLine();
            Console.Write("Enter your answer: ");

            int ans;
            try
            {
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == first + i * difference)
                {
                    Console.WriteLine("Correct! You earned 10 points.");
                    p.SetScore(10);
                }
                else
                {
                    Console.WriteLine("Uh oh! You were wrong.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occurred. You entered an incorrect input format.");
            }

            Console.WriteLine("Press Y to play again or any key to exit this game.");
            string choice = Console.ReadLine();

            if(choice=="y" || choice=="Y")
            {
                PredictNext(p);
            }
            else
            {
                return;
            }
        }

        static void BalloonTheft(Player p)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User: {0} \t\t\t\t\t Score: {1}", p.name, p.GetScore());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to BALLOON THEFT game!");

            Random rnd = new Random();
            int first = rnd.Next(1, 31);
            int ratio = rnd.Next(2, 10);

            Console.WriteLine("A seagull is stealing balloons. The number of balloons he stole from Monday to Saturday " +
                "are given. You have to predict the number of balloons the gull steals on Sunday.");

            for(int i=1; i<7; i++)
            {
                Console.WriteLine("{0} ", first*Math.Pow(ratio, i-1));
            }

            int ans = Convert.ToInt32(first * Math.Pow(ratio, 6));
            int choice;

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == ans)
                {
                    Console.WriteLine("Correct! You earned 10 points.");
                    p.SetScore(10);
                }
                else
                {
                    Console.WriteLine("Uh oh! You were wrong.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. You entered an incorrect input format.");
            }

            Console.WriteLine("Press Y to play again or any key to exit this game.");
            string key = Console.ReadLine();

            if (key == "y" || key == "Y")
            {
                BalloonTheft(p);
            }
            else
            {
                return;
            }
        }
        static void FindTrees(Player p)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User: {0} \t\t\t\t\t Score: {1}", p.name, p.GetScore());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the FIND NUMBER OF TREES IN EACH ROW game.");

            Random rnd = new Random();
            int Rows = rnd.Next(1, 100);
            int TreesInEachRow = rnd.Next(5, 80);

            Console.WriteLine("A farmer wants to plant {0} trees in {1} rows such that each row contains the same number " +
                               "of trees. Can you specify the number of trees in each row? ____", Rows*TreesInEachRow, Rows);

            int ans;
            try
            {
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans == TreesInEachRow)
                {
                    Console.WriteLine("Correct! You earned 10 points.");
                    p.SetScore(10);
                }
                else
                {
                    Console.WriteLine("Uh oh! You were wrong.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred. You entered an incorrect input format.");
            }

            Console.WriteLine("Press Y to play again or any key to exit this game.");
            string choice = Console.ReadLine();

            if (choice == "y" || choice == "Y")
            {
                FindTrees(p);
            }
            else
            {
                return;
            }
        }

        static void PredictOperator(Player p)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User: {0} \t\t\t\t\t Score: {1}", p.name, p.GetScore());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to the PREDICT OPERATOR game!");

            Random rnd = new Random();
            int n1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 100);
            int op = rnd.Next(1, 5);

            Console.WriteLine("Operators:\n(1) + \n(2) - \n(3) x \n(4) /");
            Console.WriteLine("Can you guess the operator in the below equation? Press numbers between 1 and 4.");
            if(op==1)
            {
                Console.WriteLine("{0} _?_ {1} = {2}", n1, n2, n1 + n2);
            }
            else if (op == 2)
            {
                Console.WriteLine("{0} _?_ {1} = {2}", n1, n2, n1 - n2);
            }
            else if (op == 3)
            {
                Console.WriteLine("{0} _?_ {1} = {2}", n1, n2, n1 * n2);
            }
            else if (op == 4)
            {
                Console.WriteLine("{0} _?_ {1} = {2}", n1, n2, n1 / n2);
            }

            int choice;
            Console.Write("Enter your answer: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                if(choice == op)
                {
                    Console.WriteLine("Correct! You key 10 points.");
                    p.SetScore(10);
                }
                else
                {
                    Console.WriteLine("Uh oh! You were wrong.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occurred. You entered an incorrect input format.");
            }

            Console.WriteLine("Press Y to play again or any letter to exit this game.");
            string key = Console.ReadLine();

            if (key == "y" || key == "Y")
            {
                PredictOperator(p);
            }
            else
            {
                return;
            }
        }

        static void MakingMeals(Player p)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("User: {0} \t\t\t\t\t Score: {1}", p.name, p.GetScore());

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Welcome to the MAKING MEALS game!");

            Console.WriteLine("Choose one from the three cuisines below.");
            Console.WriteLine("(1) Indian \n(2) Italian \n(3) Chinese");
            Console.Write("Your choice: ");

            Random rnd = new Random();
            int cuisine;
            try
            {
                cuisine = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if(cuisine == 1)
                {
                    Console.WriteLine(IndChef.Description);
                    Console.WriteLine("Help me in making biryani by answering the two questions below correctly.");

                    Console.WriteLine();
                    Console.WriteLine("1) Which item can be used in biryani?");
                    Console.WriteLine("(a) Rice \t\t\t\t (b) Wheat");
                    Console.Write("Enter your answer: a or b -> ");
                    string choice = Console.ReadLine();

                    if(choice=="a" || choice == "A")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }

                    Console.WriteLine();
                    Console.WriteLine("2) Which item cannot be used in biryani?");
                    Console.WriteLine("(a) Chilly \t\t\t\t (b) Cheese");
                    Console.Write("Enter your answer: a or b -> ");
                    choice = Console.ReadLine();

                    if (choice == "b" || choice == "B")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }
                }
                else if(cuisine == 2)
                {
                    Console.WriteLine(ItaChef.Description);
                    Console.WriteLine("Help me in making pizza by answering the two questions below correctly.");

                    Console.WriteLine();
                    Console.WriteLine("1) Which vegetable is quite common to make sauce for pizza?");
                    Console.WriteLine("(a) Potato \t\t\t\t (b) Tomato");
                    Console.Write("Enter your answer: a or b -> ");
                    string choice = Console.ReadLine();

                    if (choice == "b" || choice == "B")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }

                    Console.WriteLine();
                    Console.WriteLine("2) Which item cannot be used in making pizza?");
                    Console.WriteLine("(a) Pineapple \t\t\t\t (b) Cheese");
                    Console.Write("Enter your answer: a or b -> ");
                    choice = Console.ReadLine();

                    if (choice == "a" || choice == "A")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }
                }
                else if (cuisine == 3)
                {
                    Console.WriteLine(ChiChef.Description);
                    Console.WriteLine("Help me in making noodles by answering the two questions below correctly.");

                    Console.WriteLine();
                    Console.WriteLine("1) Which is not a sauce used in Chinese cuisine?");
                    Console.WriteLine("(a) Schezwan \t\t\t\t (b) Mayo");
                    Console.Write("Enter your answer: a or b -> ");
                    string choice = Console.ReadLine();

                    if (choice == "b" || choice == "B")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }

                    Console.WriteLine();
                    Console.WriteLine("2) Which item is essentially added to Chinese recipes?");
                    Console.WriteLine("(a) Cheese \t\t\t\t (b) Garlic");
                    Console.Write("Enter your answer: a or b -> ");
                    choice = Console.ReadLine();

                    if (choice == "b" || choice == "B")
                    {
                        Console.WriteLine("Correct! You earned 5 points.");
                        p.SetScore(5);
                    }
                    else
                    {
                        Console.WriteLine("Uh oh! You were wrong.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong choice entered!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occurred. You entered an incorrect input format.");
            }
            Console.WriteLine("Press Y to play again or any key to exit this game.");
            string key = Console.ReadLine();

            if (key == "y" || key == "Y")
            {
                MakingMeals(p);
            }
            else
            {
                return;
            }
        }

        static void Initialize()
        {
            IndChef.Name = "Sohil";
            IndChef.Nationality = "Indian";
            IndChef.Description = "Hey! I am Sohil from India and my speciality is Biryani. Join me to dive " +
                "into the journey of flavors.";

            ItaChef.Name = "Paul";
            ItaChef.Nationality = "Italian";
            ItaChef.Description = "Ciao! I am Paul from Italy and we will make mouth-watering pizza together!";

            ChiChef.Name = "Jim-Jang";
            ChiChef.Nationality = "China";
            ChiChef.Description = "I am Jim-Jang from China and my speciality is everybody's favorite noodles.";
        }
    }
}

