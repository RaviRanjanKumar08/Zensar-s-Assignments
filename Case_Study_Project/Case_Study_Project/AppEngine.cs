using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Case_Study_Project
{
    public class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public void Introduce()
        {
            try
            {
                con = Getconnection();
                Console.Write("Enter How many Courses you want to add:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course Details");
                for (int i = 0; i < n; i++)
                {

                    int cid;
                    string cname, cduration;
                    float fees;
                    Console.Write("Enter Course Id: ");
                    cid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Course Name: ");
                    cname = Console.ReadLine();
                    Console.Write("Enter Course Duration: ");
                    cduration = Console.ReadLine();

                    Console.Write("Enter Course Fees: ");
                    fees = float.Parse(Console.ReadLine());

                    cmd = new SqlCommand("insert into Courses values(@cid,@cname,@cduration,@cfees)");

                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@cduration", cduration);
                    cmd.Parameters.AddWithValue("@cfees", fees);
                    cmd.Connection = con;
                    int no_ofrows = cmd.ExecuteNonQuery();
                    if (no_ofrows > 0)
                    {

                        Console.WriteLine("Course Added Successfully..");
                    }
                    else
                        Console.WriteLine("Oops !! encountered problem");
                }
                con.Close();

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }


        }
        public void Register()
        {
            try
            {
                con = Getconnection();
                Console.Write("Enter How many students you want to add:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter Student Details Below");
                    int studentid;
                    string studentname;
                    DateTime studentdob;
                    Console.Write("Enter Student Id:");
                    studentid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Student Name:");
                    studentname = Console.ReadLine();
                    Console.Write("Enter Student Dateofbirth:");
                    studentdob = DateTime.Parse(Console.ReadLine());
                    cmd = new SqlCommand("insert into Student values(@sid,@sname,@sdob)");
                    cmd.Parameters.AddWithValue("@sid", studentid);
                    cmd.Parameters.AddWithValue("@sname", studentname);
                    cmd.Parameters.AddWithValue("@sdob", studentdob);
                    cmd.Connection = con;
                    int no_ofrows = cmd.ExecuteNonQuery();
                    if (no_ofrows > 0)
                    {

                        Console.WriteLine("Student Added Successfully..");
                    }
                    else
                        Console.WriteLine("Oops !! encountered problem");
                }
                con.Close();

            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }


        public void ListOfStudents()
        {
            try
            {
                con = Getconnection();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine("Student Details");
                Console.WriteLine("====================================================");
                Console.WriteLine("Student Id       Student Name    Student DateofBirth");
                Console.WriteLine("----------       ------------    -------------------");
                while (dr.Read())
                {
                    Console.WriteLine();

                    Console.WriteLine(dr[0] + "               " + dr[1] + "           " + dr[2]);



                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListOfCourses()
        {
            try
            {
                con = Getconnection();
                cmd = new SqlCommand("select * from Courses", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine("Course Details");
                Console.WriteLine("===============================================================");
                Console.WriteLine("Course Id       Course Name    Course Duration      Course Fees");
                Console.WriteLine("---------       -----------    ---------------      -----------");
                while (dr.Read())
                {
                    Console.WriteLine();

                    Console.WriteLine(dr[0] + "               " + dr[1] + "           " + dr[2] + "           " + dr[3]);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }

        public void Enrollment()
        {
            try
            {
                List<int> list = new List<int>();

                con = Getconnection();
                Console.Write("Enter How many Courses you want to Enroll:");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter Enroll Details:");
                    int sid, cid;
                    DateTime datetime;
                    Console.WriteLine("Enter Existing  Student Id:");
                    sid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Existing Course Id:");
                    cid = Convert.ToInt32(Console.ReadLine());

                    datetime = DateTime.Now;

                    cmd = new SqlCommand("select course_id from Courses", con);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        for (int j = 0; j < dr.FieldCount; j++)
                        {
                            list.Add((int)dr[j]);
                        }
                    }
                    con.Close();
                    if (list.Contains(cid))
                    {
                        cmd = new SqlCommand("insert into Enroll values(@sid,@sname,@sdob)");
                        cmd.Parameters.AddWithValue("@sid", sid);
                        cmd.Parameters.AddWithValue("@sname", cid);
                        cmd.Parameters.AddWithValue("@sdob", datetime);
                        con.Open();
                        cmd.Connection = con;
                        int no_ofrows = cmd.ExecuteNonQuery();
                        if (no_ofrows > 0)
                        {

                            Console.WriteLine("Student Enrolled Successfully..");
                        }
                        else
                            Console.WriteLine("Oops !! encountered problem");
                    }
                    else
                    {
                        Console.WriteLine("The Course you enter is not Exist.");
                    }


                }
                con.Close();
            }

            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }

        public void ListOfEnrollment()
        {
            try
            {
                con = Getconnection();
                cmd = new SqlCommand("select * from Enroll", con);
                dr = cmd.ExecuteReader();
                Console.WriteLine("Enrollment Details");
                Console.WriteLine("===============================================================");
                Console.WriteLine("Student_Id       Course_Id    DateofEnrollment");
                Console.WriteLine("----------       ---------    ----------------");
                while (dr.Read())
                {
                    Console.WriteLine();

                    Console.WriteLine(dr[0] + "               " + dr[1] + "           " + dr[2]);



                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
        }
        public void ViewYourDetails(int id)
        {
            try
            {
                con = Getconnection();
                cmd = new SqlCommand("select * from Student Where student_id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id:" + dr[0]);
                    Console.WriteLine("Student Name:" + dr[1]);
                    Console.WriteLine("Student Date Of Birth:" + dr[2]);
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void UpdateStudent()
        {
            try
            {
                con = Getconnection();
                Console.WriteLine("Enter the Student id Where to be Updated:");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name value to update:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Student Date of Birth value to update:");
                DateTime datetime = DateTime.Parse(Console.ReadLine());

                SqlCommand cmd1 = new SqlCommand("select * from Student where student_id=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", sid);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                con.Close();
                Console.WriteLine("Are you sure to Update this record ? Y/N");
                string status = Console.ReadLine();
                if (status == "y" || status == "Y")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UpdateStudent";
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter par1 = new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = sid,
                        Direction = ParameterDirection.Input,

                    };
                    SqlParameter par2 = new SqlParameter
                    {
                        ParameterName = "@sn",
                        SqlDbType = SqlDbType.VarChar,
                        Value = name,
                        Direction = ParameterDirection.Input,

                    };
                    SqlParameter par3 = new SqlParameter
                    {
                        ParameterName = "@sd",
                        SqlDbType = SqlDbType.DateTime,
                        Value = datetime,
                        Direction = ParameterDirection.Input,

                    };

                    cmd.Parameters.Add(par1);
                    cmd.Parameters.Add(par2);
                    cmd.Parameters.Add(par3);
                    con.Open();
                    cmd.Connection = con;
                    SqlDataReader res = cmd.ExecuteReader();
                    while (res.Read())
                    {
                        Console.WriteLine("Record Updated successfuly");
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeleteStudent()
        {
            try
            {
                con = Getconnection();
                Console.WriteLine("Enter the Student id to be deleted:");
                int sid = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("select * from Student where student_id=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", sid);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                con.Close();
                Console.WriteLine("Are you sure to delete this record ? Y/N");
                string status = Console.ReadLine();
                if (status == "y" || status == "Y")
                {
                    cmd = new SqlCommand("delete from Student where student_id=@eid");
                    cmd.Parameters.AddWithValue("@eid", sid);
                    con.Open();
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record deleted successfuly");
                    }
                    else
                        Console.WriteLine("Could not delete the record..");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateCourse()
        {

            try
            {
                con = Getconnection();
                Console.WriteLine("Enter the Course id Where to be Updated:");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name value to update:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Course duration value to update:");
                string dur = Console.ReadLine();
                Console.WriteLine("Enter Course Fees value to update:");
                float fees = float.Parse(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("select * from Courses where course_id=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", cid);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                con.Close();
                Console.WriteLine("Are you sure to Update this record ? Y/N");
                string status = Console.ReadLine();
                if (status == "y" || status == "Y")
                {
                    cmd1 = new SqlCommand("update Courses set course_name=@cname,course_duration=@cd,course_fees=@cf where course_id=@eid", con);
                    cmd1.Parameters.AddWithValue("@eid", cid);
                    cmd1.Parameters.AddWithValue("@cname", name);
                    cmd1.Parameters.AddWithValue("@cd", dur);
                    cmd1.Parameters.AddWithValue("@cf", fees);
                    con.Open();
                    cmd1.Connection = con;
                    int res = cmd1.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record Updated successfuly");
                    }
                    else
                        Console.WriteLine("Could not update the record..");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeleteCourse()
        {

            try
            {
                con = Getconnection();
                Console.Write("Enter the Course id to be deleted:");
                int cid = Convert.ToInt32(Console.ReadLine());
                SqlCommand cmd1 = new SqlCommand("select * from Courses where course_id=@eid", con);
                cmd1.Parameters.AddWithValue("@eid", cid);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    for (int i = 0; i < dr1.FieldCount; i++)
                    {
                        Console.WriteLine(dr1[i]);
                    }
                }
                con.Close();
                Console.WriteLine("Are you sure to delete this record ? Y/N");
                string status = Console.ReadLine();
                if (status == "y" || status == "Y")
                {
                    cmd = new SqlCommand("delete from Courses where course_id=@eid");
                    cmd.Parameters.AddWithValue("@eid", cid);
                    con.Open();
                    cmd.Connection = con;
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        Console.WriteLine("Record deleted successfuly");
                    }
                    else
                        Console.WriteLine("Could not delete the record..");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public SqlConnection Getconnection()
        {
            con = new SqlConnection("data source=LAPTOP-6R95OGR0; initial catalog=studentManagement;integrated Security=true");
            con.Open();
            return con;
        }
    }
}
