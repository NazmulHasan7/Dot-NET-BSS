using CSharpBasics.Math;
using System;

namespace CSharpBasics
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void introduce()
        {
            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine("Calculation: " +Calculator.Add(2, 3));
        }
    }
}
