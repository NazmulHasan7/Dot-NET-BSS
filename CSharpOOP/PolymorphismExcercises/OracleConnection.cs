using System;

namespace CSharpOOP.PolymorphismExcercises
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void Open()
        {
            Console.WriteLine("ORACLE connection openned");
        }
        public override void Close()
        {
            Console.WriteLine("ORACLE connection closed");
        }
    }
}
