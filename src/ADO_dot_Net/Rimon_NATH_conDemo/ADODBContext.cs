using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rimon_NATH_conDemo
{
    public class ADODBContext
    {
        public string ConnectionString { get; set; }

        public ADODBContext(string connectionString)
        {
            ConnectionString = connectionString;
        }


        //view all students
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * From Students", connection);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Age = reader.GetInt32(2)
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        //view single student
        public Student GetStudent(int id)
        {
            Student student = new Student();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * From Students WHERE Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    student.Id = reader.GetInt32(0);
                    student.Name = reader.GetString(1);
                    student.Age = reader.GetInt32(2);
                }
            }
            return student;
        }

        //add student
        public bool AddStudent(Student student)
        {
            if (student != null)
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Students (Id, Name, Age) VALUES(@Id, @name, @age)", connection);
                    sqlCommand.Parameters.AddWithValue("@Id", student.Id);
                    sqlCommand.Parameters.AddWithValue("@name", student.Name);
                    sqlCommand.Parameters.AddWithValue("@age", student.Age);
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete student
        public bool DeleteStudent(int id)
        {
            if (id > 0)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Students WHERE Id = @id", connection);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.ExecuteNonQuery();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        //update student
        public bool UpdateStudent(Student student)
        {
            if (student != null)
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Students SET Name = @name, Age = @age WHERE Id = @id", connection);
                    sqlCommand.Parameters.AddWithValue("@id", student.Id);
                    sqlCommand.Parameters.AddWithValue("@name", student.Name);
                    sqlCommand.Parameters.AddWithValue("@age", student.Age);
                    sqlCommand.ExecuteNonQuery();

                    return true;
                }

            }
            else
            {
                return false;
            }

        }

    }
}
