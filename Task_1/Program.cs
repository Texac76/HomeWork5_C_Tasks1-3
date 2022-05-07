// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = new int[8];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine(" ");
Console.Write("Количество четных чисел в массиве = ");
Console.WriteLine(result);
