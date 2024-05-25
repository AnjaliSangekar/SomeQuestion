using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeBasicQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            removeChar();
            Console.WriteLine();
            swapfirstlast();
            Console.WriteLine();
            swaplasttwo();
            Console.WriteLine();
            digitsum();
            Console.WriteLine();
            checkNegPos();

        }

        public static void removeChar()
        {
            string s = "hello3";
            Console.WriteLine(s);

            int n = 2;

            Console.WriteLine("After remove");
            Console.WriteLine(s.Remove(n, 1));
        }


        public static void swapfirstlast()
        {
            string s = "program";

            //char[] a = s.ToCharArray();

            Console.WriteLine(s);

            Console.WriteLine("Swap first and last ");
            var first = s[0];
            var last = s[s.Length - 1];

            Console.WriteLine(last + s.Substring(1, s.Length-2) + first);
        }


        public static void swaplasttwo()
        {
            string s = "welcome";
            Console.WriteLine(s);

            Console.WriteLine("Swap last to charater");

            var first = s[s.Length-1];
            var last = s[s.Length-2];

            Console.WriteLine(s.Substring(0, s.Length-2) + first + last);
        }


        public static void digitsum()
        {
            int n = 12345;
            int sum = 0;
            int rem;

            Console.WriteLine(n);

            while (n != 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10;
            }

            Console.WriteLine("Sum of digit");
            Console.WriteLine(sum);
        }


        public static void checkNegPos()
        {
            int a = 10;
            int b = -12;
            Console.WriteLine(a + "  " + b);

            Console.WriteLine("check one positive and one negative ");

            bool check = ((a < 0 && b > 0) || (a > 0 && b < 0));

            Console.WriteLine(check);
                
        }


    }
}
