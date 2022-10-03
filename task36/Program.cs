//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длинну массива:");
int length = Convert.ToInt32(Console.ReadLine());

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("Ваш массив[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
int[] currentArray = getRandomArray(length,-99,100);
printArray(currentArray);

int sumOddIndexArray(int[] incomingArray)
{
    int sum_odd = 0;
    for (int i = 1; i < length; i += 2)
    {
        sum_odd = sum_odd + incomingArray[i] ;
    }
    return sum_odd;
}
int sum_odd = sumOddIndexArray(currentArray);
Console.WriteLine($"Сумма элементов на нечётных позициях = {sum_odd}");