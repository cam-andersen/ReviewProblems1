//Write a console program that determines whether a given number is multiples of the second given number.
//Use the modulo operator.

namespace MultiplesOfNumbers;

class Program
{
    //We create a function
    static void Main(string[] args)
    {
        //Our datatype is string
        Console.WriteLine("Enter dividend");
        string userinput1 = Console.ReadLine();
        Console.WriteLine("Enter your dividor");
        string userinput2 = Console.ReadLine();
        
        //We have to convert the string to integer
        int.TryParse(userinput1, out var number1);
        int.TryParse(userinput2, out var number2);
        
        //Creates the model
        if (number1 % number2 == 0)
            Console.WriteLine("Multiples possible");
        else if (number1 % number2 != 0)
            Console.WriteLine("Multiples not possible");
    }
}