using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ass.Hangman
{

    class Program
    {

        static Random rand;
        static int Lives;
        static string GameWords;
        static int GamesWordsLength;
        static string Namn;
        static string CurrentWord;
        static string incorrectWords;

        static List<char> gessedChars = new List<char>();
        //static undesrScore;
        //private static object arrayofWord;


        static List<string> ListWord = new List<string>()
        {


            "lastbil",
            "blomma",

        };
        static void Main(string[] args)
        {

            rand = new Random();
            //string wordsToGeussUppercase = GameWords.ToUpper();
            PlayHangman();

        }
        static void PlayHangman()

        {
            Lives = 10;
            GameWords = ListWord[rand.Next(ListWord.Count() - 1)];
            GamesWordsLength = GameWords.Length;



            underScore();

        }
        static void underScore()
        {
            Console.WriteLine(" Enter");
            int underScoreLength = 0;
            string winning = "";
            Console.Write(" Skriv dit Namn:  ");
            Namn = Convert.ToString(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(Namn + ", Välkomen till Häng Gubbe, börja spela");
            Console.WriteLine("");
            Console.WriteLine("Antal Lives " + Lives + "\n");
            Console.WriteLine("Ange dit gissnings ord");
            //Console.WriteLine("Ange dit guess ord");
            //string GameWords = ListWord[rand.Next(0, ListWord.Length)];
            //string wordsToGeussUppercase = GameWords.ToUpper();
            string entered = Console.ReadLine();
            string underScore = string.Empty;

            for (int length = 0; length < entered.Length; length++)
            {

                underScore = underScore + "_";

            }
                 Console.WriteLine(underScore);
                 Console.ReadKey(true);
            char guess = char.ToUpper(Console.ReadKey().KeyChar);

            string GeussToUppercase = GameWords.ToUpper();
            Console.WriteLine("");
                
                //Console.ForegroundColor = ConsoleColor.Yellow;
                // Console.ReadLine();
                
            for (int i = 0; i < (GameWords.Length); i ++) 
            {

                GameWords.Replace(GameWords, (" _"));
                 Console.ReadLine();
                //CheckedGuess(GameWords,  ("_"));





                //int underScoreLength = 0;
                //string winning = " ";


                ////check(hemligt);
                ////hemligt = Convert.Char(Console.ReadLine());
                //for (int i = 0; i < (GameWords.Length); i++) ;
                //{


                //    if (GuessedChars.Any();
                //    {



                //    { 
                //    else
                //        Console.Write(" _ ");

                //}
                //else
                //{
                //    GameWords.Replace(GameWords, (" _"));
                //    Console.ReadLine();
                CheckGuess (guess);
            }  // End underScore

             static void CheckGuess(char guess)
            {



                Console.WriteLine("Ange dit guess ord");
                Console.ReadLine().ToUpper();
                bool guessOne = false;
                //GameWords = input[0];
                //string entered = Console.ReadLine();
                int underScoreLength = 0;

                while (!guessOne && Lives > 0)
                {
                    Console.WriteLine("Ange dit guess ord :");
                    Console.ReadLine().ToUpper();
                    //guess = input[0];

                    //int underScoreLength = 0;
                    //string winning = " ";

                    if (CurrentWord.Contains(guess))
                    {
                        Console.WriteLine(" Du har redan anget ´{0}´ och det är rätt !", guess);

                        continue;

                    }
                    else if (incorrectWords.Contains(guess))
                    {
                        Console.WriteLine(" Du har redan anget´{0}´, och det är fel", guess);
                        continue;

                    }

                    if (CurrentWord.Contains(guess))
                    {
                        Console.WriteLine(" Du har redan anget ´{0}´ och det är rätt !", guess);

                        continue;

                    }
                    else if (incorrectWords.Contains(guess))
                    {
                        Console.WriteLine(" Du har redan anget´{0}´, och det är fel", guess);
                        continue;

                    }
                    if (GameWords.Contains(guess))
                    {
                        Console.WriteLine(guess);
                        GameWords.Replace(GameWords, (" _"));
                        for (int i = 0; i < (GameWords.Length); i++)
                        {
                            if (GameWords[i] == guess)
                            {
                                //underScore[i] = (GameWords.Length[i];
                                underScoreLength++;

                            }


                        } }

                   //underScore();
                }// end while
                
            }//end checkguess





            //Console.WriteLine(underScore);









        }// END OF MAIN



                //foreach (string awords in word)
                ////{
                //    Console.WriteLine(word);
                //}

                //string[] FourLetterWords = new string[word.Count];

                //for (int i = 0; i < word.Count; i++)
                //{
                //    FourLetterWords[i] = word[i];

    } // END  OF CLASS

             //Random rand = new Random();
             //string fourword = FourLetterWords[rand.Next(1, word.Count + 1)];

             //string fourword = FourLetterWords[ran.Next(0,6);
             //var number = ran.Next(0, 6);
            //string randomword = arrayofWord[number];

            ////char[] guess = new char[ran.Length];
            //Console.WriteLine(" you have");


            ////char[] letter = fourword.ToCharArray();

            //string[] emty = new string[4];

                //for (int a = 0; a <emty.Length; a++)
                //{
                //    emty[a] = " _ ";
                //}

                   //    string letterChoice = Console.ReadLine().ToUpper();
                  //    char[] leter = letterChoice.ToCharArray();


} // NAME SPACE          
