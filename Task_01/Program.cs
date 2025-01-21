using System;


namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] spl = s.Split(' ');
            //Плата за тариф
            int A = Convert.ToInt16(spl[0]);
            //Кол-во мегабайт
            int B = Convert.ToInt16(spl[1]);
            //Цена за дополнительный мегбайт
            int C = Convert.ToInt16(spl[2]);
            //Кол-во мегабайт будет потрачено
            int D = Convert.ToInt16(spl[3]);

            int S;

            if (B >= D)
            {
                S = A;
            }
            else
            {
                S = A + ((D - B) * C);
            }
            Console.WriteLine(S);
        }
    }
}
