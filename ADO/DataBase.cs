using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class DataBase
    {
        private SqlConnection connection;

        public DataBase(SqlConnection _connection)
        {
            this.connection = _connection;
        }

        public void ExecuteSelect(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
                Console.Write($"{reader.GetName(i),-20}\t");
            Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader[i],-20}\t");
                }
                Console.WriteLine();
            }

            reader.Close();
            connection.Close();
        }

        public object ExecuteScalar(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();

            object value = command.ExecuteScalar();

            connection.Close();
            return value;
        }
    }
}
