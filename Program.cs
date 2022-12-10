using System;
using System.Collections.Generic;

namespace SodaVending
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> drinks= new Stack<string>();
       
            
           
            
            Console.WriteLine("Do you want to: A- Add Item, B-Buy Item, E-End");
            char answer = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

            do
            {



                while (answer == 'A')
                {
                    Console.WriteLine("Which item would you like to add: ");
                    Console.WriteLine("Coke");
                    Console.WriteLine("Sprite");
                    Console.WriteLine("Dr.Pepper");
                    string answer2 = Console.ReadLine();
                    drinks.Push(answer2);
                    Console.WriteLine("Do you want to: A- Add Item, B-Buy Item, E-End");
                    answer = Convert.ToChar(Console.ReadLine().ToUpper());

                }

                if (answer == 'B')
                {

                    if (drinks.Count == 0)

                    {
                        Console.WriteLine("Sorry, there are no more drinks");
                        Console.WriteLine("Do you want to: A- Add Item or E-End");
                        answer = Convert.ToChar(Console.ReadLine().ToUpper());
                       
                    }


                    else if (drinks.Count >= 1)
                    {
                        Console.WriteLine("You purchased:" + drinks.Pop());
                        Console.WriteLine("Do you want to: A- Add Item, B-Buy Item, E-End");
                        answer = Convert.ToChar(Console.ReadLine().ToUpper());
                        

                    }
                }

                while (answer == 'E')
                {
                    Console.WriteLine("You've ended this vending. Thank you.");
                    break;
                  
                }

                while (answer != 'A' && answer != 'a' && answer != 'B' && answer != 'b' && answer != 'e' && answer != 'E')
                {
                    Console.WriteLine("Sorry, you have entered an invalid key, try again.");
                    Console.WriteLine("Do you want to: A- Add Item, B-Buy Item, E-End");
                    answer = Convert.ToChar(Console.ReadLine().ToUpper());
                        
                }
                
                
            } while (answer == 'A' || answer == 'B');

        }
    }
}