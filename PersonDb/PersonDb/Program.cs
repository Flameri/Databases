using System;
using PersonDb.Model;
using PersonDb.Repositories;
using System.Linq;
using System.Collections.Generic;
using PersonDb.NewFolder;

namespace PersonDb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database CRUD operations");
            UIForConsoleApp();

            //PersonRepository personRepository = new PersonRepository();

            //Person person1 = new Person("Hannu Hanhi", 30);
            //personRepository.Create(person1);
            //var persons = personRepository.Read();

            //foreach (var p in persons)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            //Person person = new Person
            //{
            //    Name = "Teppo Tulppu",
            //    Age = 33,
            //    Phone = new List<Phone>
            //    {
            //    new Phone {Number = "050316548", Type = "HOME"},
            //    new Phone { Number = "04568787", Type = "WORK" }
            //    }
            //};
            //personRepository.Create(person);
        }


        public static void UIForConsoleApp()
        {
            ConsoleKeyInfo info;
            PersonRepository personRepository = new PersonRepository();
            do
            {
                Console.Clear();
                Console.WriteLine("Database coding - CRUD");
                Console.WriteLine("Press <ESC> to Exit");
                Console.WriteLine("C) Create");
                Console.WriteLine("R) Read All");
                Console.WriteLine("U) Update");
                Console.WriteLine("D) Delete");
                Console.WriteLine("-------------");
                Console.WriteLine("G) Get by ID");

                info = Console.ReadKey();

                switch (info.Key)
                {
                    case ConsoleKey.C:
                        ViewPerson.AddPerson();
                        //var person = new Person("Masa", 25);
                        //personRepository.Create(person);
                        break;
                    case ConsoleKey.R:
                        ViewPerson.PrintToScreen(personRepository.Read());
                        Console.WriteLine("Press <Enter> to continue ...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.U:
                        Person updatePerson = personRepository.GetPersonById(10);
                        updatePerson.Name = "James Bond";
                        updatePerson.Age = 55;
                        personRepository.Update(updatePerson, 1);
                        break;
                    case ConsoleKey.D:
                        personRepository.Delete(5);
                        break;
                    case ConsoleKey.G:
                        Console.Write("\nSyötä henkilön <id>, jonka tiedot näytetään: ");
                        int id = int.Parse(Console.ReadLine());
                        ViewPerson.PrintToScreen(personRepository.GetPersonByIdAndPhones(id));
                        Console.WriteLine("Press <Enter> to continue ...");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("\nProgram end after 3 sec!");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;
                    default:
                        Console.WriteLine("\nWrong KEY - try again!");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }

            } while (info.Key != ConsoleKey.Escape);
        }
    }
}
            
                  
    
       
    
        

   

