string[] arrayIn;
string[] arrayOut;


arrayIn = GetArrayFromUser();
Console.WriteLine("Входной массив");
PrintArray(arrayIn);
Console.WriteLine();
Console.WriteLine("Отфильтрованный массив");
arrayOut = GetFilteredArray(arrayIn);
PrintArray(arrayOut);


string[] GetArrayFromUser()
{
    string InputString = string.Empty;
    int Size = 0;
    string[] StringArray = new string[Size];
    bool StringIsEmpty = true;

    do
    {
        Console.WriteLine("Введите следующий элемент массива ");
        InputString = Console.ReadLine();
        StringIsEmpty = string.IsNullOrEmpty(InputString);
        if (!StringIsEmpty)
        {
            Size++;
            Array.Resize(ref StringArray, Size);
            StringArray[Size - 1] = InputString;
        }

    } while (!StringIsEmpty);

    return StringArray;
}

string[] GetFilteredArray(string[] from)
{
    int Size = 0;
    string[] OutArray = new string[Size];
    foreach(var item in from)
    {
        if (item.Length <4)
        {
            Array.Resize(ref OutArray, ++Size);
            OutArray[Size - 1] = item;
        }
    }

    return OutArray;
}

void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.Write("[");
    bool first = true;
    foreach(var item in array)
    {
        if (first)
        {
            Console.Write($"\"{item}\""); 
            first = false;
        } else
        {
            Console.Write($",\"{item}\"");
        }
    }
    Console.WriteLine("]");
}
