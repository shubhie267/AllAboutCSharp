using System;

namespace AllAboutCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator.AreTheyEqual<string>("ab", "ab");

            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    class Calculator
    {
        static public bool AreTheyEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
