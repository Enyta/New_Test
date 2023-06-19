﻿string[] Array1 = new string[9] {"79823974", "3456", "hello", "world", "yes", "bad", "to", "6", "76"};
string[] Array2 = new string[Array1.Length];
void NewArray(string[] Array1, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array1.Length; i++)
    {
    if(Array1[i].Length <= 3)
        {
        Array2[count] = Array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(Array1, Array2);
PrintArray(Array2);