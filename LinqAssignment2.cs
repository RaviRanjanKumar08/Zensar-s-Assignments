using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssignment2
{
    class Employees
    {
        int EmployeeId;
        string FirstName;
        string LastName;
        string Title;
        DateTime DOB;
        DateTime DOJ;
        string City;
        static void Main(string[] args)
        {
            List<Employees> empList = new List<Employees>()
            {
                new Employees() { EmployeeId = 1001, FirstName ="Malcom",LastName="Daruwalla",Title="Manager",DOB=DateTime.Parse("16/11/1984"),DOJ=DateTime.Parse("08/06/2011"),City="Mumbai"},
                new Employees() { EmployeeId = 1002, FirstName ="Asdin",LastName="Dhalla",Title="AsstManager",DOB=DateTime.Parse("20/08/1984"),DOJ=DateTime.Parse("07/06/2012"),City="Mumbai"},
                new Employees() { EmployeeId = 1003, FirstName ="Madhavi",LastName="Oza",Title="Consultant",DOB=DateTime.Parse("14/11/1987"),DOJ=DateTime.Parse("12/04/2015"),City="Pune"},
                new Employees() { EmployeeId = 1004, FirstName ="Saba",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("03/06/1990"),DOJ=DateTime.Parse("02/02/2016"),City="Pune"},
                new Employees() { EmployeeId = 1005, FirstName ="Nazia",LastName="Shaikh",Title="SE",DOB=DateTime.Parse("08/03/1991"),DOJ=DateTime.Parse("02/02/2016"),City="Mumbai"},
                new Employees() { EmployeeId = 1006, FirstName ="Amit",LastName="Pathak",Title="Consultant",DOB=DateTime.Parse("07/11/1989"),DOJ=DateTime.Parse("08/02/2014"),City="Chennai"},
                new Employees() { EmployeeId = 1007, FirstName ="Vijay",LastName="Natrajan",Title="Consultant",DOB=DateTime.Parse("02/12/1989"),DOJ=DateTime.Parse("01/06/2015"),City="Mumbai"},
                new Employees() { EmployeeId = 1008, FirstName ="Rahul",LastName="Dubey",Title="Associate",DOB=DateTime.Parse("11/11/1993"),DOJ=DateTime.Parse("06/11/2014"),City="Chennai"},
                new Employees() { EmployeeId = 1009, FirstName ="Suresh",LastName="Mistry",Title="Associate",DOB=DateTime.Parse("12/08/1992"),DOJ=DateTime.Parse("03/12/2014"),City="Chennai"},
                new Employees() { EmployeeId = 1010, FirstName ="Sumit",LastName="Shah",Title="Manager",DOB=DateTime.Parse("12/04/1991"),DOJ=DateTime.Parse("02/01/2016"),City="Pune"},
            };
            foreach (var item in empList)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }
            Console.Read();
        }
    }
}
