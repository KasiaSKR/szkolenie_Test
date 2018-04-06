using EF.DAL;
using EF.Model;
using EF.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjektEF_Dzien3
{
    class PersonRepo : IRepoPerson
    {
        DbContext context;
        public PersonRepo()
        {
            context = new MyContext();
        }

        public void AddPerson(Person person)
        {
            context.Set<Person>().Add(person);
        }

        public void DeletePerson(int id)
        {
            var person = GetPersonById(id);
            context.Set<Person>().Remove(person);
            context.SaveChanges();
        }
        
        public Person GetPersonById(int id)
        {
            return context.Set<Person>().Find(id);
        }

        public void UpdatePerson(int id, Person person)
        {
            var t2 = GetPersonById(id);
            t2 = person;
            context.SaveChanges();
        }



    }
}
