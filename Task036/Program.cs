/*Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = new Random().Next(start, end + 1);
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
    Console.WriteLine($"- сумма элементов стоящих на нечётных позициях равна {elements}");
}
int getSumOfElements(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}
int length = getDimensionFromUser("Введите размерность массива: ");
int[] generatedArray = getGenerationOfArray(length, -50, 50);
int sumElements = getSumOfElements(generatedArray);
showResult("В сгенерированном массиве [", generatedArray, sumElements);
