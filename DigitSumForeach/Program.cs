//Read an integer from the console and calculate the sum of its digits.
//Steps:
//Loop over the characters of the input string
//Convert each character to a string and try to parse each character-string as an integer.
//Create a sum of all these integers.

namespace DigitSumForeach;

class Program
{
    static void Main(string[] args)
    {
        //Asks the user for a number
        var userInput = Console.ReadLine();
        
        //Creates the sum of the integers
        int sum = 0;
        
        //Creates the Loop about how the strings behave. This loop ensures that each number will be added to the sum
        foreach (var c in userInput)
        {
            //Creates the conversion as the computer has numbers a linked to each number. 
            //This is to ensure that all of the characters are perceived as a string by the computer
            //Creates the summation of the characters in the user input
            sum = sum + Convert.ToInt32(c.ToString());
            //Can also be written as sum += sum Convert.ToInt32(c.ToString()))
        }
        Console.WriteLine(sum);
    }
}