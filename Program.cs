void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}" + ", ");
    }
    Console.Write("]");
}

string[] CreateArray()
{
    Console.WriteLine("Введите количество слов: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите слово: ");
    string[] array = new string[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SortArray(string[] arr1)
{
    int count = 0;
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arr2 = new string[count];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[k] = arr1[i];
            k++;
        }
    }
    return arr2;
}