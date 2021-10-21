using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationMaker
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {get;set;}
        public Company Job { get; set; }
        public Person(string name,int age,Company job)
        {
            Name = name;
            Age = age;
            Job = job;
        }
        public Person() { }
    }

}
