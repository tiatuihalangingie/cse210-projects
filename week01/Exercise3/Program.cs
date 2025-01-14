using System. Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");  
        
       
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string response = "number";

        while (response == "number")
        {
            Console.Write("What is your guess? ");
            string valueFromuser = Console.ReadLine();
            int quess = int.Parse(valueFromuser);
    
            if (quess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (quess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                response = Console.ReadLine();

            }
            
        }
    }
}