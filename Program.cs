/* 
Author: An Nguyen
Date: 9/2/2022
Description: Provide students their corresponding Letter Grade for ISM 4300.
*/

namespace deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try-catch block
            try
            {
                //Get user to enter desired grade
                Console.WriteLine("Enter your desired grade: ");

                // Assign and declare variables
                int n1 = Convert.ToInt32(Console.ReadLine());
                string n2;

                // Display entered number
                Console.WriteLine("Your desired grade is: " + n1);

                // Use conditional statement to assign ranges and variable n2
                if (n1 >= 98)
                {
                    n2 = "A+";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 92) && (n1 < 98))
                {
                    n2 = "A";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 90) && (n1 < 92))
                {
                    n2 = "A-";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 88) && (n1 < 90))
                {
                    n2 = "B+";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 82) && (n1 < 88))
                {
                    n2 = "B";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 80) && (n1 < 82))
                {
                    n2 = "B-";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 78) && (n1 < 80))
                {
                    n2 = "C+";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 72) && (n1 < 78))
                {
                    n2 = "C";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 70) && (n1 < 72))
                {
                    n2 = "C-";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 68) && (n1 < 70))
                {
                    n2 = "D+";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 62) && (n1 < 68))
                {
                    n2 = "D";
                    Console.ReadKey(true);
                }
                else if ((n1 >= 60) && (n1 < 62))
                {
                    n2 = "D-";
                    Console.ReadKey(true);
                }
                else 
                {
                    n2 = "F";
                    Console.ReadKey(true);
                }

                // Present students with their Letter Grade
                Console.WriteLine("Accordingly, your letter grade is: " + n2);

            }
            catch
            {
                Console.WriteLine("Please only use an integer data type");
                Console.ReadKey(true);
            }
        }

    }
}