using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
   public class StartUp
    {
        static List<Person> persons;
        static List<string> releitionShips;
      public  static void Main(string[] args)
        {
            persons = new List<Person>();
            releitionShips = new List<string>();
            string namePerson = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (!input.Contains("-"))
                {
                    AddMember(input);
                    input = Console.ReadLine();
                    continue;
                }
                releitionShips.Add(input);

                input = Console.ReadLine();
            }
            foreach (var item in releitionShips)
            {
                string[] inputArgs = item.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                Person parent = GetPerson(inputArgs[0]);
                Person chaeld = GetPerson(inputArgs[1]);
                if (!parent.Children.Contains(chaeld))
                {
                    parent.Children.Add(chaeld);
                }
                if (!chaeld.Parents.Contains(parent))
                {
                    chaeld.Parents.Add(parent);
      
                }
            }
            Print(namePerson);
        }

        private static void Print(string namePerson)
        {
            Person mainPerson = GetPerson(namePerson);

            Console.WriteLine($"{mainPerson.Name} {mainPerson.BirthDay}");
            Console.WriteLine("Parents:");
            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.BirthDay}");
            }
            Console.WriteLine("Children:");
            foreach (var chield in mainPerson.Children)
            {
                Console.WriteLine($"{chield.Name} {chield.BirthDay}");
            }
        }

        private static Person GetPerson(string input)
        {
            if (input.Contains('/'))
            {
                return persons.FirstOrDefault(x => x.BirthDay == input);
            }
            return persons.FirstOrDefault(x => x.Name == input);
        }

        private static void AddMember(string input)
        {
            string[] inputArgs = input.Split();
            string name = inputArgs[0] +" "+ inputArgs[1];
            string birthDay = inputArgs[2];

            Person person = new Person(name,birthDay);
            persons.Add(person);
        }
    }
}
