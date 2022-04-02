// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

//string[] array = { "1234", "1567", "-2", "computer science" };
string[] array = { "hello", "2", "world", ":-)" };

string[] result = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[i] += array[i];
    }
}

WriteLine("Заданный массив:");
WriteLine(String.Join(" ", array));
WriteLine();
WriteLine("Массив из строк, длина которых <= 3:");
WriteLine(String.Join(" ", result));