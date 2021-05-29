using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Connect to -\n1. Oracle Database\n2. SQL Database\nEnter your choice : ");
            var s = Console.ReadLine();
            Console.WriteLine();
            var i = int.Parse(s);

            Console.WriteLine("Enter Command : ");
            var command = Console.ReadLine();
            Console.WriteLine();

            var oracleConnection = new OracleConnection(s);
            var sqlConnection = new SqlConnection(s);
            var dbCommandOracle = new DbCommand(oracleConnection, command);
            var dbCommandSql = new DbCommand(sqlConnection, command);

            switch (i)
            {
                case 1:
                    dbCommandOracle.Execute();
                    Console.WriteLine();
                    break;

                case 2:
                    dbCommandSql.Execute();
                    Console.WriteLine();
                    break;
            }

        }
    }
}
