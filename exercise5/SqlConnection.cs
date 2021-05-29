﻿using System;

namespace exercise5
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection Started...");
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection Closed...");
        }
    }
}
