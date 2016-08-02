using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i.ToString() + " is an even number."); }
                else { Console.WriteLine(i.ToString() + " is an odd number."); }
            }
            
        }
    }
}
