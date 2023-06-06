using System;

namespace CSharpBasics.Excercises
{
    public class ControlFlowExcercise
    {
        public static void Excercise01()
        {
            try
            {
                Console.Write("Enter a number in between 0 to 10: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());
                if(inputNumber >= 0 && inputNumber <= 10)
                {
                    Console.WriteLine("Valid input");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            }
        }
        public static void Excercise02()
        {
            try
            {
                Console.Write("Enter number 1: ");
                var number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number 2: ");
                var number2 = Convert.ToInt32(Console.ReadLine());
                var maxValue = (number1 > number2)? number1: number2;
                Console.WriteLine("Maximum is : " +maxValue);
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            }
        }
        public static void Excercise03()
        {
            try
            {
                Console.Write("Enter width: ");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter height: ");
                var height = Convert.ToInt32(Console.ReadLine());
                if(width > height)
                {
                    Console.WriteLine("Landscape image");
                }
                else
                {
                    Console.WriteLine("Potrait image");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            } 
        }
        public static void Excercise04()
        {
            try
            {
                Console.Write("Enter speed limit: ");
                var speedLimit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter car speed: ");
                var speed = Convert.ToInt32(Console.ReadLine());
                if(speed < speedLimit)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    const int demeritPointKm = 5;
                    var demeritPoints = (speed - speedLimit) / demeritPointKm;
                    if(demeritPoints > 12)
                    {
                        Console.WriteLine("License suspended");
                    }
                    else
                    {
                        Console.WriteLine("Total demerit points: " +demeritPoints);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input type! Integer expected");
            }
        }
    }
}
