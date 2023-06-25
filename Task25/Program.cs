/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();

int Prompt(string message) // Метод для запроса двух строчек у пользователя и преобразования их в int (целочисленное значение).
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}


bool ValidateExponent (int exponent) // Метод для проверки того, является ли степень натуральным числом.
{
    if (exponent <= 0)
    {
        Console.WriteLine($"Your power {exponent} is not a natural number. Input a power > 0.");
        return false;
    }
    return true;
}

int GetPower(int number, int exponent) //Метод для получения числа, возведенного в степень.
{
    int power = 1; // Временная переменная, кот. будет изменяться внутри цикла.
    for (int i = 0; i < exponent; i++) // Выполняется, пока количество умножений меньше числа степени.
    {
        power *= number; // Результат равен временному результату, умноженному на номер. 
    }
    return power;
}

int number = Prompt("Input number you want to exponent: "); // Запрос числа.
Console.WriteLine();

int exponent = Prompt("Input power you to which you want to raise your number: "); // Запрос степени.
Console.WriteLine();

if (ValidateExponent(exponent))
{
    Console.WriteLine($"Number {number} raised to power {exponent} is {GetPower(number, exponent)}."); // Вывод результата в случае соблюдения условия "степень больше 0".
}
