using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using School_Mgt.Models;
using School_Mgt.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Implementation
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly IConfiguration _config;

        public TeacherRepository(IConfiguration config)
        {
            _config = config;
        }

        public void Create(Teacher teach)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
               // string newCommand = $"INSERT INTO Teacher(TeacherName, JobTitle, ReportTo) values ('{teach.TeacherName}', '{teach.JobTitle}', {teach.ReportTo})";
               // MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                MySqlCommand myCommand = new MySqlCommand("create_teacher", conn);
                 myCommand.CommandType = CommandType.StoredProcedure;
                conn.Open();
                myCommand.Parameters.AddWithValue("TeacherName", teach.TeacherName);
                myCommand.Parameters.AddWithValue("JobTitle", teach.JobTitle);
                myCommand.Parameters.AddWithValue("ReportTo", teach.ReportTo);
               
                myCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Teacher teach)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("delete_a_student", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                myCommand.Parameters.AddWithValue("@TeacherId", teach.TeacherId);
                myCommand.ExecuteNonQuery();
            }

        }

        public IList<Teacher> GetAllTeachers()
        {
            var teachers = new List<Teacher>();
            var CS = _config.GetConnectionString("DefaultConnection");


            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("get_all_teachers", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    var teach = new Teacher()
                    {
                        TeacherId = Convert.ToInt32(rdr["TeacherId"]),
                        TeacherName = rdr["TeacherName"].ToString(),
                        JobTitle = rdr["JobTitle"].ToString(),
                        ReportTo = Convert.ToInt32(rdr["ReportTo"])
                    };
                    teachers.Add(teach);
                }
                return (teachers);
            }

        }

        public Teacher GetTeacherById(int? id)
        {
            Teacher teach = new Teacher();
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = "SELECT * FROM student";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    if (Convert.ToInt32(rdr["StudentId"]) == id)
                    {
                        teach.TeacherId = Convert.ToInt32(rdr["TeacherId"]);
                        teach.TeacherName = rdr["TeacherName"].ToString();
                        teach.JobTitle = rdr["JobTitle"].ToString();
                        teach.ReportTo = Convert.ToInt32(rdr["ReportTo"]);
                    }

                };
                return teach;
            }
        }

        public void Update(Teacher teach)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {

                MySqlCommand myCommand = new MySqlCommand("edit_student_name", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                conn.Open();
                myCommand.Parameters.AddWithValue("@TeacherId", teach.TeacherId);
                myCommand.Parameters.AddWithValue("@TeacherName", teach.TeacherName);
                myCommand.Parameters.AddWithValue("@JobTitle", teach.JobTitle);
                myCommand.Parameters.AddWithValue("@ReportTo", teach.ReportTo);
                myCommand.ExecuteNonQuery();
            }
        }


    }
}
