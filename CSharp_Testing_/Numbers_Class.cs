using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Testing_
{

    public class Numbers_Class
    {
        public static void quick_maths()
        {
            int sum = 0;
            for (int counter2 = 1; counter2 < 20; counter2++)
            {

                if (counter2 % 3 == 0)
                {
                    sum += counter2;
                    Console.WriteLine($"Hello World! this number {counter2}, can be divided by 3!");
                }


            }
            Console.WriteLine($"{sum}, is the sum");



        }

        public static void fibbonaci_math()
        {
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());

            //printing 0 and 1  
            Console.Write(n1 + " " + n2 + " ");

            //loop starts from 2 because 0 and 1 are already printed 
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;

            }
        }
    }

}
