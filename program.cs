using System;


namespace Workflow
{
  class Program
  {

    static void alphaCount(string userInput)
    {
        int vowelCount = 0;
        int consCount = 0;
        string[] vowelArr = {"A", "E", "I", "O", "U"};
        string[] consonantsArr = {"B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R","S", "T", "V", "W", "X", "Z", "Y"};
        string userString = userInput
            .Replace(" ", "")
            .Replace(".","")
            .Replace("!","")
            .Replace("?","")
            .Replace(",","")
            .Replace("-","")
            .Replace("/","");
        

        char[] newString = userString.ToUpper().ToCharArray(); 

        foreach(char substr in newString)
        {
            //debug log: Console.WriteLine(substr);
            string newSub =  substr.ToString(); 

            foreach(string vowel in vowelArr){  //vowel loop
                if (newSub == vowel)
                {
                    vowelCount++;
                    // debug log: Console.WriteLine($"Match: {newSub}:{vowel}");
                }
            }


            foreach(string cons in consonantsArr) //consonants loop
            {
                if (newSub == cons) 
                {
                    consCount++;
                    //debug log: Console.WriteLine($"Match: {newSub}:{cons}");
                }
            }
        }

        Console.WriteLine($"Total number of vowels: {vowelCount}.");
        Console.WriteLine($"Total number of Consonants: {consCount}.");

        
    }

    static void count(string userInput)
    {
        
        int letterCount = 0;
        int wordCount = 0;

        //LETTER COUNT
        string newS = userInput
            .Replace(" ", "")
            .Replace(".","")
            .Replace("!","")
            .Replace("?","")
            .Replace(",","")
            .Replace("-","")
            .Replace("/","");

        char[] newString = newS.ToCharArray();
        foreach(char sub in newString)
        {
            // debug log Console.WriteLine(sub);
            letterCount++;
        }
        Console.WriteLine($"Total number of letters: {letterCount}.");

        //WORD COUNT
        char[] separators = new char[] { ' ', '.','?','!',','};
        string[] subs = userInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);


        foreach(string sub in subs)
        {
            wordCount++;
        }

        Console.WriteLine($"Total number of words: {wordCount}.");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Sentence");
        string userInput = Console.ReadLine();
        Console.WriteLine($"Sentence: {userInput}");

        alphaCount(userInput); //count vowels and consonants

        string Lowercased = userInput.ToLower();
        Console.WriteLine($"Sentence in Lowercase: {Lowercased}");

        string Uppercased =  userInput.ToUpper();
        Console.WriteLine($"Sentence in Uppercase: {Uppercased}");

        count(userInput); //letter and word count
    }
  }
}   