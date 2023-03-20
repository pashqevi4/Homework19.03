//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array1)
{
    int length = array1.Length;
    int index = 0;
    while (index < length)
    {
        array1[index] = new Random().Next(-99, 100);
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

int FindOddPosition(int[] array3)
{
    int length1 = array3.Length;
    int sum = 0;
    for (int number = 0; number < length1; number++)
    {
        if (number % 2 == 0)
        {
            sum = sum + array3[number];
        }
    }
    return sum;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
int result = FindOddPosition(array);
Console.WriteLine();
Console.WriteLine($"Sum of elements with odd indexes is {result}");

