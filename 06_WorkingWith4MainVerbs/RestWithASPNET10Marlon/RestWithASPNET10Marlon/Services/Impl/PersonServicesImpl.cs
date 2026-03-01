using RestWithASPNET10Marlon.Model;

namespace RestWithASPNET10Marlon.Services.Impl
{
    public class PersonServicesImpl : IPersonServices
    {
        Person IPersonServices.FindById(long id)
        {
            var person = MockPerson((int) id);
            return person;
        }

        List<Person> IPersonServices.FindAll()
        {
            List<Person> persons = new List<Person>();

            for(int i = 0; i<10; i++)
            {
                persons.Add(MockPerson(i));
            }
            return persons;
        }

        Person IPersonServices.Create(Person person)
        {
            person.Id = new Random().Next(1, 1000);
            return person;
        }

        Person IPersonServices.Update(Person person)
        {
            return person;
        }

        void IPersonServices.Delete(long id)
        {
            //simulate delete
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "Marlon " + i,
                LastName = "Lacerda " + i,
                Address = "Vitória - ES - Brasil " + i,
                Gender = "Male"
            };
        }
    }
}
