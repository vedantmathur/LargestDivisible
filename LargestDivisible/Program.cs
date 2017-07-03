using System;

namespace LargestDivisible
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisors = 0;
            int divisors2017 = 0;
            int year = 1;
            for (int i = 1; i < 3000; i++)
            {
                int count = 0;
                for (int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                }
                if(i == 2017)
                {
                    divisors2017 = count;
                }
                if(count > divisors)
                {
                    divisors = count;
                    year = i;
                }
            }

            Console.WriteLine($"Largest year is {year} and it has {divisors} divisors.");
            Console.WriteLine($"The year 2017 has {divisors2017} divisors.");
			// Largest year is 2520 and it has 47 divisors.
		}
    }
}