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
    public class CourseRepository : ICourseRepository
    {
        private readonly IConfiguration _config;
        public CourseRepository(IConfiguration config)
        {
            _config = config;
        }
        public void Create(Course course)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"INSERT INTO Course(CourseName, CourseUnit, Grade, Score, GradeUnit, Cumulative) values ( '{course.CourseName}', {course.CourseUnit}, '{course.GradeUnit}', {course.Score}, {course.GradeUnit}, {course.Cumulative})";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                myCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Course course)
        {

            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("delete_a_course", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                myCommand.Parameters.AddWithValue("@CourseId", course.CourseId);
                myCommand.ExecuteNonQuery();
            }
        }

        public IList<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            var CS = _config.GetConnectionString("DefaultConnection");


            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("get_all_courses", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    var course = new Course()
                    {
                        CourseId = Convert.ToInt32(rdr["CourseId"]),
                        CourseName = rdr["CourseName"].ToString(),
                        CourseUnit = Convert.ToInt32(rdr["CourseUnit"]),
                        Grade = Convert.ToChar(rdr["Grade"]),
                        Score = Convert.ToInt32(rdr["Score"]),
                       GradeUnit = Convert.ToInt32(rdr["GradeUnit"]),
                       Cumulative = Convert.ToInt32(rdr["Cumulative"])
                    };
                    courses.Add(course);
                }
                return (courses);
            }

        }

        public Course GetCourseById(int? id)
        {
            Course course = new Course();
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"SELECT * FROM Course WHERE CourseId = {id}";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    course.CourseId = Convert.ToInt32(rdr["CourseId"]);
                    course.CourseName = rdr["CourseName"].ToString();
                    course.CourseUnit = Convert.ToInt32(rdr["CourseUnit"]);
                    course.Grade = Convert.ToChar(rdr["Grade"]);
                    course.Score = Convert.ToInt32(rdr["Score"]);
                    course.GradeUnit = Convert.ToInt32(rdr["GradeUnit"]);
                    course.Cumulative = Convert.ToInt32(rdr["Cumulative"]);
                };
                return course;
            }

        }

        public void Update(Course course)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                MySqlCommand myCommand = new MySqlCommand("edit_course_name", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                conn.Open();
                myCommand.Parameters.AddWithValue("@CourseId", course.CourseId);
                myCommand.Parameters.AddWithValue("@CourseName", course.CourseName);
                myCommand.Parameters.AddWithValue("@CourseUnit", course.CourseUnit);
                myCommand.Parameters.AddWithValue("@Grade", course.Grade);
                myCommand.Parameters.AddWithValue("@Score", course.Score);
                myCommand.Parameters.AddWithValue("@GradeUnit", course.GradeUnit);
                myCommand.Parameters.AddWithValue("@Cumulative", course.Cumulative);
                myCommand.ExecuteNonQuery();
            }
            
        }
    }
}
