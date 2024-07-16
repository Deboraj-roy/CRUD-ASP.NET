using Microsoft.Data.SqlClient;
using System.Data;

namespace ADOTest.Data
{
    public class ADODbContext
    { 
        public string ConnectionString { get; set; }
        public ADODbContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DataTable GetPersons()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Persons", connection);
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }
        public DataTable GetPersons(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM Persons WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
            }
            return dt;
        }
        public void CreatePerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Persons (Name, Address, Email, Phone, Salary) VALUES (@Name, @Address, @Email, @Phone, @Salary)", connection);
                command.Parameters.AddWithValue("@Name", person.Name);
                command.Parameters.AddWithValue("@Address", person.Address);
                command.Parameters.AddWithValue("@Email", person.Email);
                command.Parameters.AddWithValue("@Phone", person.Phone);
                command.Parameters.AddWithValue("@Salary", person.Salary);
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Persons SET Name = @Name, Address = @Address, Email = @Email, Phone = @Phone, Salary = @Salary WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Name", person.Name);
                command.Parameters.AddWithValue("@Address", person.Address);
                command.Parameters.AddWithValue("@Email", person.Email);
                command.Parameters.AddWithValue("@Phone", person.Phone);
                command.Parameters.AddWithValue("@Salary", person.Salary);
                command.Parameters.AddWithValue("@Id", person.Id);
                command.ExecuteNonQuery();
            }
        }

        public void DeletePerson(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Persons WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
