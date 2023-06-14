void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine($"Write {i + 1} element: ");
        arr[i] = Console.ReadLine();
    }
}

void CreateNewArr(string[] array, string[] newArr)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[temp] = array[i];
            temp++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void Task()
{
    string Input(string text)
    {
        Console.Write($"{text} ");
        return Console.ReadLine();
    }
    int size = Convert.ToInt32(Input("how long it's gonna be: "));
    string[] array = new string[size];
    string[] newArr = new string[array.Length];
    FillArray(array);
    System.Console.WriteLine();
    PrintArray(array);
    System.Console.WriteLine();
    CreateNewArr(array, newArr);
    PrintArray(newArr);
}
Task();