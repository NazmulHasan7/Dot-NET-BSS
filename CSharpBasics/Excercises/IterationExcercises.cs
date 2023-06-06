using System;

namespace CSharpBasics.Excercises
{
    public class IterationExcercises
    {
        public static void Excercise01()
        {
            int count = 0;
            for (int i=1; i<=100;  i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nTotal numbers divisible by 3 in between 1 and 100: " +count);
        }
        public static void Excercise02() 
        {
            var sum = 0;
            try
            {
                while(true)
                {
                    Console.Write("\nEnter a number or write \"ok\" to exit: ");
                    var input = Console.ReadLine();
                    if (input.ToLower() == "ok")
                    {
                        Console.WriteLine("Sum: " +sum);
                        break;
                    }
                    sum += Convert.ToInt32(input);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            }
        }
        public static void Excercise03()
        {
            try
            {
                var factorial = 1;
                Console.Write("\nEnter an integer to get the factorial: ");
                int number = Convert.ToInt32(Console.ReadLine());
                for(int i=1 ; i<=number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Factorial : " +factorial);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            }
        }
        public static void Excercise04()
        {
            var random = new Random();
            var randNumber = random.Next(1, 10);
            for(int i=0; i<4; i++)
            {
                Console.Write("Guess a number in between 1 and 10: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if(guess == randNumber)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("You lost");
        }
        public static void Excercise05()
        {
            Console.WriteLine("Enter numbers separated with comma: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);
            for(int i=1; i<numbers.Length; i++)
            {
                var currentNumber = Convert.ToInt32(numbers[i]);
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine("Maximum: " +max);
        }
    }
}
