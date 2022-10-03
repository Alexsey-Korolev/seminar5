//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Введите длинну массива:");
int length = Convert.ToInt32(Console.ReadLine());

double[] getRandomArray(int length)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return resultArray;
}
void printArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine("]");
}
double[] currentArray = getRandomArray(length);
printArray (currentArray);

double max = currentArray[0];
double min = currentArray[0];
for (int i = 0; i < length; i++)
{
    if (currentArray[i] > max)
    {
        max = currentArray[i];
    }
    if (currentArray[i] < min)
    {
        min = currentArray[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = { max - min}");

