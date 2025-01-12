using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade : ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        int a = 90; 
        int b = 80; 
        int c = 70;
        int d = 61;

        if (x > a)
        {
            Console.WriteLine("A");
        }

        if (x > b)
        {
            Console.WriteLine("B");
        }
        
        else if (x > c)
        {
            Console.WriteLine("C");
        }
        else if (x > d)
        {
            Console.WriteLine("D");
    
        }
        else
        {
            Console.WriteLine("F");
            Console.WriteLine("Please try harder next time");
        }
    
         
    }
}