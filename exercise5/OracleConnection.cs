using System;

namespace exercise5
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("Connecting to Oracle...");
        }
        public override void Close()
        {
            Console.WriteLine("OracleConnection Closed");
        }
    }
}
