using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    

        

        List<int> numbers = new List<int>();

        int guestNumber = 1;
        while (guestNumber != 0)
        {
            
                Console.Write("Enter a list of numbers, type 0 when finished.");

                string guestResponse = Console.ReadLine();
                guestNumber = int.Parse(guestResponse);


                if (guestNumber != 0)
                {
                    numbers.Add(guestNumber);
                }
            



            
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");



        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The avergae is : {average}");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

       Console.WriteLine($"The max is: {max}");


    

    }
}