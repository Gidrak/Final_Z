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