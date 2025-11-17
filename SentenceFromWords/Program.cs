//Write a program that puts input words together into a sentence and prints the sentence.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words of a sentence one by one including punctuation:");
        
        //Creates the string variables for collecting the words and the sentence
        string word = "";
        string sentence = "";

        //Adds boolean expression to keep the loop going until it ends with a certain character '.'
        while (!word.EndsWith("."))
        {
            word = Console.ReadLine();

            //Adds the input words to the sentence with a space. The space is indicated by " "
            //The process is that a user types a word that is registered in the word variable. This variable is also
            //stored in the sentence  as each new word is added to this variable everytime we are doing the loop.
            //The sentence now takes the previous sentence, adds the word and a space until the user ends a word with .
            sentence = sentence + word + " ";
        }

        Console.WriteLine(sentence.Trim());
    }
}
