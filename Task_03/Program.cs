using System;
using System.Linq;


namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, t, x, L, answer;
            int[] n_t = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            n = n_t[0];
            //Время, через которое уйдёт выбраный человек
            t = n_t[1];
            int[] floors = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            x = int.Parse(Console.ReadLine()) - 1;
            L = floors.Length - 1;

            if (t > floors[x] - floors[0] || t > floors[L] - floors[x])
            {
                answer = floors[L] - floors[0];
            }
            else if (floors[x] - floors[0] > floors[L] - floors[x])
            {
                answer = (floors[L] - floors[x]) * 2 + floors[x] - floors[0];
            }
            else
            {
                answer = (floors[x] - floors[0]) * 2 + floors[L] - floors[x];
            }

            Console.WriteLine(answer);
        }
    }
}
