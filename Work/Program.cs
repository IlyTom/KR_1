string[] FillArray()
{
    System.Console.WriteLine("Введите элементы массива через запятую , без пробелов между разными элементами (в одном элементе могут быть пробелы): ");
    string str = Console.ReadLine()!;
    string[] Array = new string[str.Length];
    char[] separator = new char[] {','};
    Array = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
    return Array;
}

string[] NewArray(string[] Array)
{
    int size = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3) size++;
    }
    string[] newArray = new string[size];
    int n = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            newArray[n] = Array[i];
            n++;
        }
    }
    return newArray;
}

string[] Array = FillArray();
string[] newArray = NewArray(Array);

System.Console.WriteLine($"[{String.Join(",", Array)}] -> [{String.Join(",", newArray)}]");

