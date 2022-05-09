// Из имеющегося массива строк сформировать массив строк, длинна которых
// меньше, или равна 3м символам.

string[] NewArray(string[] array)  // Ищем строки меньше 3х символов и записываем в массив.
{
    int size = array.Length;
    string[] newarray = new string[size];
    int i = 0;
    while(i < size)
    {
        if (array[i].Length <= 3) newarray[i] = array[i];
        i = i + 1;
    }
    return newarray;
}

void PrintString(string[] arr)  // Выводим массив.
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == null) continue;
        Console.Write($"\"{arr[i]}\" ");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] FillArray()  // Заполняем массив
{
    System.Console.WriteLine("Введите количество элементов массива: ");
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    while(Value < 0)                        //для хулиганов.
    {
        System.Console.WriteLine("Число должно быть положительным: "); 
        strValue = Console.ReadLine();
        Value = int.Parse(strValue);
    }
    string[] array = new string[Value];
    for(int i = 0; i < Value; i++)
    {
        Console.WriteLine($"Введите {i+1}й элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] array = FillArray();
PrintString(array);
PrintString(NewArray(array));
