using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implemetations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
                
            }
            return persons;
        }


        public Person FindByID(long Id)
        {
            return new Person()
            {
                Id = 1,
                FirstName = "Pedro",
                LastName = "Silva",
                Address = "São Paulo",
                Gender = "Male"
               
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person()
            {
                Id = IncrementAndGet(),
                FirstName = "Person name " + i,
                LastName = "Person last name",
                Address = "São Paulo",
                Gender = "Male"

            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
