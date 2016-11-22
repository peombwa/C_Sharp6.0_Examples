using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ListDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        private void Work()
        {
            List<Person> people = new List<Person>();

            Person john = new Person() { Name="John" };
            people.Add(john);
            people.Add(new Person() { Name = "Paul" });
            people.Add(new Person() { Name = "Peter" });
            people.Add(new Person() { Name = "George" });
            people.Add(new Person() { Name = "Merry" });
            people.Add(new Person() { Name = "Rodulf" });
            people.Add(new Person() { Name = "Pippin" });

            foreach (Person person in people)
            {
                Console.WriteLine($"Name = {person.Name}");
            }
        }
    }
}
