using System;
using CSharpOOP.ClassIntroExcercises;
using CSharpOOP.InheritanceExcercise;

namespace CSharpOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            var person1 = new Person();
            person1.Name = "Person 1";
            person1.Introduce("Person 2");
            var person2 = Person.getPersonObj("Person 2");
            person2.Introduce(person1.Name);

            // Object Initializers
            var person3 = new Person { Name = "Nazmul", Id = 100 };
            Console.WriteLine(person3.Name);
            Console.WriteLine(person3.Id);

            Calculate.Add(2, 3);
            Calculate.Add(2, 3, 4);
            Calculate.Add(1, 2, 3, 4, 5, 6);
            Calculate.Add(new int[] { 1, 2, 3, 4, 6 });

            int num1 = 20, num2 = 30;
            swapUsingRef(ref num1, ref num2);
            Console.WriteLine(num1 + " " +num2);

            int num3, num4;
            OutTest(out num3, out num4);
            Console.WriteLine(num3+ " " +num4);

            var student = new Student(new DateTime(1999, 12, 7));
            student.Name = "Nazmul";
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Birthdate.ToString("D"));
            Console.WriteLine(student.Age);
            */

            // Class introduction excercises
            try
            {
                var clock = new Stopwatch();
                clock.Start();
                clock.Stop();
                clock.Start();
                clock.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            var post = new StackOverflowPost("Test Post", "This is a test post");
            post.UpVote();
            post.DownVote();
            post.UpVote();
            Console.WriteLine(post.Vote);

            var user = new Student("Student 1" ,12344, "user@example.com");
            Console.WriteLine(user.email);

            var stack = new StackTest();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            object obj1, obj2, obj3;
            stack.Pop(out obj1);
            stack.Pop(out obj2);
            stack.Pop(out obj3);
            Console.WriteLine(obj1+ " " +obj2+ " " +obj3);
        }

        private static void OutTest(out int x, out int y)
        {
            x = 40; y = 50;
        }

        public static void swapUsingRef(ref int x , ref int y)
        {
            int temp = x;
            x = y; 
            y = temp;
        }
    }
}
