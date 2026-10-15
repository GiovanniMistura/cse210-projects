using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction f1 = new Fraction();
        Random rnd = new Random();

        for (int i=0; i<20; i++)
        {
            int top = rnd.Next(1,10);
            int bottom = rnd.Next(1,10);
            f1.setTop(top);
            f1.setBottom(bottom);
            int fractionNumber = i+1;
            Console.WriteLine("Franction " + fractionNumber + ": string: " + f1.GetFractionString() + " Number: " + f1.GetDecimalValue());
        }

        
    }
}