using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study_1
{
	abstract class Interfaces
	{
		public abstract void displayScreen(Student[] student);
		public abstract void displayStudentScreen(Student[] student);
		public abstract void displayAdminScreen();
		public abstract void displayAllStudentsScreen();
		public abstract void displayStudentRegistrationScreen();
		public abstract void introduceNewCourseScreen();
		public abstract void displayAllCoursesScreen();
	}
	class BackEnd : Interfaces
	{
		public override void displayFirstScreen(Student[] student)
		{
			Console.WriteLine("Welcome to Student Management System");
			Console.WriteLine("What is your name : \n1. Student\n2. Admin");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int n = Convert.ToInt32(Console.ReadLine());

			switch (n)
			{
				case 1:
					displayStudentScreen(student);
					break;
				case 2:
					displayAdminScreen();
					break;
			}
		}
		public override void displayStudentScreen(Student[] student)
		{
			Console.WriteLine("Welcome to Student Screen : ");
			Console.WriteLine("Here the information of student : \n1. Student Info \n2. New Registration");
			Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
			int n = Convert.ToInt32(Console.ReadLine());

			switch (n)
			{
				case 1:
					Console.WriteLine("Enter Student ID : ");
					int id = int.Parse(Console.ReadLine());
					for (int i = 0; i < student.Length; i++)
					{
						if (student[i].Student_Id == id)
						{
							Info info = new Info();
							info.Display();
						}
					}
					break;
				case 2:

					break;
			}
		}
		public override void displayAdminScreen()
		{
			throw new NotImplementedException();
		}

		public override void introduceNewCourseScreen()
		{
			throw new NotImplementedException();
		}

		public override void displayStudentRegistrationScreen()
		{
			throw new NotImplementedException();
		}

		public override void displayAllStudentsScreen()
		{
			throw new NotImplementedException();
		}

		public override void displayAllCoursesScreen()
		{
			throw new NotImplementedException();
		}
	}	}


