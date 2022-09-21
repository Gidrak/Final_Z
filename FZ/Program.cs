Console.Clear();

string[] str = CreatArray("Введите количесвто элементов массива: ");
Console.Write("Заданный массив с длиной элементов <= 3: ");

string[] CreatArray(string massage)
{
    Console.Write(massage);
    int Length = int.Parse(Console.ReadLine());
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + ", " );
    }
    Console.Write("]");
}

string[] CreatNewArrayLessThreeElements(string[] str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            count++; // чтобы сократить размерность массива считаем количество элементов
        }
    }

    string[] newStr = new string[count];
    int j=0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            newStr[j] = str[i];
            j++;
        }
    }

    return newStr;
}

PrintArray(str);
Console.Write(" -> ");
string[] newStr = CreatNewArrayLessThreeElements(str);
PrintArray(newStr);