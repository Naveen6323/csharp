﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DBManagement
{
    abstract class users
    {
        
        public int id { get; set; }
        [Required(ErrorMessage ="name is required")]
        public string name { get; set; }
        [Range(18, 100, ErrorMessage = "age shoule be more than 17")]
        public int age { get; set; }
        [Required(ErrorMessage = "email is required")]
        [RegularExpression(@"^[a-zA-Z0-9.]+@gmail.com$", ErrorMessage = "provide valid gmail address like xxxx@gmail.com or xxxx.xxx@gmail.com")]
        public string email { get; set; }
        
        public abstract void InsertData(string name,string email,int age);
        public abstract void UpdateData(int id,string name,string email,int age);
        public abstract void DeleteData(int id);
        public string ToString(int id,string name,string email,int age)
        {
            return "id: " + id + ", name: " + name + ", age: " + age + ", email: " + email;
        }
    }
    class DataManipulationCommands:users
    {
        SqlConnection con;
        string conString = @"Data Source=NAVEEN\SQLEXPRESS01;Initial Catalog=naveenc#;Integrated Security=True";
        public DataManipulationCommands()
        {
            con = new SqlConnection(conString);
        }
        public override void InsertData(string name,string email,int age)
        {
            DataManipulationCommands obj = new DataManipulationCommands();
            if(isDetailsValid(name, email, age))
            {

                try
                {
                    obj.con.Open();
                    int lastID = obj.GetLastID(obj);
                    obj.ResetIndex(obj, lastID);
                    string insertQuery = "insert into users values('" + name + "','" + email + "'," + age + ")";
                    SqlCommand cmd3 = new SqlCommand(insertQuery, obj.con);
                    cmd3.ExecuteNonQuery();
                    Console.WriteLine("Data inserted successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    obj.con.Close();
                    Console.WriteLine("connection closed");
                }
            }
            else
            {
                Console.WriteLine(" enter valid details");
            }
        }
            
               
        
        public bool isDetailsValid(string name,string email,int age)
        {
            DataManipulationCommands p = new DataManipulationCommands()
            {
                name = name,
                email = email,
                age = age
            };
            //DataManipulationCommands users = new DataManipulationCommands();
            var context = new ValidationContext(p) ;
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(p, context, results,true);
            if (isValid==true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("validation errors");
                foreach (var VARIABLE in results)
                {
                    Console.WriteLine($"->{VARIABLE.ErrorMessage}");
                }
                return false;
            }
        }
        public int GetLastID(DataManipulationCommands obj)
        {
            //DataManipulationCommands obj = new DataManipulationCommands();
            string q = "SELECT MAX(id) FROM users";
            SqlCommand cmd = new SqlCommand(q, obj.con);
            return (int)cmd.ExecuteScalar();
        }
        public void ResetIndex(DataManipulationCommands obj,int lastID)
        {
            string reset = $"dbcc CHECKIDENT ('users', RESEED, {lastID})";
            SqlCommand cmd = new SqlCommand(reset, obj.con);
            cmd.ExecuteNonQuery();
        }
        public override void UpdateData(int id, string name, string email, int age)
        {
            //int count; 
            DataManipulationCommands obj = new DataManipulationCommands();
            if (IDExist(id))
            {
                try
                {
                    obj.con.Open();
                    string updateQuery = $"update users set username='{name}',email='{email}',age={age} where id={id}";
                    SqlCommand cmd = new SqlCommand(updateQuery, obj.con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data updated successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    obj.con.Close();
                    Console.WriteLine("connection closed");
                }
            }
            else
            {
                Console.WriteLine("id does not exist");
            }
            
        }
        
        public bool IDExist(int id)
        {
            DataManipulationCommands obj = new DataManipulationCommands();
            try
            {
                obj.con.Open();
                string checkQuery = $"select count(*) from users where id={id}";
                SqlCommand cmd = new SqlCommand(checkQuery, obj.con);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0) return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                obj.con.Close();
                //Console.WriteLine("conn closed");
            }
            return false;
        }
        public override void DeleteData(int id)
        {
            DataManipulationCommands obj = new DataManipulationCommands();
            if (IDExist(id))
            {
                try
                {
                    obj.con.Open();
                    string query = "delete from users where id=" + id;
                    SqlCommand cmd = new SqlCommand(query, obj.con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("data deleted successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    obj.con.Close();
                    Console.WriteLine("connection closed");
                }
            }
            else
            {
                Console.WriteLine("id does not exist");
            }
        }
        public void GetLastid()
        {
            DataManipulationCommands obj = new DataManipulationCommands();
            try
            {
                obj.con.Open();
                string query = "SELECT MAX(id) FROM users";
                SqlCommand cmd = new SqlCommand(query, obj.con);
                int id = (int)cmd.ExecuteScalar();
                Console.WriteLine("Last id is: " + id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                obj.con.Close();
                Console.WriteLine("connection closed");
            }
        }
        public void GetAllData()
        {
            DataManipulationCommands obj = new DataManipulationCommands();
            if (IsEmpty())
            {
                try
                {
                    obj.con.Open();
                    string q = "select * from users";
                    SqlCommand cmd = new SqlCommand(q, obj.con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        Console.WriteLine(obj.ToString((int)dr[0], dr[1].ToString(), dr[2].ToString(), (int)dr[3]));
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally
                {
                    obj.con.Close();
                    Console.WriteLine("connection closed");
                }
            }
            else
            {
                Console.WriteLine("table is empty");
            }

        }
        public bool IsEmpty()
        {
            DataManipulationCommands obj = new DataManipulationCommands();
        
            try
            {
                obj.con.Open();
                string q = "select count(*) from users";
                SqlCommand cmd = new SqlCommand(q, obj.con);
                int c = (int)cmd.ExecuteScalar();
                if (c > 0) return true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                obj.con.Close();
            }
            return false;
            
        }
    }
}
