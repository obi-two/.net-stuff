using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1 ,2 or3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a car!!";
            else if (userValue == "2")
                message = "You won a boat!";
            else if (userValue == "3")
                message = "You won a cat";
            else
            {
                message = "Sorry, we don't understand.";
                // message = message + " You Loose!";
                message += " You Loose!";
             }

            Console.WriteLine(message);

            Console.ReadLine();*/


            Console.WriteLine("Johns's Big Giveaway");
            Console.Write("Choose a door: 1 ,2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.ReadLine();

            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("ÿou entered : {0}, therefore you won a {1}.", userValue, message);

            Console.ReadLine();
        }
    }
}
