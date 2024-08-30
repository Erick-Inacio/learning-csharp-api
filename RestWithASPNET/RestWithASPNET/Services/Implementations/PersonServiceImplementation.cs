using RestWithASPNET.Model;

namespace RestWithASPNET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int counter;

        Person IPersonService.Create(Person person)
        {
            return person;
        }

        void IPersonService.Delete(long id)
        {
        }

        List<Person> IPersonService.FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i); // new Person();
                people.Add(person); // person
            }


            return people;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro " + i,
                LastName = "Silva",
                Address = "Uberlandia - MG",
                Gender = "Male"
            };
        }

        Person IPersonService.FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro" + 1,
                LastName = "Silva" + 1,
                Address = "Uberlandia - MG" + 1,
                Gender = "Male" + 1
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref counter);
        }

        Person IPersonService.Update(Person person)
        {
            return person;
        }
    }
}
