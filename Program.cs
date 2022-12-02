using System;

namespace Würfelspiel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameEnded = false;
            Random rnd = new Random();
            int tryes = 3;

            string title = @"
                     .-------.    ______
		    /   o   /|   /\     \				
		   /_______/o|  /o \  o  \
		   | o     | | /   o\_____\
		   |   o   |o/ \o   /o    /
		   |     o |/   \ o/  o  /
		   '-------'     \/____o/
 __      __          _____      .__                 .__       .__   
/  \    /  \________/ ____\____ |  |   ____________ |__| ____ |  |  
\   \/\/   /\_  __ \   __\/ __ \|  |  /  ___/\____ \|  |/ __ \|  |  
 \        /  |  | \/|  | \  ___/|  |__\___ \ |  |_> >  \  ___/|  |__
  \__/\  /   |__|   |__|  \___  >____/____  >|   __/|__|\___  >____/
       \/                     \/          \/ |__|           \/       
       
       ";


            Console.WriteLine(title);
            Console.WriteLine();
            int randNumbr = rnd.Next(1, 6);
            
            while(!gameEnded)
            {
                if(tryes > 0)
                {
                    Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 6 ein: ");
                    int userNumber = Convert.ToInt32(Console.ReadLine());
                    if(userNumber == randNumbr)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("===========");
                        Console.WriteLine("Sie haben gewonnen!");
                        gameEnded = true;
                    }
                    else
                    {
                        Console.WriteLine("Sie heben Falsch geraten!");
                        Console.WriteLine("");
                        tryes--;
                        switch(tryes)
                        {
                            case 2:
                                Console.WriteLine("===========");
                                Console.WriteLine("Sie haben noch 2 Versuche!");
                                break;
                            case 1:
                                Console.WriteLine("===========");
                                Console.WriteLine("Sie haben noch 1 Versuch!");
                                break;
                            case 0:
                                break;
                            default:
                                Console.WriteLine("That was not intended!");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sie haben leider verloren!");
                    Console.WriteLine("Die richtige Zahl war: " + randNumbr);
                    gameEnded = true;
                }
            }            
        }
    }
}