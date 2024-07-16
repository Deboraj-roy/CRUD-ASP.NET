using System.Data;

namespace ADO_dot_Net.Data
{
    public class PersonRepository
    {
        private string ConnectionString { get; set; } = "Server=.\\SQLEXPRESS;Database=MVCCRUD;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true";

        private ADODbContext Context { get; set; }
        public PersonRepository()
        {
            Context = new ADODbContext(ConnectionString);
        }
        public List<Person> GetPeople()
        {
            DataTable dt = Context.GetPersons();
            List<Person> people = new List<Person>();
            foreach (DataRow row in dt.Rows)
            {
                people.Add(new Person
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = row["Name"].ToString(),
                    Address = row["Address"].ToString(),
                    Email = row["Email"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Salary = Convert.ToDouble(row["Salary"])
                });
            }
            return people;
        }

        public Person PersonById(int id)
        {
            if (id == 0 || id < 0)
            {
                return null;
            }

            DataTable dt = Context.GetPersons(id);
            if (dt.Rows.Count > 0)
            {

                Person person = new Person
                {
                    Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                    Name = dt.Rows[0]["Name"].ToString(),
                    Address = dt.Rows[0]["Address"].ToString(),
                    Email = dt.Rows[0]["Email"].ToString(),
                    Phone = dt.Rows[0]["Phone"].ToString(),
                    Salary = Convert.ToDouble(dt.Rows[0]["Salary"])
                };
                return person;

            }
            else
            {
                return null;
            }
        }

        public void CreatePerson(Person person)
        {
            Context.CreatePerson(person);
        }

        public void UpdatePerson(Person person)
        {
            Context.UpdatePerson(person);
        }
        public void DeletePerson(int id)
        {
            Context.DeletePerson(id);
        }
    }

}

