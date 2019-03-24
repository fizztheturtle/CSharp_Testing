using System;
using System.Collections.Generic;
using System.Text;

// http://www.blueskyprojects.com/print-design/

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
//Delegates are similar to C++ function pointers, but delegates are fully object-oriented,
// and unlike C++ pointers to member functions, delegates encapsulate both an object instance and a method.

//Delegates allow methods to be passed as parameters.

//Delegates can be used to define callback methods.

//Delegates can be chained together; for example, multiple methods can be called on a single event.

//Methods do not have to match the delegate type exactly. For more information, see Using Variance in Delegates.

//C# version 2.0 introduced the concept of Anonymous Methods, which allow code blocks to be passed as parameters in place of a 
//separately defined method. C# 3.0 introduced lambda expressions as a more concise way of writing inline code blocks. 
//Both anonymous methods and lambda expressions (in certain contexts) are compiled to delegate types. 
//Together, these features are now known as anonymous functions. For more information about lambda expressions, 
//see Anonymous Functions.