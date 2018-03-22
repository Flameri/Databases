using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PersonDb.Model;
using System.Linq;

namespace PersonDb.Repositories
{
    class PersonRepository
    {
        private static PersondbContext _context = new PersondbContext();

        public static void Create(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public static List<Person> Read()
        {
            List<Person> persons = _context.Person.ToListAsync().Result;
            return persons;
        }
        public static Person GetPersonById(int id)
        {
            var person = _context.Person.FirstOrDefault(p => p.Id == id);
            return person;
        }

        public static void Update(int id, Person person)
        {
            var updatePerson = GetPersonById(id);
            if (updatePerson != null)
            {
                _context.Person.Update(person);
            }
            _context.SaveChanges();
        }
        public static void Delete(int id)
        {
            var delPerson = _context.Person.FirstOrDefault(p => p.Id == id);
            if (delPerson != null)
                _context.Person.Remove(delPerson);
            _context.SaveChanges;
        }
    }
}

