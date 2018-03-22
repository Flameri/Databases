using System;
using PersonDb.Model;
using PersonDb.Repositories;

namespace PersonDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database CRUD operations");
            //Person person1 = new Person("Linda", 24);
            //PersonRepository.Create(person1);
            var persons = PersonRepository.Read();

            foreach (var p in persons)
            {
                Console.WriteLine(p.ToString());
            }
            

            Console.WriteLine("Press <Any Key> to Exit");
            Console.ReadLine();
        }
    }
}
