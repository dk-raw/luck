using System;
using System.Threading;

namespace omilos
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                while (true)

                {
                    Console.Clear();

                    Console.WriteLine("whats your name?");
                    string name = Console.ReadLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("test your luck "+ name + "! type in a number from 1 to 10");

                    string userinput = Console.ReadLine();
                    int user = Convert.ToInt32(userinput);





                    Random rdn = new Random();
                    int final_number = rdn.Next(1, 11); //orizo apo poion mexri poion arithmo thelo 
                    if (user == final_number)
                    {


                        Console.WriteLine($"i have bad news for you {name}.....");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"YOU WON!!!! The lucky number was {final_number}");

                    }

                    else
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"i'm afraid that you lost... {user} was not the number.");
                        Thread.Sleep(1000);
                        Console.WriteLine($"the lucky number actually was {final_number} ");
                        Console.WriteLine("better luck next time!");

                    }
                    Thread.Sleep(10000);

                }
            }
            
        }
    }
}
