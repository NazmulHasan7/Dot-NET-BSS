using System;

namespace CSharpOOP
{
    public class Calculate
    {
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Add(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
        public static void Add(params int[] array)
        {
            var sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
