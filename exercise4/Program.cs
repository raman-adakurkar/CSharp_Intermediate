using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Connect to -\n1. Oracle Database\n2. SQL Database\nEnter your choice : ");
            var s = Console.ReadLine();
            Console.WriteLine();
            var i = int.Parse(s);

            var oracleConnection = new OracleConnection(s);
            var sqlConnection = new SqlConnection(s);
            
            switch(i)
            {
                case 1:
                    oracleConnection.Open();
                    oracleConnection.Close();
                    Console.WriteLine();
                    break;

                case 2:
                    sqlConnection.Open();
                    sqlConnection.Close();
                    Console.WriteLine();
                    break;
            }



        }
    }
}
