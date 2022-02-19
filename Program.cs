/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами. */
using static System.Console;

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
string[] stringArray = { "hello", "2", "world", ":-)" };

PrintStringArray(stringArray);


