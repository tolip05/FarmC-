using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTree
{
   public class Person
    {
        private string name;
        private string birthDay;
        private List<Person> parents;
        private List<Person> children;
        public Person(string name,string birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }


        

        public List<Person> Children
        {
            get { return children; }
            set { children = value; }
        }

        public List<Person> Parents
        {
            get { return parents; }
            set { parents = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public string BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }

    }
}
