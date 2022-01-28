// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

string[] FillArray(string text)
{
    text = text.Replace('"', '[')
                .Replace(",", "")
                .Replace("[", "")
                .Replace("]", "");
    string[] array = text.Split(" ");
    return array;
}

string PrintArray(string[] arr)
{
    string output = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        output += $"{arr[i]}, ";
    }
    if (arr.Length == 0) {output = String.Empty;}
    else {output = output.Substring(0, output.Length - 2);}
    return $"[{output}]";
}

string[] SelectArray(string[] array)
{
    string[] selectArr = new string[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            Array.Resize(ref selectArr, count + 1);
            selectArr[count] = array[i];
            count++;
        }
    }
    return selectArr;
}

Console.Write("Введите элементы массива через пробел: ");
string[] array = FillArray(Convert.ToString(Console.ReadLine()));
Console.Write(PrintArray(array));
Console.Write(" -> ");
array = SelectArray(array);
Console.Write(PrintArray(array));