// ЗАДАЧА:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.



void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.Clear();

Console.Write("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] firstArr = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    firstArr[i] = element;
}

string[] secondArray = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (firstArr[j].Length <= len)
    {
        secondArray[pos] = firstArr[j];
        pos++;
    }
}

Console.WriteLine();
Console.Write("Исходная строка: ");
PrintArray(firstArr);
Console.WriteLine();
Console.Write("Результат: ");
PrintArray(secondArray);
Console.WriteLine();
