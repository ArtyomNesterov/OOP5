using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Tobi", "Mou");
            Employee emp = new Employee("Paul", "Robbers", "Yandex");

            p.Display();

            emp.Display();
            Console.ReadKey();
        }
    }
    class Employee : Person
    {
        private string company;

        public Employee(string name, string surname, string comp)
            : base(name, surname)
        {
            company = comp;
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public void DisplayB()
        {
            Console.WriteLine(Name + " | " + Surname + " | " + Company);
        }
    }
    class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public void Display()
        {
            Console.WriteLine(Name + " " + Surname);
        }
        public Person(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }
}