using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using School_Mgt.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Repository.Implementation
{
    public class GenericRepository<TEntity>// IGenericRepository<TEntity> where TEntity : class
    {

        private readonly IConfiguration _config;

        public GenericRepository(IConfiguration config)
        {
            _config = config;
        }
        //public Task CreateAsync(TEntity entity)
        //{
        //    var CS = _config.GetConnectionString("DefaultConnection");

        //    using (MySqlConnection conn = new MySqlConnection(CS))
        //    {

        //        string newCommand = $"INSERT INTO student(FirstName, LastName, BirthDate, DepartmentId, Address, PhoneNumber ) values ('{stu.FirstName}', '{stu.LastName}', '{stu.BirthDate}', {stu.DepartmentId}, '{stu.Address}', '{stu.PhoneNumber}')";
                
        //        MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
        //        conn.Open();
        //        myCommand.ExecuteNonQuery();
        //    }
        //}

        //public void Delete(TEntity entity)
        //{
        //    var CS = _config.GetConnectionString("DefaultConnection");

        //    using (MySqlConnection conn = new MySqlConnection())
        //    {
        //        string newCommand = "DELETE FROM student where StudentId = 2";
        //        MySqlCommand myCommand = new MySqlCommand(newCommand, conn);

        //        conn.Open();
        //        myCommand.ExecuteNonQuery();
        //    }
        //}

        //public void Edit(TEntity entity)
        //{
        //    var CS = _config.GetConnectionString("DefaultConnection");

        //    using (MySqlConnection conn = new MySqlConnection(CS))
        //    {
        //        string newCommand = $"INSERT INTO student(FirstName, LastName, BirthDate, DepartmentId, Address, PhoneNumber ) values ( {stu.FirstName}, {stu.LastName}, {stu.BirthDate}, {stu.DepartmentId}, {stu.Address}, {stu.PhoneNumber})";
        //        MySqlCommand myCommand = new MySqlCommand(newCommand, conn);
        //        conn.Open();
        //        myCommand.ExecuteNonQuery();
        //    }
        //}

        //public Task<IEnumerable<TEntity>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}


        //public Task<TEntity> GetByIdAsync(int entityId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
