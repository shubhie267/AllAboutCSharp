using System;
using System.Collections.Generic;

namespace AllAboutCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool Equal = Calculator.AreTheyEqual<string>("ab", "ab");

            //if(Equal)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            Customer cust = new Customer();

            Customer cust1 = new Customer()
            {
                CustId = 101,
                CustName = "Shubhi",
                Salary = 10000
            };
            Customer cust2 = new Customer()
            {
                CustId = 101,
                CustName = "KiKi",
                Salary = 20000
            };
            Customer cust3 = new Customer()
            {
                CustId = 101,
                CustName = "GiGi",
                Salary = 4500
            };

            List<Customer> obj = new List<Customer>(2);
            obj.Add(cust1);
            obj.Add(cust2);
            obj.Add(cust3);

            Customer c = obj[0];

            Console.WriteLine("{0} {1} {2}",c.CustId,c.CustName,c.Salary );
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
