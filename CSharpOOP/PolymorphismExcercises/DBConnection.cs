using System;

namespace CSharpOOP.PolymorphismExcercises
{
    public abstract class DBConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        public string ConnectionString
        {
            get { return _connectionString; }
            set 
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Connection string is invalid");
                }
                _connectionString = value;
            }
        }
        public TimeSpan Timeout { get { return _timeout; } set {  _timeout = value; } }

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }
        public abstract void Open();
        public abstract void Close();
    }
}
