//Lara Corkery 09/05/2019
//Class Code Task Two 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.WriteLine("Please Enter The Person's First Name: ");
            p1.Fname = Console.ReadLine();
            Console.WriteLine("Please Enter The Person's Last Name: ");
            p1.Lname = Console.ReadLine();
            Console.WriteLine("Please Enter The Person's Age: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThank You, Here Is The Information You Entered.......");
            Console.WriteLine("Name: {0} {1}\nAge: {2}", p1.Fname, p1.Lname, p1.Age);
        }

        class Person
        {
            private string fname;
            private string lname;
            private string age;

            public string Fname { get { return fname; } set { fname = value; } }
            public string Lname { get { return lname; } set { lname = value; } }
            public string Age { get { return age; } set { age = value; } }


            public Person()
            {
                Console.WriteLine("............ New Person Object Created ............ \n");
            }

        }
    }
}
