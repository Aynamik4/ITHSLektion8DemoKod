using System;
using System.Net.Cache;

namespace TupleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTwoValues values = GetTheValues();
            Console.WriteLine($"{values.MyInt} {values.MyString}");

            //int Age = 10;
            //string Name = string.Empty;
            (int Age, string Name) = GetValues2();
            Console.WriteLine($"{Age} {Name}");
        }

        private static MyTwoValues GetTheValues()
        {
            MyTwoValues myTwoValues = new MyTwoValues();
            myTwoValues.MyInt = 58;
            myTwoValues.MyString = "Håkan";
            return myTwoValues;
        }

        static (int age, string name) GetValues2()
        {
            return (58, "Håkan");
        }
    }

    class MyTwoValues
    {
        public int MyInt { get; set; }
        public string MyString { get; set; }
    }
}
