using System;
using System.Collections.Generic;

namespace Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to personnel tracker.\n");
            bool quit = false;

            var person = new List<Bar>();
            int numPersons = 0;
            do
            {
                string menuChoice = Menu();

                switch (menuChoice)
                {
                    case "1":

                        person.Add(CreateBar());
                        numPersons++;
                        break;

                    case "2":
                        DisplayNameList(person);
                        Console.WriteLine("Who would you like to view? Type 0 for all.");
                        int userSelection = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        int index = userSelection - 1;
                        if(userSelection == 0)
                            DisplayAllPpl(person);
                        else
                            person[index].DisplayInfo();
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

        static Bar CreateBar()
        {
            var person = new Bar();
            person.GetInfo();

            return person;

        }

        static void DisplayAllPpl(List<Bar> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                person[i].DisplayInfo();
            }
        }

        static void DisplayNameList(List<Bar> person)
        {
            for (int i = 0; i < person.Count; i++)
            {
                int userNum = i + 1;
                Console.WriteLine(userNum + ". " + person[i].FirstName + " " + person[i].LastName);
            }
        }



    }
}
