using System;

namespace CSharpOOP
{
    public class Student : Person
    {
        // Compiler internally create these fields
        // private string _name;
        // private string _contactNo;
        // private DateTime _birthdate;
        // private int _age;

        public string Name { get; set; }
        public string ContactNo { get; set; }
        // Birthdate cannot be modified after creating an instance
        public DateTime Birthdate { get; private set; }
        public int Age 
        { 
            get
            {
                var duration = DateTime.Now - Birthdate;
                return duration.Days / 365;
            }
        }
        public Student(string name,  int id, string email)
            :base(name, id, email)
        {
            Console.WriteLine("Student Constructor called");
        }
        public Student(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
    }
}
