using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using School_Mgt.Models;
using School_Mgt.Models.ViewModel;
using School_Mgt.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration _config;
        private readonly IDepartmentRepository _departmentRepo;
        
        public StudentRepository(IConfiguration config, IDepartmentRepository departmentRepo)
        {
            _config = config;
            _departmentRepo = departmentRepo;
        }

        public void Create(Student stu)
        {   
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                //string newCommand = $"INSERT INTO student(FirstName, LastName, BirthDate, DepartmentId, Address, PhoneNumber ) values ('{stu.FirstName}', '{stu.LastName}', '{stu.BirthDate}', {stu.DepartmentId}, '{stu.Address}', '{stu.PhoneNumber}')";
                //MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                MySqlCommand myCommand = new MySqlCommand("create_student", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                myCommand.Parameters.AddWithValue("FirstName", stu.FirstName);
                myCommand.Parameters.AddWithValue("LastName", stu.LastName);
                myCommand.Parameters.AddWithValue("BirthDate", stu.BirthDate);
                myCommand.Parameters.AddWithValue("PhoneNumber", stu.PhoneNumber);
                myCommand.Parameters.AddWithValue("Address", stu.Address);
                myCommand.Parameters.AddWithValue("DepartmentId", stu.DepartmentId);
                myCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Student stu)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("delete_a_student", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                myCommand.Parameters.AddWithValue("@StudentId", stu.StudentId);
                myCommand.ExecuteNonQuery();               
            }
        }

        public IList<Student> GetAllStudents()
        {
            var stu = new List<Student>();
            var CS = _config.GetConnectionString("DefaultConnection");


            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                //string newCommand = "SELECT * FROM student";
                MySqlCommand myCommand = new MySqlCommand("get_all_students", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                //myCommand.Parameters.Add()

                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    var student = new Student()
                    {
                       StudentId = Convert.ToInt32(rdr["StudentId"]),
                        FirstName = rdr["FirstName"].ToString(),
                        LastName = rdr["LastName"].ToString(),
                        BirthDate = rdr["BirthDate"].ToString(),
                        DepartmentId = Convert.ToInt32(rdr["DepartmentId"]),
                        Address = rdr["Address"].ToString(),
                        PhoneNumber = rdr["PhoneNumber"].ToString(),
                        Department = _departmentRepo.GetDeptById(Convert.ToInt32(rdr["DepartmentId"]))
                    };
                    stu.Add(student);
                }
                return (stu);
            }

        }

        public IList<CourseStudentViewModel> GetStudentCourses()
        {
            var stu = new List<CourseStudentViewModel>();
            var CS = _config.GetConnectionString("DefaultConnection");


            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                //string newCommand = "SELECT * FROM student";
                MySqlCommand myCommand = new MySqlCommand("get_student_course", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                //myCommand.Parameters.Add()

                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    var student = new CourseStudentViewModel()
                    {
                        //StudentId = Convert.ToInt32(rdr["StudentId"]),
                        //FirstName = rdr["FirstName"].ToString(),
                        //LastName = rdr["LastName"].ToString(),
                        //BirthDate = rdr["BirthDate"].ToString(),
                        //DepartmentId = Convert.ToInt32(rdr["DepartmentId"]),
                        //Address = rdr["Address"].ToString(),
                        //PhoneNumber = rdr["PhoneNumber"].ToString()
                    };
                    stu.Add(student);
                }
                return (stu);
            }

        }

        public Student GetStudentById(int? id)
        {
            Student stu = new Student();
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"SELECT * FROM student WHERE StudentId = {id}";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                        stu.StudentId = Convert.ToInt32(rdr["StudentId"]);
                        stu.FirstName = rdr["FirstName"].ToString();
                        stu.LastName = rdr["LastName"].ToString();
                        stu.BirthDate = rdr["BirthDate"].ToString();
                        stu.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                        stu.Address = rdr["Address"].ToString();
                        stu.PhoneNumber = rdr["PhoneNumber"].ToString();
                        stu.Department = _departmentRepo.GetDeptById(Convert.ToInt32(rdr["DepartmentId"]));
                   
                };
                return stu;
            }
        }

        public void Update(Student stu)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
               // string newCommand = $"UPDATE FROM student(FirstName, LastName, BirthDate, DepartmentId, Address, PhoneNumber ) values ( {stu.FirstName}, {stu.LastName}, {stu.BirthDate}, {stu.DepartmentId}, {stu.Address}, {stu.PhoneNumber})";
                MySqlCommand myCommand = new MySqlCommand("edit_student", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                conn.Open();
                myCommand.Parameters.AddWithValue("@StudentId", stu.StudentId);
                myCommand.Parameters.AddWithValue("@FirstName", stu.FirstName);
                myCommand.Parameters.AddWithValue("@LastName", stu.LastName);
                myCommand.Parameters.AddWithValue("@BirthDate", stu.BirthDate);
                myCommand.Parameters.AddWithValue("@DepartmentId", stu.DepartmentId);
                myCommand.Parameters.AddWithValue("@Address", stu.Address);
                myCommand.Parameters.AddWithValue("@PhoneNumber", stu.PhoneNumber);
                myCommand.ExecuteNonQuery();
            }
        }

       
    }
}
