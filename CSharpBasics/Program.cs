using CSharpBasics.Excercises;
using CSharpBasics.Math;
using System;
using System.Runtime.Serialization.Formatters;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            // Variables
            Console.WriteLine("\nVariables: Primitive types ------------------");
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
            Console.WriteLine("\nType Conversion -----------------");
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

            Console.WriteLine("\nNon primitive types : Class ---------------");
            Person person = new Person();
            person.firstName = "John";
            person.lastName = "Doe";
            person.introduce();

            Console.WriteLine(Calculator.Add(5, 10));

            int[] numbers = new int[3]; // var numbers = new int[3];
            Console.WriteLine(numbers[2]); // default value of the type
            var names = new string[3] {"John", "Doe", "Smith"};
            Console.WriteLine(names[0]);

            // Strings
            Console.WriteLine("\nNon primitive types : String ---------------");
            string firstName = "Nazmul"; string lastName = "Hasan";
            string user1 = firstName + " " + lastName;
            Console.WriteLine(user1);

            string user2 = string.Format("Name: {0} {1}", firstName, lastName);
            Console.WriteLine(user2);

            var path = "C:\\projects\\C#\\project1";
            Console.WriteLine(path);
            path = @"C:\projects\C#\project1";
            Console.WriteLine(path);

            names = new string[3] { "John", "Doe", "Smith" };
            var formattedNames = String.Join(", ", names);
            Console.WriteLine(formattedNames);

            // Enum - A set of name/value pairs (contants)
            Console.WriteLine("\nNon primitive type : Enum -------------");
            var method = ShippingMethod.RegisteredAirMail;
            Console.WriteLine(method);
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod) , methodName);
            Console.WriteLine(shippingMethod);

            // Reference Type and Value Type
            Console.WriteLine("\nReference Type and Value Type -----------------");
            var array1 = new int[4] { 10, 20, 30, 40 };
            var array2 = new int[4] { 50, 60, 70, 80 };
            Console.WriteLine("Array index [3] : {0}", array1[3]);
            Console.WriteLine(array1 == array2);
            array1 = array2;
            Console.WriteLine("Array index [3] : {0}", array1[3]);
            Console.WriteLine(array1 == array2);

            // Control Flow
            Console.WriteLine("\nControl Flow: -----------------");
            ControlFlowExcercise.Excercise01();
            ControlFlowExcercise.Excercise02();
            ControlFlowExcercise.Excercise03();
            ControlFlowExcercise.Excercise04();

            // Iteration Statements - For Foreach While Do-while
            Console.WriteLine("\nIteration Statement: ----------------");
            var userName = "Ben Dover";
            Console.WriteLine("For Loop:");
            for (var i=0; i<userName.Length; i++)
            {
                Console.Write(userName[i] + " ");
            }
            Console.WriteLine("\nForeach Loop:");
            foreach(var singleChars in userName)
            {
                Console.Write(singleChars + " ");
            }
            Console.WriteLine("\nWhile Loop:");
            while(true)
            {
                Console.Write("Enter a name: ");
                var inputName = Console.ReadLine();
                if(!String.IsNullOrWhiteSpace(inputName))
                {
                    Console.WriteLine("Hello " +inputName);
                    continue;
                }
                break;
            }

            // Random class
            Console.WriteLine("\nRandom Class ------------------");
            var random = new Random();
            var buffer = new char[10];
            for(var i=0; i<buffer.Length; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine("Password: " +password); 

            // Iteration Excercises
            Console.WriteLine("\nIteration Excercises ------------------");
            IterationExcercises.Excercise01();
            IterationExcercises.Excercise02();
            IterationExcercises.Excercise03();
            IterationExcercises.Excercise04();
            IterationExcercises.Excercise05();

            // Arrays and Lists
            Console.WriteLine("\nArray ------------------");
            var singleDimensionalArray = new int[5] { 10, 20, 30, 50, 4};
            Console.WriteLine(singleDimensionalArray.Length);
            var multiDimensionalArray = new int[2, 3] { { 2, 4, 6 }, { 1, 3, 5 } };
            Console.WriteLine(multiDimensionalArray.Length);
            var jaggedArray = new int[2][];
            Console.WriteLine(jaggedArray.Length);
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            
            // (array, elementToFound)
            Console.WriteLine(Array.IndexOf(singleDimensionalArray, 30));
            Console.WriteLine(Array.IndexOf(singleDimensionalArray, 40));
            
            // (array, startIndex, numberOfElementsToBeCleared)
            Array.Clear(singleDimensionalArray, 0, 2);
            foreach(var number in singleDimensionalArray)
            {
                Console.Write(number+ " ");
            }
            Console.WriteLine();
            var array2 = new int[4];
            // (sourceArray, destinationArray, numberOfElementToBeCopied)
            Array.Copy(singleDimensionalArray, array2, 4);
            foreach(var number in array2)
            {
                Console.Write(number+ " ");
            }
            Array.Reverse(singleDimensionalArray);
            Console.WriteLine();
            foreach (var number in singleDimensionalArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Array.Sort(singleDimensionalArray);
            foreach (var number in singleDimensionalArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nLists --------------------");
            var list = new List<int>() { 1, 2, 3, 4 };
            list.Add(5);
            list.AddRange(new int[2] { 1, 2 });
            foreach(int i in list)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i=0; i<list.Count; i++)
            {
                if (list[i] == 1)
                {
                    list.Remove(1);
                }
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            list.Clear();
            Console.WriteLine();
            Console.WriteLine(list.Count);
        }
    }
}