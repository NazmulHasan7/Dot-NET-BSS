using CSharpBasics.Math;
using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // Variables
            int intVar = 20;
            float floatVar = 1.5f;
            double doubleVar = 100.5;
            char charVar = 'a';
            decimal decVar = 3.5m;
            bool booleanVar = false;
            string message = "Hello";
            Console.WriteLine(intVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(charVar);
            Console.WriteLine(decVar);
            Console.WriteLine(booleanVar);
            Console.WriteLine(message);

            const float Pi = 3.1416f;
            Console.WriteLine(Pi);

            // Format string print
            Console.WriteLine("For byte type - Min value: {0}, Max value: {1}", byte.MinValue, byte.MaxValue);

            // Type Conversion - Type casting
            int i = 300; // 32bit int - binary - 100101100 = 300
            byte b = (byte)i; // 8 bit byte - can store 00101100 = 44
            Console.WriteLine(b);

            try
            {
                string number = "1234";
                int intNum = Convert.ToInt32(number);
                Console.WriteLine(number);
                string boolStr = "false";
                bool check = Convert.ToBoolean(boolStr);
                Console.WriteLine(check);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conversion failed!! Detailed info: {0}", ex);
            }

            Person person = new Person();
            person.firstName = "John";
            person.lastName = "Doe";
            person.introduce();

            Console.WriteLine(Calculator.Add(5, 10));

            int[] numbers = new int[3]; // var numbers = new int[3];
            Console.WriteLine(numbers[2]); // default value of the type
            var names = new string[3] {"John", "Doe", "Smith"};
            Console.WriteLine(names[0]);
        }
    }
}