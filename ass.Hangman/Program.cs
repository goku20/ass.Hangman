using System;
using System.Collections.Generic;

namespace ass.Hangman
{
    class Program
    {
        static void Main(string[] args)

            

        {
            string Namn;

            Console.WriteLine("Välkomen till Häng Gubbe");

            Console.Write(" Skriv dit Namn:  ");
            Namn = Convert.ToString(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(Namn + ", Välkomen till");

            //Console.WriteLine("   Häng Gubbe   ");
            Console.WriteLine(" _______________");
            Console.WriteLine(" |      |       ");
            Console.WriteLine(" |     ( )      ");
            Console.WriteLine(" |     /|\\      "); 
            Console.WriteLine(" |      |       ");
            Console.WriteLine(" |      |       ");
            Console.WriteLine(" |     /|\\     ");
            Console.WriteLine(" |_____________ ");
            Console.WriteLine("   Häng Gubbe   ");

        }
         
        static void ListWords()
   
        { 
            List<string> words = new List<string>();
            words.Add("lastbil");
            words.Add(" båt");
            words.Add("stad");
            words.Add("lexicon");
            words.Add("namnmaskin");
            words.Add(" hus");
            words.Add("data");
            words.Add("mobil");
            words.Add("röd");
            words.Add("z");

            foreach (string awords in words)
            {
                Console.WriteLine(words);
            }
        }   


    }
}
