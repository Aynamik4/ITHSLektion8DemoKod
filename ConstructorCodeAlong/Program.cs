using System;

namespace ConstructorCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            RunConstructorDemo();
        }

        private static void RunConstructorDemo()
        {
            Car myCar = new Car("Volvo V70", 2006);
            Console.WriteLine($"En {myCar.Model} som är {myCar.Age} år {(myCar.Age < 5 ? "ny" : "gammal")}");
        }
    }
}