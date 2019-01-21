using System;
using System.Collections.Generic;
using System.Text;

namespace Foo
{
    public class Foo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int HeightInches { get; set; }
        public int Weight { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            FirstName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How tall are you in inches?");
            HeightInches = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weigh in lbs?");
            Weight = Convert.ToInt32(Console.ReadLine());

        }
    }
}
