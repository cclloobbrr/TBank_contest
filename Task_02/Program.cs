using System;


namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = Convert.ToInt32(Console.ReadLine());
            int answer = (people + 1) / 2;
            Console.WriteLine(answer);
        }
    }
}
