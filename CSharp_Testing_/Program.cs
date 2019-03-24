using System;
namespace CSharp_Testing_
{
    class Program
    {

        public static void Main(string[] args)
        {
            TestDelegates();
            Console.ReadLine();
        }

        public static void testNumbers()
        {
            Numbers_Class.Fibbonaci_Math();
            Numbers_Class.QuickMaths();
        }

        public static void TestStatements()
        {
            //TestingStatements.Switch_Test();
            //TestingStatements.ListTest();
            //TestingStatements.IterateSpanExample();
            //TestingStatements.Spanesting_0();
            //TestingStatements.Spanesting_1();
            //TestingStatements.Spanesting_2();
            //TestingStatements.Spanesting_3();

        }

        public static void TestDelegates()
        {
            var DelegateTestingClass = new DelegateTesting();

            // Instantiate the delegate.
            DelegateTesting.Del handler = DelegateTesting.DelegateMethod;

            // Call the delegate.
            handler("Hello World");

            Console.WriteLine("Enter first Value:");
            string input0 = Console.ReadLine();
            int inputInt0 = Int32.Parse(input0);
            Console.WriteLine("Enter Second Value:");
            string input1 = Console.ReadLine();
            int inputInt1 = Int32.Parse(input1);
            DelegateTestingClass.MethodWithCallback(inputInt0, inputInt1, handler);
        }


    }
}
