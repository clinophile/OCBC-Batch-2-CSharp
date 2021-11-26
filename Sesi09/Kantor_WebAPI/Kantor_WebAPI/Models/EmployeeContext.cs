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
            }

            return list;
        }

        // public void SetEmployee(String id, string nama, string jenisKelamin, string alamat)
        // {

        //     using (MySqlConnection conn = GetConnection())
        //     {
        //         conn.Open();
        //         MySqlCommand cmd = new MySqlCommand("INSERT INTO EMPLOYEE(id, nama, jenis_kelamin, alamat) " +
        //             "VALUES(@id, @nama, @jenisKelamin, @alamat)", conn);
        //         cmd.Parameters.AddWithValue("@id", id);
        //         cmd.Parameters.AddWithValue("@nama", nama);
        //         cmd.Parameters.AddWithValue("@jenisKelamin", jenisKelamin);
        //         cmd.Parameters.AddWithValue("@alamat", alamat);

                
        //     }
        // }
              
                        

    }
}
