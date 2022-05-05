// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


Console.Clear();
int result = 0;
int[] array = { 2, 4, 6, 4, 7, 8 };
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}
result = max - min;
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
Console.WriteLine("max-min = " + result);