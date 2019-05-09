//Lara Corkery 08/05/2019
//Class Task One  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTasks
{
    class Program
    {
        static void Main()
        {
            Car c1 = new Car();
            c1.Make = "Holden";
            c1.Model = "Commodore";
            c1.Color = "Jungle Green";
            c1.Rego = "JAM254";
            Console.WriteLine("Car Make:{0} \n Model: {1} \n Colour: {2} \n Rego: {3} ", c1.Make, c1.Model, c1.Color, c1.Rego);
            Console.ReadLine();

            Car c2 = new Car();
            c2.Make = "Holden";
            c2.Model = "Commodore";
            c2.Color = "Phantom Black";
            c2.Rego = "KHR467";
            Console.WriteLine("Car Make: {0} \n Model: {1} \n Colour: {2} \n Rego: {3}", c2.Make, c2.Model, c2.Color, c2.Rego);
            Console.ReadLine();

            Car c3 = new Car();
            c3.Make = "Holden";
            c3.Model = "Commodore";
            c3.Color = "Redhot";
            c3.Rego = "DHN288";
            Console.WriteLine("Car Make: {0} \n Model: {1} \n Colour: {2} \n Rego: {3}", c3.Make, c3.Model, c3.Color, c3.Rego);
            Console.ReadLine();

            Car c4 = new Car();
            c4.Make = "Holden";
            c4.Model = "Commodore";
            c4.Color = "Heron White";
            c4.Rego = "KCU255";
            Console.WriteLine("Car Make: {0} \n Model: {1} \n Colour: {2} \n Rego: {3}", c4.Make, c4.Model, c4.Color, c4.Rego);
            Console.ReadLine();

            Car c5 = new Car();
            c5.Make = "Holden";
            c5.Model = "Commodore";
            c5.Color = "Nitrate Silver";
            c5.Rego = "EJJ764";
            Console.WriteLine("Car Make: {0} \n Model: {1} \n Colour: {2} \n Rego: {3}", c5.Make, c5.Model, c5.Color, c5.Rego);
            Console.ReadLine();
        }

        public class Car
        {
            private string make;
            private string model;
            private string color;
            private string rego;


            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public string Color { get { return color; } set { color = value; } }
            public string Rego { get { return rego; } set { rego = value; } }
        }
    }
}
