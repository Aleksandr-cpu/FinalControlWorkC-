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