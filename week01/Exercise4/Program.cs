using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
    
        List<int> numbers = new List<int>();
        
        
        while (number == 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
            }    
        }
        
        int sum = numbers.Sum();
        double average = numbers.Average();
        int maxNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.ReadKey();
    
    }
}