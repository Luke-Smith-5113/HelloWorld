using System;

namespace HelloaWorld_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your first name"); //Asks for first name
            String firstName = Console.ReadLine(); //Reads the name
            Console.WriteLine($"{firstName} now tell me your last name"); //Asks for the last name
            String lastName = Console.ReadLine(); //Reads the name

            //Says some stuff
            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"The World is waiting for you {firstName}");
            Console.WriteLine("Where would you like to go?");

            String placeName = Console.ReadLine(); //Asks for a place you'd like to go
            Console.WriteLine($"Get out there and explore the {placeName} {firstName}"); //Says to go there
        }
    }
}
