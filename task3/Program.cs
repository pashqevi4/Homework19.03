// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(int[] array1)
{
    int length1 = array1.Length;
    int index1 = 0;
    while (index1 < length1)
    {
        array1[index1] = new Random().Next(-99, 100);
        index1++;
    }
}

void PrintArray(int[] array2)
{
    int length2 = array2.Length;
    int index2 = 0;
    while (index2 < length2)
    {
        Console.Write($"{array2[index2]}, ");
        index2++;
    }
}

int FindMax(int[] array3)
{
    int length3 = array3.Length;
    int index3 = 0;
    int max = array3[index3];
    while (index3 < length3)
    {
        if (array3[index3] > max)
        {
            max = array3[index3];
        }
        index3++;
    }
    return max;
}

int FindMin(int[] array4)
{
    int length4 = array4.Length;
    int index4 = 0;
    int min = array4[index4];
    while (index4 < length4)
    {
        if (array4[index4] < min)
        {
            min = array4[index4];
        }
        index4++;
    }
    return min;


}

int[] array = new int[100];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int result1 = FindMax(array);
Console.WriteLine($"max element is {result1}");
int result2 = FindMin(array);
Console.WriteLine($"min element is {result2}");
int total = result1 - result2;
Console.WriteLine();
Console.WriteLine($"The difference between min and max is {total}");
