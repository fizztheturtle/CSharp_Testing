using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Testing_
{
    public class TestingClass
    {
        //class members

        //Property
        public int Number { get; set; }

        //Method
        public int Multiply(int num)
        {
            return num * Number;
        }

        //Instance Constructor
        public TestingClass()
        {
            Number = 0;
        }

    }

}
