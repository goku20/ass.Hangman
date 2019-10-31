using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ass.Hangman
{   
       
    class Program
    {

        
        //private static object arrayofWord;

        static void Main(string[] args)

        {

            //bool keepAlive = true;
            //while (keepAlive)
            
             
            //string Namn;
            ////string Random;


            //Console.WriteLine("Välkomen till Häng Gubbe");

            //Console.Write(" Skriv dit Namn:  ");
            //Namn = Convert.ToString(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine(Namn + ", Välkomen till");g

            ////Console.WriteLine("   Häng Gubbe   ");
            //Console.WriteLine(" _______________");
            //Console.WriteLine(" |      |       ");
            //Console.WriteLine(" |     ( )      ");
            //Console.WriteLine(" |     /|\\      "); 
            //Console.WriteLine(" |      |       ");
            //Console.WriteLine(" |      |       ");
            //Console.WriteLine(" |     /|\\     ");
            //Console.WriteLine(" |_____________ ");
            //Console.WriteLine("   Häng Gubbe   ");

        }
         
        static void ListWords()
   
        { 
            List<string> word = new List<string>();

            word.Add("lastbil");
            word.Add(" båt");
            word.Add("stad");
            //words.Add("lexicon");
            //words.Add("namnmaskin");
            //words.Add(" hus");
            //words.Add("data");
            word.Add("mobil");
            word.Add("röd");
            word.Add("z");

            //foreach (string awords in word)
            //{
            //    Console.WriteLine(word);
            //}


            string[] FourLetterWords = new string[word.Count];

            for (int i = 0; i <  word.Count; i++)
            {
                FourLetterWords[i] = word[i];
            }
            
        
            
           

            Random ran = new Random();
            string fourword = FourLetterWords[ran.Next(1, word.Count + 1)];
           
            //string fourword = FourLetterWords[ran.Next(0,6);
            //var number = ran.Next(0, 6);
            //string randomword = arrayofWord[number];

            //char[] guess = new char[randomword.Length];
            //Console.WriteLine(" you have");


            char[] letter = fourword.ToCharArray();

            string[] emty = new string[4];

            for (int a = 0; a <emty.Length; a++)
            {
                emty[a] = " _ ";
            }

            static void Play()
            {
                Console.Clear();
                Console.WriteLine(" Välje dit ord och spela");
                Console.WriteLine("-----------------------");
                Console.WriteLine("");
                Console.WriteLine("          " + emty[0] + " " + emty[1] + " " + emty[2] + " " + emty[3] + " " + emty[4]);
                Console.WriteLine("");


                string letterChoice = Console.ReadLine().ToUpper();
                char[] leter = letterChoice.ToCharArray();

            }

         } // END OF MAIN

       //static void game()

       





        
        






    } // END  OF CLASS

}// NAME SPACE
