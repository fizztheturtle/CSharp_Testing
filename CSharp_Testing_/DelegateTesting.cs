using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Testing_
{
    class DelegateTesting
    {
        public delegate void Del(string message);

        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }


       

        public void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }

    }
}
