using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Project_5
{
    class Program
    {
        static long gcd(long a, long b)
        {
            while (true)
            {
                if (a % b == 0) return b;
                var a1 = a;
                a = b;
                b = a1 % b;
            }
        }
        
        static long lcm(int n)
        {
            long answer = 1;
            for (long i = 1; i <= n; i++)
                answer = (answer * i) / (gcd(answer, i));
            return answer;
        }
        
        static void Main(string[] args)
        {
                Console.Write("Evenly Divisible By : ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(lcm(input));
                Console.ReadKey();
        }  
    }
}
