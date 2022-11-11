/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
 с клавиатуры, либо задать на старте выполнения алгоритма.
*/


string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент №{i + 1}");
        arr[i] = Convert.ToString(Console.ReadLine());
    }
    return arr;
}

void SelectElements(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr1, string[] arr2)
{
    Console.Write($"[");
    for (int i = 0; i < arr1.Length; i++)
    {
        Console.Write($"{arr1[i]}, ");
    }
    Console.Write($"\b\b] -> [");
    for (int i = 0; i < arr2.Length; i++)
    {
        if (arr2[i] != null)
            Console.Write($"{arr2[i]}, ");
    }
    Console.Write($"\b\b]");
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[lenghtArray];
string[] array2 = new string[lenghtArray];
FillArray(array1);
SelectElements(array1, array2);
PrintArray(array1, array2);