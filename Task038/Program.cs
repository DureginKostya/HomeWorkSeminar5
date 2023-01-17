/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
int getDimensionFromUser(string msg)
{
    Console.Write(msg);
    int lengthUser = int.Parse(Console.ReadLine()!);
    return lengthUser;
}
double[] getGenerationOfArray(int count, int start, int end)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(start, end) + new Random().NextDouble();
    }
    return array;
}
void showResult(string msg, double[] array, double maximum, double minimum, double decision)
{
    Console.Write(msg);
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{Math.Round(array[i], 2)} ");
        }
        else
        {
             Console.WriteLine($"{Math.Round(array[i], 2)}] ");
        }
    }   
    Console.WriteLine($"Максимальный элемент равен: {Math.Round(maximum, 2)}");
    Console.WriteLine($"Минимальный элемент равен: {Math.Round(minimum, 2)}");
    Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна: {Math.Round(decision, 2)}");
}
double getMaximumOrMinimumElement(double[] array, int key)
{
    double variable = array[0];   
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] * key > variable * key)
        {
            variable = array[i];
        }
    }
    return variable;
}
double subtractMinimumFromMaximum(double maxNumber, double minNumber)
{
    double result = maxNumber - minNumber;
    return result;
}
int length = getDimensionFromUser("Введите размерность массива: ");
double[] generatedArray = getGenerationOfArray(length, -50, 50);
double maxElements = getMaximumOrMinimumElement(generatedArray, 1);
double minElements = getMaximumOrMinimumElement(generatedArray, -1);
double subtract = subtractMinimumFromMaximum(maxElements, minElements);
showResult("Сгенерированный массив: [", generatedArray, maxElements, minElements, subtract);