using System;

namespace EnumsAndSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.ForegroundColor.ToString());
            List<ToDo> myTasks = new List<ToDo>()
            {
                new ToDo() { Description = "Task 01", EstimatedHours = 4, TaskStatus = Status.Successful},
                new ToDo() { Description = "Task 02", EstimatedHours = 6, TaskStatus = Status.NotStarted},
                new ToDo() { Description = "Task 03", EstimatedHours = 8, TaskStatus = Status.Incomplete},
                new ToDo() { Description = "Task 04", EstimatedHours = 7, TaskStatus = Status.Completed},
                new ToDo() { Description = "Task 05", EstimatedHours = 5, TaskStatus = Status.Failed},
                new ToDo() { Description = "Task 06", EstimatedHours = 9, TaskStatus = Status.NotStarted},
                new ToDo() { Description = "Task 07", EstimatedHours = 3, TaskStatus = Status.Completed},
                new ToDo() { Description = "Task 08", EstimatedHours = 4, TaskStatus = Status.Incomplete},
                new ToDo() { Description = "Task 09", EstimatedHours = 2, TaskStatus = Status.Completed},
                new ToDo() { Description = "Task 10", EstimatedHours = 6, TaskStatus = Status.Successful}
            };

            ToDo.Display(myTasks);

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ReadLine();
        }
    }

    class ToDo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status TaskStatus { get; set; }

        public static void Display(List<ToDo> Tasks)
        {
            Console.WriteLine("Task information:");

            foreach (ToDo task in Tasks)
            {
                switch(task.TaskStatus)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case Status.Incomplete:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;

                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case Status.Failed:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;

                    case Status.Successful:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;

                    default:
                        break;
                }

                Console.WriteLine("{0} \t\t\t {1} \t\t\t {2}", task.Description, task.EstimatedHours, task.TaskStatus);
            }
        }
    }

    enum Status
    {
        NotStarted,
        Incomplete,
        Completed,
        Failed,
        Successful
    }
}

