/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine()); // Get the number.
    return number;
}

int GetSumofDig(int number) // Find sum of digits of the number.
{
    int digit = 0;
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10; // Summering digits after getting the previous digit?
        number /=10; // Changing digits.
    }
    return sum;
}

int number = GetNumber();
int result = GetSumofDig(number);

Console.WriteLine($"Sum of digits of {number} is {result}.");