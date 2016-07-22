using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("This is line number " + i.ToString() + ", at " + DateTime.Now);
            }
        }
    }
}
