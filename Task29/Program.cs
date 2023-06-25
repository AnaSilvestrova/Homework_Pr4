/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 1000); // Случайное число из диапазона 1-1000.
        index++;
    }
}

void PrintArray(int[] col) // Метод, который будет печатать массив.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        position++;
    } 
    Console.WriteLine($"[{string.Join(", ", col)}]");
}
    
int[] array = new int[8]; // Создан новый массив из 8 элементов.

FillArray(array); // Заполнение массива случайными числами.

PrintArray(array); // Печать массива в консоли.

