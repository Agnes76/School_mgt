//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace School_Mgt.Data
//{
//    public class DataContext<T>
//    {
//        public string ConnectionString { get; set; }

//        public DataContext(string connectionString)
//        {
//            ConnectionString = connectionString;
//        }

//        public void RunQueryToSQLDb(string sqlCommand)
//        {
//            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
//            {
//                MySqlCommand myCommand = new MySqlCommand(sqlCommand, conn);
//                conn.Open();
//                myCommand.ExecuteNonQuery();
//            }

//        }
//    }
//}
