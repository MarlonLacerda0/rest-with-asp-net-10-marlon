using RestWithASPNET10Marlon.Model;

namespace RestWithASPNET10Marlon.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
