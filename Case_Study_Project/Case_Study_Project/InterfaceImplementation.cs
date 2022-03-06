using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Case_Study_Project
{
    internal class InterfaceImplementation:Interface1
    {
        private string res;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        AppEngine ae = new AppEngine();
        public override void showAllStudentsScreen()
        {
            ae.ListOfStudents();
        }
        public override void showStudentRegistrationScreen()
        {
            ae.Register();
        }
        public override void introduceNewCourseScreen()
        {
            ae.Introduce();
        }
        public override void showAllCoursesScreen()
        {
            ae.ListOfCourses();
        }
        public override void showFirstScreen()
        {


            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                }
                Console.WriteLine();
                Console.Write("Do You want to continue in Main Menu (Y | N):");
                res = Console.ReadLine();
            } while ((res == "yes") || (res == "Yes") || (res == "y") || (res == "Y"));

        }

        public override void showStudentScreen()
        {
            AppEngine ae = new AppEngine();
            List<int> list = new List<int>();
            con = ae.Getconnection();
            Console.Write("Enter Your Student Id to Login:");
            int sid = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("select Student_id from Student", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int j = 0; j < dr.FieldCount; j++)
                {
                    list.Add((int)dr[j]);
                }
            }
            con.Close();
            if (list.Contains(sid))
            {
                Console.WriteLine("Login Successfull");
                Console.WriteLine();
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("------------STUDENT PAGE-----------");
                    Console.WriteLine();
                    Console.WriteLine("What do you Want to do \n1.Display your Details\n2.Update your Details\n3.View Available Courses\n4.Enroll Course");
                    Console.Write("Enter Your Choice:");
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            ae.ViewYourDetails(sid);
                            break;
                        case 2:
                            ae.UpdateStudent();
                            break;
                        case 3:
                            showAllCoursesScreen();
                            break;
                        case 4:
                            ae.Enrollment();
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Do you want to continue in Student : Yes or No ");
                    res = Console.ReadLine();
                } while ((res == "yes") || (res == "Yes") || (res == "y") || (res == "Y"));

            }
            else
            {
                Console.WriteLine("You are not Registerd, Contact Admin to Register");
            }

        }
        public override void showAdminScreen()
        {
            List<int> list = new List<int>();
            Console.Write("Enter Admin Id to Login:");
            int n = int.Parse(Console.ReadLine());
            AppEngine ae = new AppEngine();
            con = ae.Getconnection();
            cmd = new SqlCommand("select Admin_id from Admin Where Admin_id=@id", con);
            cmd.Parameters.AddWithValue("@id", n);
            dr = cmd.ExecuteReader();
            //cmd.Parameters.AddWithValue()
            while (dr.Read())
            {
                for (int j = 0; j < dr.FieldCount; j++)
                {


                    list.Add((int)dr[j]);
                }
            }
            con.Close();
            if (list.Contains(n))
            {
                Console.WriteLine("Login Successfull");
                Console.WriteLine("------ADMIN PAGE-----------");
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("What Do you want to do\n1.View All Students\n2.View All Courses\n3.Register Student\n4.Delete Student\n5.Introduce New Course\n6.Update Course Details\n7.Delete Existing Course\n8.View All Enrollments\n");
                    Console.WriteLine("Enter Your Choice:");
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            showAllStudentsScreen();
                            break;
                        case 2:
                            showAllCoursesScreen();
                            break;
                        case 3:
                            showStudentRegistrationScreen();
                            break;
                        case 4:
                            ae.DeleteStudent();
                            break;
                        case 5:
                            introduceNewCourseScreen();
                            break;
                        case 6:
                            ae.UpdateCourse();
                            break;
                        case 7:
                            ae.DeleteCourse();
                            break;
                        case 8:
                            ae.ListOfEnrollment();
                            break;
                    }
                    Console.WriteLine();
                    Console.Write("Do you Want to Continue in Admin:");
                    res = Console.ReadLine();
                } while ((res == "yes") || (res == "Yes") || (res == "y") || (res == "Y"));
            }
            else
            {
                Console.WriteLine("You are Not Authenticated.");
            }

        }
    }
}
