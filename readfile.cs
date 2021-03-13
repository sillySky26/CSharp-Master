using System;
using System.IO;

namespace createfile 
{
    class Writefile
    {
        public static void Main(string[] args)
        {
            String path = "path";
            

            try
                {

                    using (StreamReader sr = new StreamReader(path, true))
                    {
                        string line;
                        // Read and display lines from the file until the end of
                        // the file is reached.
                        while ((line = sr.ReadLine()) != null)
                        {
                            int vowel = 0;
                            int consonant = 0;
                            int charCount = 0;
                            string letter = line.ToUpper(); //converts all string to uppercase

                            for (int i = 0; i < line.Length; i++)
                                {

                                    // Console.WriteLine(letter[i]); //debugging purposes
                                    string j = letter[i].ToString(); //converts char to string
                                    if (j == "A" || j == "E" || j == "I" || j == "O" || j == "U") //checks every letter if it is a vowel of not
                                        {
                                            vowel++;//increments vowel count
                                            charCount++; //increments Character Count
                                             
                                            //Console.WriteLine(j); //debugging purposes
                                        }
                                    else if(j == "B" ||j == "C" ||j == "D" ||j == "F" ||j == "G" ||j == "H" ||j == "J" ||j == "K" ||j == "L" ||j == "M" ||j == "N" ||j == "P" ||j == "Q" ||j == "R" ||j == "S" ||j == "T" ||j == "V" ||j == "W" ||j == "X" ||j == "Y" || j == "Z") //checks consonants through filters
                                        {
                                            consonant++; //increments consonant count
                                            charCount++; //increments Character Count
                                            //Console.WriteLine(j); //debugging purposes
                                        }
                                    else //ignores whitepaces , punctuations, and symbols
                                        {
                                            continue;
                                        }
                                }
                            
                            Console.WriteLine("TEXT: " + line); //prints text from file
                            Console.WriteLine("Number of Characters: " + charCount + ".");
                            Console.WriteLine("Number of Vowel Letters: " + vowel + ".");
                            Console.WriteLine("Number of Consonant Letters: " + consonant + ".");
                        }
                    }
                }
            catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }
        }
    }
}

