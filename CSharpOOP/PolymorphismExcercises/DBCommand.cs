using System;

namespace CSharpOOP.PolymorphismExcercises
{
    public class DBCommand
    {
        private DBConnection _connection;
        private string _command;
        public DBConnection Connection 
        { 
            get { return _connection; } 
            set 
            {
                if (value == null)
                    throw new InvalidOperationException("Invlaid connecion");
                _connection = value;
            }
        }
        public string Command
        {
            get { return _command; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new InvalidOperationException("Empty command cannot be proceed");
                _command = value;
            }
        }
        public DBCommand(DBConnection connection, string command)
        {
            _connection = connection;
            _command = command;
        }
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Command : " +_command);
            _connection.Close();
        }
    }
}
