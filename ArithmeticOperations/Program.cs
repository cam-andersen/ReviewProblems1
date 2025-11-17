//Write a program that reads two integers from the console and then displays:
//sum
//product
//difference
//quotient
//remainder
//Assume that the user will always provide integer numbers

//We have to assign the Console.Readline() to something

using System;

class Program
{
    //We create a function
    static void Main(string[] args)
    {
        //Our datatype is string
        Console.WriteLine("Enter your integer 1");
        string userinput1 = Console.ReadLine();
        Console.WriteLine("Enter your integer 2");
        string userinput2 = Console.ReadLine();
        
        //We have to convert the string to integer
        int.TryParse(userinput1, out var number1);
        int.TryParse(userinput2, out var number2);
        
        //Asks the console to complete the mathematical calculations
        Console.WriteLine(number1 + number2);
        Console.WriteLine(number1 - number2);
        Console.WriteLine(number1 * number2);
        Console.WriteLine(number1 / number2);
        Console.WriteLine(number1 % number2);
    }
    
}