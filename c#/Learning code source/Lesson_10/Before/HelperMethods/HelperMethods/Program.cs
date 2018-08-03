﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born?");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.ReadLine();

        }


        private static string ReverseString(string message)
        {
            //string message = "Hello world!";

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string revercedFirstName, string revercedLastName, string revercedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
            revercedFirstName,
            revercedLastName,
            revercedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }


    }
}
