string[] array = new string[5];
string[] SmallArray = new string[0];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите значение {i+1}: ");
    array[i] = Console.ReadLine();
}

Console.Write("[" + string.Join(", ", array) + "] -> ");

int size = 3;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= size)
    {
        Array.Resize(ref SmallArray, SmallArray.Length + 1);
        SmallArray[SmallArray.Length-1] = array[i];
    }
}
Console.Write("[" + string.Join(", ", SmallArray) + "]");


