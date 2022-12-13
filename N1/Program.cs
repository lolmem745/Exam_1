static void printArray(string[] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1) Console.Write($", ");
    }
    Console.Write($"]");
}
static string[] lengthChecker(string[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length > 3) arr[i] = String.Empty;
    }
    string[] arr1 = arr.Where(x => x != String.Empty).ToArray();
    return arr1;
}

string[] arr = { "2387", "23", "234", "82732", "992993", "449", "Kazan", "-2", "fly" };

arr = lengthChecker(arr);
printArray(arr);
