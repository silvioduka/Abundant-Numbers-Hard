/*
Abundant Numbers - Hard from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-10

If the sum of factors of a number is greater than twice that number, it is considered to be abundant. 

For example: 
12 is an abundant number. 
Factors of 12 are 1, 2, 3, 4, 6, 12 
Sum is 1 + 2 + 3 + 4 + 6 + 12 = 28 > 2 * 12 

Tasks: 
(Easy) Write a program to verify whether a given number is abundant or not. 
(Medium) Write a program to find all the abundant numbers in a range. 
(Hard) Given a number, write a program to display its factors, their sum and then verify whether it's abundant or not. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbundantNumbers
{
    class Program
    {
        static int number = 150; // Insert a number to verify

        static void Main(string[] args)
        {
            SumFact(number);
        }

        static void SumFact(int n)
        {
            int sum = 0;
            string factors = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    factors += i.ToString() + ", ";
                }
            }

            Console.WriteLine($"Factors of number {number} are: [{factors.Remove(factors.Length - 2, 2)}]");
            Console.WriteLine($"The sum of factors of number {number} is {sum}.");
            Console.WriteLine($"Number {n} {((sum > 2 * n) ? "is" : "is NOT")} abundant number.");
        }
    }
}