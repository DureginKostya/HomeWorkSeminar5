/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
int getDimensionFromUser(string msg)
{
    Console.Write(msg);
    int lengthUser = int.Parse(Console.ReadLine()!);
    return lengthUser;
}
int[] getGenerationOfArray(int count, int start, int end)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}
void showResult(string msg, int[] array, int elements)
{
    Console.Write(msg);
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
             Console.Write($"{array[i]}] ");
        }
    }
    if (elements != 0)
    {
        Console.WriteLine($"- количество чётных чисел равно {elements}");
    }
    else
    {
        Console.WriteLine("- чётных чисел нет");
    }
}
int numberOfEvenElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
int length = getDimensionFromUser("Введите размерность массива: ");
int[] generatedArray = getGenerationOfArray(length, 100, 1000);
int evenElements = numberOfEvenElements(generatedArray);
showResult("В сгенерированном массиве [", generatedArray, evenElements);