using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kantor_WebAPI.Models
{
    public class EmployeeContext
    {
        public string connectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM EMPLOYEE", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
            }
            
            return list;
        }


        public List<EmployeeItem> GetEmployee (string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM EMPLOYEE WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jenisKelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")
                        });
                    }
                }
                conn.Close();
            }


            return list;
        }

         public List<EmployeeItem> SetEmployee(EmployeeItem newEmployee)
         {

             using (MySqlConnection conn = GetConnection())
             {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO EMPLOYEE(nama, jenis_kelamin, alamat) " +
                     "VALUES(@nama, @jenisKelamin, @alamat)", conn);
                cmd.Parameters.AddWithValue("@nama", newEmployee.nama);
                cmd.Parameters.AddWithValue("@jenisKelamin", newEmployee.jenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", newEmployee.alamat);

                cmd.ExecuteNonQuery();
                var id = cmd.LastInsertedId;

                conn.Close();
                
                return GetEmployee(id.ToString());

            }
         }

        public List<EmployeeItem> UpdateEmployee(string id, EmployeeItem newEmployee)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE EMPLOYEE " +
                     "SET nama = @nama, jenis_kelamin = @jenisKelamin, alamat = @alamat " +
                     "WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", newEmployee.nama);
                cmd.Parameters.AddWithValue("@jenisKelamin", newEmployee.jenisKelamin);
                cmd.Parameters.AddWithValue("@alamat", newEmployee.alamat);

                cmd.ExecuteNonQuery();
                conn.Close();
                return GetEmployee(id.ToString());

            }
        }

        public bool DeleteEmployee(string id)
        {

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var listEmployee = GetEmployee(id);
                if (listEmployee.Count != 0)
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM EMPLOYEE " +
                         "WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                    
                    conn.Close();
                    return true;
                }

                conn.Close();
                return false;

            }
        }



    }
}
