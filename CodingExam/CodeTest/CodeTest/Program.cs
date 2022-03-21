using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CodeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no;
            try
            {
                string cs = "data source=LAPTOP-6R95OGR0; database=EmployeeManagement; integrated security=SSPI";
                using(SqlConnection conn = new SqlConnection(cs))
                {
                    Console.WriteLine("Enter Employee id:");
                    no = int.Parse(Console.ReadLine());
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "spEmloyeeByNo";
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter sp = new SqlParameter
                    {
                        ParameterName = "@empno",
                        SqlDbType = SqlDbType.Int,
                        Value = no,
                        Direction = ParameterDirection.Input
                    };

                    cmd.Parameters.Add(sp);

                    conn.Open();
                    SqlDataReader rd= cmd.ExecuteReader();
                    Console.WriteLine("Employee Data");
                    while(rd.Read())
                    {
                        Console.WriteLine(rd[0]+","+rd[1]+","+rd[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
