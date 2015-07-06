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
            Console.WriteLine("Hello.  What is your first name");  //prompt user to enter first name
            string firstName = Console.ReadLine();  //capture first name
            Console.WriteLine("Hello " + firstName);  //return "hello " and users first name
        }

        //function to call to for first/last name printout

        static void displayName(bool libraryStyle, string lastName, string FirstName)
        {
            //if you want library style.  ie.  Doe, John.
            if (libraryStyle)
                Console.WriteLine(lastName + ", " + FirstName);
            //if you don't want library style. ie. John Doe.
            else
                Console.WriteLine(FirstName + " " + lastName);
        }
    }
}
