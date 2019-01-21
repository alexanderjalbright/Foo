﻿using System;

namespace Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to personnel tracker.\n");
            bool quit = false;

            Foo person = new Foo();
            person.InitializeArrays();
            int numPersons = 0;
            do
            {
                string menuChoice = Menu();

                switch (menuChoice)
                {
                    case "1":
                        person.GetInfo(numPersons);
                        numPersons++;
                        break;
                    case "2":
                        Console.WriteLine("Who would you like to view?");
                        int selection = Convert.ToInt32(Console.ReadLine()) - 1;
                        person.DisplayInfo(selection);
                        break;
                    case "0":
                        Console.WriteLine("\nSee you next time!\n");
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nUnaccepted selection. Try again.\n");
                        break;
                }
            } while (quit == false);


        }

        static string Menu()
        {
            Console.WriteLine("\n1. Add Personnel Information");
            Console.WriteLine("2. View Information");
            Console.WriteLine("0. Quit");

            Console.WriteLine("\nType the number of the item you wish to perform and press ENTER.");




            string menu = Console.ReadLine();

            return menu;
        }

        
    }
}
