using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharp_Testing_
{
    class TestingStatements
    {
        public static void Switch_Test()
        {
            Console.Write("Enter your selection (1, 2, or 3): ");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Current value is {0}", n);
                    break;
                case 2:
                    Console.WriteLine("Current value is {0}", n);
                    break;
                case 3:
                    Console.WriteLine("Current value is {0}", n);
                    break;
                default:
                    Console.WriteLine("Sorry, {0} is an invalid selection.", n);
                    break;
            }

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void ListTest()
        {

            // The following example shows usage of the foreach statement 
            // with an instance of the List<T> type that implements the IEnumerable<T>
            // interface:
            var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
            int count = 0;
            foreach (int element in fibNumbers)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }
            Console.WriteLine($"Number of elements: {count}");

        }


        // The next example uses the foreach statement with an instance 
        // of the System.Span<T> type, which doesn't implement any interfaces:
        public static void IterateSpanExample()
        {
            Span<int> numbers = new int[] { 3, 14, 15, 92, 6 };
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }


        public static void Spanesting_0()
        {
            // Create a span over an array.
            var array = new byte[100];
            var arraySpan = new Span<byte>(array);

            byte data = 0;
            for (int ctr = 0; ctr < arraySpan.Length; ctr++)
                arraySpan[ctr] = data++;

            int arraySum = 0;
            foreach (var value in array)
                arraySum += value;

            Console.WriteLine($"The sum is {arraySum}");
        }

        public static void Spanesting_1()
        {
            var array = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            var slice = new Span<int>(array, 2, 5);
            for (int ctr = 0; ctr < slice.Length; ctr++)
                slice[ctr] *= 2;

            // Examine the original array values.
            foreach (var value in array)
                Console.Write($"{value}  ");
            Console.WriteLine();

        }
        public static void Spanesting_2()
        {
            byte data = 0;
            Span<byte> stackSpan = stackalloc byte[100];
            for (int ctr = 0; ctr < stackSpan.Length; ctr++)
                stackSpan[ctr] = data++;

            int stackSum = 0;
            foreach (var value in stackSpan)
                stackSum += value;

            Console.WriteLine($"The sum is {stackSum}");
        }
        public static void Spanesting_3()
        {
            string contentLength = "Content-Length: 132";
            var length = GetContentLength(contentLength.ToCharArray());
            Console.WriteLine($"Content length: {length}");
        }

        private static int GetContentLength(ReadOnlySpan<char> span)
        {
            var slice = span.Slice(16);
            return Int32.Parse(slice);
        }

    }
}
