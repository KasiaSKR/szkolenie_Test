using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Model;

namespace EF.Repository
{
    public interface IRepoPerson
    {
        //List<Person> GetAll();

        Person GetPersonById(int id);
        
        void AddPerson(Person person);
        void DeletePerson(int id);
        void UpdatePerson(int id, Person person);
    }
}
