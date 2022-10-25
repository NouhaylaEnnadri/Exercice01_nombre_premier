using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            do
            {
                Console.WriteLine("Entrer un nombre:");
                num1 = Convert.ToInt32(Console.ReadLine());

            } while (num1 <= 0);

            if (IsPrime(num1)) { Console.WriteLine("est premier"); }
            else
            {
                Console.WriteLine("Pas Premier");

            }
            Console.ReadLine();

        }
        public static bool IsPrime(int num)
        {

            bool isPrime = true;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;

                }

            }
            return isPrime;
        }
    }
}

