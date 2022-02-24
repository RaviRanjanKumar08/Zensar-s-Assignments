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
            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no a-------------");


            foreach (var item in empList)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }
            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no b-------------");
            var myquery = empList.Where(emp => emp.City != "Mumbai");

            foreach (var item in myquery)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no c-------------");
            var myquery3 = empList.Where(emp => emp.Title == "AsstManager");

            foreach (var item in myquery)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }
            var myquery4 = from ed in empList
                           where ed.LastName.StartsWith("S")
                           select ed;

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no d-------------");
            foreach (var item in myquery4)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no e-------------");
            var myquery5 = empList.Where(x => x.DOJ < DateTime.Parse("1/1/2015"));
            foreach (var item in myquery5)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no f-------------");
            var myquery6 = empList.Where(x => x.DOB > DateTime.Parse("1/1/1990"));
            foreach (var item in myquery6)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no g-------------");
            var myquery7 = empList.Where(x => x.DOB > DateTime.Parse("1/1/1990"));
            foreach (var item in myquery7)
            {
                Console.WriteLine(item.EmployeeId + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.Title + "\t" + item.DOB + "\t" + item.DOJ + "\t" + item.City);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no h-------------");
            var myquery8 = empList.Count();

            Console.WriteLine("Total Number of Employees are:{0}", myquery8);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no i-------------");
            var myquery9 = empList.Count(x => x.City == "Chennai");

            Console.WriteLine("Total Number of Employees in Chennai are:{0}", myquery9);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no j-------------");
            var myquery10 = empList.Max(x => x.EmployeeId);
            Console.WriteLine("The Highest Employee Id in the Table is:{0}", myquery10);


            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no k-------------");
            var myquery11 = empList.Count(x => x.DOJ > DateTime.Parse("1/1/2015"));
            Console.WriteLine("Total Number of Employees Joined after 1/1/2015 are:{0}", myquery11);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no l-------------");
            var myquery12 = empList.Count(x => x.Title != "Associate");
            Console.WriteLine("Total Number of Employees Other than Associates are:{0}", myquery12);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no m-------------");
            var myquery13 = from p in empList
                            group p by p.City into g
                            select new { City = g.Key, ProductCount = g.Count() };
            Console.WriteLine("City\t   No.of Employees");
            foreach (var group in myquery13)
            {
                Console.WriteLine(group.City + "\t\t" + group.ProductCount);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no m-------------");
            var myquery14 = from p in empList
                            group p by p.City into g
                            select new { City = g.Key, ProductCount = g.Count() };
            Console.WriteLine("City\t   No.of Employees");
            foreach (var group in myquery14)
            {
                Console.WriteLine(group.City + "\t\t" + group.ProductCount);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no n-------------");
            var myquery15 = from t in empList
                            group t by t.Title into g
                            select new { Title = g.Key, ProductCount = g.Count() };
            Console.WriteLine("Ttile\t   No.of Employees");
            foreach (var group in myquery15)
            {
                Console.WriteLine(group.Title + "\t\t" + group.ProductCount);
            }

            Console.WriteLine("==============================================================================");
            Console.WriteLine("----------question no n-------------");
            var myquery16 = empList.Max(x => x.DOB);
            var myquery17 = empList.Where(x => x.DOB == myquery16);

            foreach (var item in myquery17)
            {
                Console.WriteLine("The youngest Employee Of All the Employees is : {0} {1}", item.FirstName, item.LastName);
            }
            Console.Read();
        }
    }
}
