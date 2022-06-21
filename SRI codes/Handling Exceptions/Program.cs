using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // For exceptions - try, catch, finally blocks
            try
            {
                string content = File.ReadAllText(@"D:\Exampl.txt");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine("The specified file \"{0}\" was not found. Make sure you named it correctly.", "Exampl.txt");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine("The specified directory was not found. Make sure the file path is correct.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was a problem.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // code to finalize
                // things like - set objects to null, close database connections, etc.
                Console.WriteLine("Closing application now.");
            }


            Console.ReadLine();
        }
    }
}
