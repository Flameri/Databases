using System;
using System.Collections.Generic;
using System.Text;
using PersonDb.Model;

namespace PersonDb.Repositories
{
    interface IPersonRepository
    {
        List<Person> Read();
        Person GetPersonById(int id);
        void Create(Person person);
        void Update(Person person, int id);
        void Delete(int id);
    }
}
