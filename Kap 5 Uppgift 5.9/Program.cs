using System;
using System.Xml.Linq;

namespace Uppgift5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Färger
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //-------------------------------------------

            string[] names = new string[1000];
            int stopIndex = 0;
            string name = "";

            //Input-loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Skriv in ett namn. Skriv \"n\" för att avsluta. (Du får skriva in {names.Length - i} namn till.)");
                name = Console.ReadLine();

                if (i == names.Length - 1) //Sista gången
                {
                    Console.WriteLine("Du får inte skriva in fler namn!");
                    names[i] = name;
                    stopIndex = names.Length;
                    break;
                }
                else if (name.ToLower() == "n") //Avsluta
                {
                    stopIndex = i;
                    break;
                }
                else
                {
                    names[i] = name; //namnet sparas
                }
            }

            //Leta efter ett namn
            Console.WriteLine("Vilket namn vill du leta efter?");
            string nameLookingFor = Console.ReadLine().ToLower();
            int nameOccurs = 0; //Hur många gånger finns namnet?

            for (int i = 0; i < stopIndex; i++)
            {
                if (names[i].ToLower() == nameLookingFor)
                {
                    nameOccurs++;
                }
            }

            Console.WriteLine($"Gånger \"{nameLookingFor}\" förekommer: {nameOccurs}.");
        }
    }
}
/*Skapa ett program där användaren får mata in så många namn som hen vill upp till
ett maximalt antal av 1000. Användaren ska inte behöva bestämma hur många namn
hen vill mata in i förväg, fråga i stället efter varje inmatat namn om hen vill mata in ett
till namn.
Efter att användaren har matat in alla namn så ska hen få skriva in valfritt namn,
programmet ska berätta hur många gånger detta namn förekommer i listan av de
tidigare inmatade namnen.*/