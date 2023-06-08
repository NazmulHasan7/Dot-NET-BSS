using System;

namespace CSharpOOP
{
    public class Person
    {
        public string Name;
        public int Id;
        public string email;
        public readonly List<Order> Orders = new List<Order>();
        public Person()
        {
            //Console.WriteLine("Person constructor");
            Orders = new List<Order>();
        }
        public Person(string name, int id, string email)
            : this() // Passing the control to the default constructor
        {
            this.Name = name;
            this.Id = id;
            this.email = email;
        }
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person getPersonObj(string personName)
        {
            var personObj = new Person();
            personObj.Name = personName;
            return personObj;
        }
        public void Promote()
        {
            List<Order> orders = new List<Order>();
        }
        public virtual void Show()
        {
            Console.WriteLine("Name: {0}\nEmail: {1}\nID: {2}", Name, email, Id);
        }
    }
}
