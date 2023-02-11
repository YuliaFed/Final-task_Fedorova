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
        Console.WriteLine($"Элемент {i} = {arr[i]} ");
    }
}

int NumberOfElementsIf(string[] array)
{
    int m = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string a = array[i];
        if (a.Length <= 3)
        {
            m = m + 1;
        }
    }
    return m;
}

Console.Write("Введите длину массива, который вы хотите задать: ");
int num = int.Parse(Console.ReadLine()!);
string[] array = GetArray(num);
PrintArray(array);
Console.WriteLine();

//var NewArray = array.Where(s => s.Length <= 3).ToArray(); 
//PrintArray(NewArray);

int m = NumberOfElementsIf(array);
string[] Newarray = new string[m];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    string a = array[i];
    if (a.Length <= 3)
    {
        Newarray[j] = a;
        j = j + 1;
    }
}

PrintArray(Newarray);
