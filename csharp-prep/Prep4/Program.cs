using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // variables
        List<int> numberList = new List<int>();
        int inputNum = -1; 


        // Start of the program
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        while (inputNum != 0)
        {
            Console.Write("Enter the number: ");
            inputNum = int.Parse(Console.ReadLine());
            if (inputNum != 0)
            {
                numberList.Add(inputNum);   
            }
        }

        // output the sum, the average and the largest number
        Console.WriteLine("The sum is: " + numberList.Sum());
        Console.WriteLine("The average is: " + numberList.Average());
        Console.WriteLine("The largest number is: " + numberList.Max());
        // find the lowest positive number
        int lowPositiveNum = numberList.Max();
        numberList.ForEach( num =>
        {
            if (num > 0 && num < lowPositiveNum)
            {
             lowPositiveNum = num;   
            }
        }); 
        Console.WriteLine("The lowest positive number is: " + lowPositiveNum);
        Console.WriteLine("The sorted list is: ");
        // sort the list
        numberList.Sort();
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }

    }
}