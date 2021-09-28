using System;

namespace Lecture_2_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("Would you like to continue? Y or N");
                string userResponse1 = Console.ReadLine();
                if (userResponse1 == "Y" || userResponse1 == "y")
                {
                    keepGoing = true;
                }
                else if(userResponse1 == "n" || userResponse1 == "N")
                {
                    keepGoing = false;
                }

                else
                { Console.WriteLine("Please input either Y or N."); }
            }

            int sum = 0;
            for(int i = 0; i <=5; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            
            
        }
    }
}
