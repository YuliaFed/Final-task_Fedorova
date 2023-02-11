string[] GetArray(int size)
{
    string[] result = new string[size];
    Console.Write($"Создаем массив из {size} строк");
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку массива: ");
        result[i] = Console.ReadLine()!;
    }
    return result;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.Write("Введите длину массива, который вы хотите задать: ");
int num = int.Parse(Console.ReadLine()!);
string[] array = GetArray(num);
PrintArray(array);
Console.WriteLine();
