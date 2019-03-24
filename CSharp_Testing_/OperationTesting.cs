using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Testing_
{

    class OperationTesting
    {
        public static void OperartorTesting()
        {
            int a, b, c;
            c = 1;
            // The following two lines are equivalent.  
            a = b = c;
            a = (b = c);
        }

        public static void logicalConditionNullOperators()
        {
            LogicalAND();
            LogicalXOR();
            LogicalOR();
            ConditionalAND();
            ConditionalOR();
        }

        private static void ConditionalOR()
        {
            Boolean x = true, y = false, z;
            z = x || y;
            if (x || y)
            {
                Console.WriteLine($"{z}");
            }
        }
        private static void ConditionalAND()
        {
            Boolean x = true, y = true, z;
            z = x && y;
            if (x && y)
            {
                Console.WriteLine($"{x}");
            }
        }

        private static void LogicalAND()
        {

            // Logical AND
            int x = 0, y = 0, z = 0;
            uint a = 0b_1111_1000;
            uint b = 0b_1001_1111;
            uint c = a & b;
        }

        private static void LogicalXOR()
        {
            // Logical exclusive-OR

            // When one operand is true and the other is false, exclusive-OR 
            // returns True.
            Console.WriteLine(true ^ false);
            // When both operands are false, exclusive-OR returns False.
            Console.WriteLine(false ^ false);
            // When both operands are true, exclusive-OR returns False.
            Console.WriteLine(true ^ true);


            // Bitwise exclusive-OR

            // Bitwise exclusive-OR of 0 and 1 returns 1.
            Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 ^ 0x1, 2));
            // Bitwise exclusive-OR of 0 and 0 returns 0.
            Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x0 ^ 0x0, 2));
            // Bitwise exclusive-OR of 1 and 1 returns 0.
            Console.WriteLine("Bitwise result: {0}", Convert.ToString(0x1 ^ 0x1, 2));
        }

        private static void LogicalOR()
        {
            Console.WriteLine(true | false);  // logical or
            Console.WriteLine(false | false); // logical or
            Console.WriteLine("0x{0:x}", 0xf8 | 0x3f);   // bitwise or
        }

        public static void associativity()
        {
            int a = 0, b = 0, c = 0, d = 0;

            //a, b, =
            a = b;

            //a, b, c, +, =
            a = b + c;

            //a, b, c, d, *, +, =
            a = b + c * d;

            //a, b, c, *, d, +, =
            a = b * c + d;

            //a, b, c, -, d, +, =
            a = b - c + d;

            //a, b, c, -=, +=
            a += b -= c;
        }

    }
}
