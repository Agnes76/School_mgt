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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IConfiguration _config;
        public DepartmentRepository(IConfiguration config)
        {
            _config = config;
        }
        public void Create(Department dept)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"INSERT INTO Department(DepartmentName, Size) values ( '{dept.DepartmentName}', {dept.Size})";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                myCommand.Parameters.AddWithValue("DepartmentName", dept.DepartmentName);
                myCommand.Parameters.AddWithValue("Size", dept.Size);
                myCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Department dept)
        {

            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection())
            {
                MySqlCommand myCommand = new MySqlCommand("delete_a_student", conn);
                myCommand.CommandType = CommandType.StoredProcedure;

                conn.Open();
                myCommand.Parameters.AddWithValue("@DepartmentId", dept.DepartmentId);
                myCommand.ExecuteNonQuery();
            }
        }

        public IList<Department> GetAllDepts()
        {
            var depts = new List<Department>();
            var CS = _config.GetConnectionString("DefaultConnection");


            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                //string newCommand = "SELECT * FROM student";
                MySqlCommand myCommand = new MySqlCommand("get_all_depts", conn);
                myCommand.CommandType = CommandType.StoredProcedure;
                //myCommand.Parameters.Add()

                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    var dept = new Department()
                    {
                        DepartmentId = Convert.ToInt32(rdr["DepartmentId"]),
                        DepartmentName = rdr["DepartmentName"].ToString(),
                        Size = Convert.ToInt32(rdr["Size"])
                    };
                    depts.Add(dept);
                }
                return (depts);
            }

        }

        public Department GetDeptById(int? id)
        {
            Department dept = new Department();
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"SELECT * FROM Department WHERE DepartmentId = {id}";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                MySqlDataReader rdr = myCommand.ExecuteReader();

                while (rdr.Read())
                {
                    dept.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                    dept.DepartmentName = rdr["DepartmentName"].ToString();
                    dept.Size = Convert.ToInt32(rdr["Size"]);
                };
                return dept;
            }
        }

        public void Update(Department dept)
        {
            var CS = _config.GetConnectionString("DefaultConnection");

            using (MySqlConnection conn = new MySqlConnection(CS))
            {
                string newCommand = $"INSERT INTO Department(DepartmentName, Size) values ( '{dept.DepartmentName}', {dept.Size})";
                MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
                conn.Open();
                myCommand.ExecuteNonQuery();
            }
        }
    }
}
