using System;
using System.Collections.Generic;
using System.Text;

namespace Foo
{
    public class Foo
    {
        public string[] FirstName = new string[10];
        public string[] LastName = new string[10];
        public int[] Age = new int[10];
        public int[] HeightInches = new int[10];
        public int[] Weight = new int[10];

        public void InitializeArrays()
        {
            for (int i = 0; i < 10; i++)
            {
                FirstName[i] = " ";
                LastName[i] = " ";
                Age[i] = 0;
                HeightInches[i] = 0;
                Weight[i] = 0;
            }
        }
        
        

        public void GetInfo(int index)
        {
            Console.WriteLine("\nWhat is your first name?");
            FirstName[index] = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            LastName[index] = Console.ReadLine();

            Console.WriteLine("How old are you?");
            Age[index] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How tall are you in inches?");
            HeightInches[index] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weigh in lbs?");
            Weight[index] = Convert.ToInt32(Console.ReadLine());
            

        }

        public void DisplayInfo(int index)
        {
            Console.WriteLine("\nFirst Name: " + FirstName[index]);
            Console.WriteLine("Last Name: " + LastName[index]);
            Console.WriteLine("Age: " + Age[index]);
            Console.WriteLine("Height: " + HeightInches[index] + " in.");
            Console.WriteLine("Weight: " + Weight[index] + " lbs");

        }
    }
}
