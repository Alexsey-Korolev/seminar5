//Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

//Не моё решение

Console.WriteLine("Введите длинну массива:");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arrayLength];

for (int i = 0; i < userArray.Length; i++)
{
    userArray[i] = new Random().Next(1,11);
}

void getPrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
void getProductOfNumbers(int[] array)
{
    int length = array.Length;
    if (length % 2 == 0)
    {
        length = length / 2;
    }
    else
    {
        length = length / 2 + 1;
    }
    int count = array.Length -1;
    int[] newArray = new int [length];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == count -i)
        {
            newArray[i] = array[i];
            break;
        }
        newArray[i] = array[i] * array[count - i];
    }
     getPrintArray(newArray);
}

getPrintArray(userArray);
getProductOfNumbers(userArray);













