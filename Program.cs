/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами. */
using static System.Console;
Clear();

void PrintStringArray(string[] stringArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}
int SearchStringSizeLessNumber(string[] stringArray)
{
    int numberOfString = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            numberOfString++;
        }
    }
    return numberOfString;
}
string[] CreateArrayWidthSizeLessNumber(string[] stringArray, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArray[i];
            j++;
        }

    }
    return newStringArray;
}
string[] stringArray = { "hello", "2", "world", ":-)" };
PrintStringArray(stringArray);
/* WriteLine(SearchStringSizeLessNumber(stringArray)); */
int sizeNewArray = SearchStringSizeLessNumber(stringArray);
string[] newStringArray = CreateArrayWidthSizeLessNumber(stringArray, sizeNewArray);
Write(" -> ");
PrintStringArray(newStringArray);
