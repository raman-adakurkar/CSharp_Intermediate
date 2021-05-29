using System;

namespace exercise5
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("no emplty space or null space alowed");

            _connectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }
}
