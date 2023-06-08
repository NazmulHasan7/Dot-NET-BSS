using System;

namespace CSharpOOP.PolymorphismExcercises
{
    public class SQLConnection : DBConnection
    {
        public SQLConnection(string connectionString): base(connectionString) 
        {
            
        }
        public override void Open()
        {
            Console.WriteLine("SQL connection openned");
        }
        public override void Close()
        {
            Console.WriteLine("SQL connection closed");
        }
    }
}
