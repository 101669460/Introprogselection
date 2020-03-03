using System;

namespace Introprogselection
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey There! Let's play a little guessing game.");
            Random rnd = new Random();
            int a = rnd.Next(0, 25);
            Console.WriteLine("Guess the number between 0 and 25");
            int test = 0;
            Console.WriteLine("Enter Guess:");
            do{
                int g1 = Convert.ToInt32(Console.ReadLine());
                if (g1==a) 
                {
                    break;
                }
                else 
                {
                    if(g1>a) 
                    {
                        Console.WriteLine("Nope, it's less than that");
                    }
                    else
                    {
                        Console.WriteLine("Nope, it's greater than that");
                    }
                    Console.WriteLine("You have " + (4 - test) + " guesses left!");
                } 
                test++;
            } 
            while(test<5);
                
                if (test<5) 
                {
                    Console.WriteLine("Damn. You Win!");
                    Console.WriteLine("It took you this many guesses:");
                    System.Console.WriteLine(test);
                }
                else
                {
                     Console.WriteLine("You have 0 guesses left!");
                    Console.WriteLine("Nope, the answer was: " + a);
                }
            
        }
    }
}
