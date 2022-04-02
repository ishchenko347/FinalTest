// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

//string[] array = { "1234", "1567", "-2", "computer science" };
string[] array = { "hello", "2", "world", ":-)" };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

int j = 0;
string[] result = new string[count];

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[j] += array[i];
        j++;
    }
}

WriteLine("Заданный массив:");
WriteLine(String.Join("+", array));
WriteLine();
WriteLine("Массив из строк, длина которых <= 3:");
WriteLine(String.Join("+", result));