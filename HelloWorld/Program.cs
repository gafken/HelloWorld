using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String response1;       //variable to retrieve string sent from console response
            int parsedResp = 0;     //stores the value returned after parsing the above srting
            Console.WriteLine("What is your first name?");
            String firstName = Console.ReadLine();      //Retrieve first name from user
            Console.WriteLine();
            Console.WriteLine("What is your last name?");
            String lastName = Console.ReadLine();       //Retrieve last name from user
            Console.WriteLine();
            do{
                Console.WriteLine("\nHow would you like me to address you?");
                Console.WriteLine("1:  John Doe");
                Console.WriteLine("2:  Doe, John");             //User chooses the format in which they wish to be addressed.
                Console.WriteLine();
                Console.WriteLine("Please enter 1 or 2.");
                Console.WriteLine();

                response1 = Console.ReadLine();                 //Retrieve reponse
                Int32.TryParse(response1, out parsedResp);      //Parse response and save
                if (parsedResp != 1 && parsedResp != 2)         //Test if parsed response is acceptable to continue
                {
                    Console.WriteLine();                        //if parsed response fails, this is purely for asthetics
                    Console.WriteLine("Invalid input, please try again");
                    Console.WriteLine();
                }
             }while (parsedResp != 1 && parsedResp != 2);
            Console.Write("Hello ");                            //<--¬
            displayName(parsedResp, lastName, firstName);       //Display Name in proper format
        }

        //function to call to for first/last name printout

        static void displayName(int libraryStyle, String lName, String fName)
        {
            //if you want library style.  ie.  Doe, John.
            if (libraryStyle == 2)
                Console.WriteLine(lName + ", " + fName);
            //if you don't want library style. ie. John Doe.
            else
                Console.WriteLine(fName + " " + lName);
        }
    }
}
