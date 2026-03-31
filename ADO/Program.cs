using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_522;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";

            SqlConnection connection = new SqlConnection(connection_string);
            DataBase db = new DataBase(connection);

            db.ExecuteSelect("SELECT * FROM Directors");
            Console.WriteLine($"Количество записей: {db.ExecuteScalar("SELECT COUNT (*) FROM Directors")}");
            db.ExecuteSelect("SELECT * FROM Movies");     
        }
    }
}
