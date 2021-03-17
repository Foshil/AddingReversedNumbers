using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases,a,b, reverse = 0, tmp, ro; //ro = ReverseOutput
            string input;
            string[] spliter;
            cases = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<cases; i++)
            {
                input = Console.ReadLine();
                spliter = input.Split(' ');
                a = Convert.ToInt32(spliter[0]);
                b = Convert.ToInt32(spliter[1]);
                reverse = 0;

                while(a!=0)
                {
                    tmp = a % 10;
                    reverse = reverse * 10 + tmp;
                    a /= 10;
                }
                a = reverse;
                reverse = 0;

                while(b!=0)
                {
                    tmp = b % 10;
                    reverse = reverse * 10 + tmp;
                    b /= 10;
                }
                b = reverse;
                reverse = 0;

                ro = a + b;
                while (ro != 0)
                {
                    tmp = ro % 10;
                    reverse = reverse * 10 + tmp;
                    ro /= 10;
                }
                ro = reverse;

                Console.WriteLine(ro);
            }//
        }
    }
}
