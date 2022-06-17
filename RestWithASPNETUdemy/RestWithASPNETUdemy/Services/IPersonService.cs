using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
    }

}
