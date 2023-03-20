// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] array2)
{
    int quantity = array2.Length;
    int count = 0;
    while (count < quantity)
    {
        Console.Write($"{array2[count]}, ");
        count++;
    }
}

int FindEvenNumber(int[] array3)
{
    int length1 = array3.Length;
    int sum = 0;
    for (int number = 0; number < length1; number++)
    {
        if (array3[number] % 2 == 0)

            sum++;
    }
    return sum;
}

int[] array = new int[50];
FillArray(array);
PrintArray(array);
int pos = FindEvenNumber(array);
Console.WriteLine();
Console.Write($"Total of even numbers is {pos}");
