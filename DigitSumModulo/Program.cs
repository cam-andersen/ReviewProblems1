//Read an integer from the console and calculate the sum of its digits using the following algorithm

//We repeat the process until the number is not greater than 0 (by a while-loop)

var userInput = Console.ReadLine();
int.TryParse(userInput, out var number);
int sum = 0;

//Creates the while-loop if the condition is true
while (number > 0)
{
    //get the least significant digit of number using modulo
    int remainder = number % 10;
    //add the remainder to the sum
    sum = sum + remainder;
    //divide number by 10
    number /= 10;
}

Console.WriteLine(sum);
