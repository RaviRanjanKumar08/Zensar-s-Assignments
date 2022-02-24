using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LinqAssignment
{
    class Employees
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet("Tables");
            DataTable EmployeeTable = new DataTable("Employees");
            DataColumn[] EmployeeTableColumn = new DataColumn[7];
            EmployeeTableColumn[0] = new DataColumn("EmployeeID");
            EmployeeTable.Columns.Add(EmployeeTableColumn[0]);
            EmployeeTableColumn[1] = new DataColumn("FirstName");
            EmployeeTable.Columns.Add(EmployeeTableColumn[1]);
            EmployeeTableColumn[2] = new DataColumn("LastName");
            EmployeeTable.Columns.Add(EmployeeTableColumn[2]);
            EmployeeTableColumn[3] = new DataColumn("Title");
            EmployeeTable.Columns.Add(EmployeeTableColumn[3]);
            EmployeeTableColumn[4] = new DataColumn("DOB");
            EmployeeTable.Columns.Add(EmployeeTableColumn[4]);
            EmployeeTableColumn[5] = new DataColumn("DOJ");
            EmployeeTable.Columns.Add(EmployeeTableColumn[5]);
            EmployeeTableColumn[6] = new DataColumn("City");
            EmployeeTable.Columns.Add(EmployeeTableColumn[6]);

            DataRow EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1001";
            EmployeeTableRows["FirstName"] = "Malcom";
            EmployeeTableRows["LastName"] = "Daruwalla";
            EmployeeTableRows["Title"] = "Manager";
            EmployeeTableRows["DOB"] = DateTime.Parse("16/11/1984");
            EmployeeTableRows["DOJ"] = DateTime.Parse("08/06/2011");
            EmployeeTableRows["City"] = "Mumbai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1002";
            EmployeeTableRows["FirstName"] = "Asdin";
            EmployeeTableRows["LastName"] = "Dhalla";
            EmployeeTableRows["Title"] = "AsstManager";
            EmployeeTableRows["DOB"] = DateTime.Parse("20/08/1984");
            EmployeeTableRows["DOJ"] = DateTime.Parse("07/07/2012");
            EmployeeTableRows["City"] = "Mumbai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

        
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1003";
            EmployeeTableRows["FirstName"] = "Madhavi";
            EmployeeTableRows["LastName"] = "Oza";
            EmployeeTableRows["Title"] = "Consultant";
            EmployeeTableRows["DOB"] = DateTime.Parse("14/11/1987");
            EmployeeTableRows["DOJ"] = DateTime.Parse("12/04/2015");
            EmployeeTableRows["City"] = "Pune";
            EmployeeTable.Rows.Add(EmployeeTableRows);

     
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1004";
            EmployeeTableRows["FirstName"] = "Saba";
            EmployeeTableRows["LastName"] = "Shaikh";
            EmployeeTableRows["Title"] = "SE";
            EmployeeTableRows["DOB"] = DateTime.Parse("03/06/1990");
            EmployeeTableRows["DOJ"] = DateTime.Parse("02/02/2016");
            EmployeeTableRows["City"] = "Pune";
            EmployeeTable.Rows.Add(EmployeeTableRows);

        
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1005";
            EmployeeTableRows["FirstName"] = "Nazia";
            EmployeeTableRows["LastName"] = "Shaikh";
            EmployeeTableRows["Title"] = "SE";
            EmployeeTableRows["DOB"] = DateTime.Parse("08/03/1991");
            EmployeeTableRows["DOJ"] = DateTime.Parse("02/02/2016");
            EmployeeTableRows["City"] = "Mumbai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

           
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1006";
            EmployeeTableRows["FirstName"] = "Amit";
            EmployeeTableRows["LastName"] = "Pathak";
            EmployeeTableRows["Title"] = "Consultant";
            EmployeeTableRows["DOB"] = DateTime.Parse("07/11/1989");
            EmployeeTableRows["DOJ"] = DateTime.Parse("08/08/2014");
            EmployeeTableRows["City"] = "Chennai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

           
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1007";
            EmployeeTableRows["FirstName"] = "Vijay";
            EmployeeTableRows["LastName"] = "Natrajan";
            EmployeeTableRows["Title"] = "Consultant";
            EmployeeTableRows["DOB"] = DateTime.Parse("02/12/1989");
            EmployeeTableRows["DOJ"] = DateTime.Parse("01/06/2015");
            EmployeeTableRows["City"] = "Mumbai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

       
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1008";
            EmployeeTableRows["FirstName"] = "Rahul";
            EmployeeTableRows["LastName"] = "Dubey";
            EmployeeTableRows["Title"] = "Associate";
            EmployeeTableRows["DOB"] = DateTime.Parse("11/11/1993");
            EmployeeTableRows["DOJ"] = DateTime.Parse("06/11/2014");
            EmployeeTableRows["City"] = "Chennai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

         
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1009";
            EmployeeTableRows["FirstName"] = "Suresh";
            EmployeeTableRows["LastName"] = "Mistry";
            EmployeeTableRows["Title"] = "Associate";
            EmployeeTableRows["DOB"] = DateTime.Parse("12/08/1992");
            EmployeeTableRows["DOJ"] = DateTime.Parse("03/12/2014");
            EmployeeTableRows["City"] = "Chennai";
            EmployeeTable.Rows.Add(EmployeeTableRows);

         
            EmployeeTableRows = EmployeeTable.NewRow();
            EmployeeTableRows["EmployeeID"] = "1010";
            EmployeeTableRows["FirstName"] = "Sumit";
            EmployeeTableRows["LastName"] = "Shah";
            EmployeeTableRows["Title"] = "Manager";
            EmployeeTableRows["DOB"] = DateTime.Parse("12/04/1991");
            EmployeeTableRows["DOJ"] = DateTime.Parse("02/01/2016");
            EmployeeTableRows["City"] = "Pune";
            EmployeeTable.Rows.Add(EmployeeTableRows);

            ds.Tables.Add(EmployeeTable);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("EmployeeID\t | FirstName\t | LastName\t | Title\t | DOB\t | DOJ\t | City");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            foreach (DataRow row in EmployeeTable.Rows)
            {
                Console.WriteLine("{0}\t | {1}\t | {2}\t | {3}\t | {4}\t | {5}\t | {6} ", row["EmployeeID"], row["FirstName"], row["LastName"], row["Title"], row["DOB"], row["DOJ"], row["City"]);
            }

            Console.Read();
        }
    }
}
