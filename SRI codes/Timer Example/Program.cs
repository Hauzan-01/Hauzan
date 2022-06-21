using System;
using System.Timers;
using Timer = System.Timers.Timer;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);            // 2000 milliseconds = 2 seconds

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();
            
            Console.WriteLine("Press ENTER to to remove red event.");
            Console.ReadLine();
            myTimer.Elapsed -= MyTimer_Elapsed1;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
        }

    }
}