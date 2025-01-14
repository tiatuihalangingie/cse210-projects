using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);   
        int a = 90; 
        int b = 80;     
        int c = 70; 
        int d = 60; 
 
        if (x > a)
        {
            Console.WriteLine("A");
            Console.WriteLine("Well Done!");
        }
         if (x >= b && x < a)
        {
            Console.WriteLine("B");
            Console.WriteLine("Good Job!");
        }
        else if (x >= c && x < b)
        {
            Console.WriteLine("C");
            Console.WriteLine("You made it!");
        }
        else if (x >= d && x < c)
        {
            Console.WriteLine("D");
            Console.WriteLine("You almost make it!");
        }
        else if (x < d)
        {
            Console.WriteLine("F");
            Console.WriteLine("Please try harder next time!");
        }
         
    }
}