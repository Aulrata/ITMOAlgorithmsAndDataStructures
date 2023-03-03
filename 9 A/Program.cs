using System;

namespace _9_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary;

            for (int i = 0; i < Math.Pow(2,n); i++)
            {
                binary = Convert.ToString(GetGrey(i),2);

                while(binary.Length != n) 
                {
                    binary = "0" + binary;
                }

                Console.WriteLine(binary);
            }
            Console.ReadLine();
        }

        static int GetGrey(int x)
        {
            return x ^ (x >> 1);
        }
    }
}
