// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива строк через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');
        string[] newArray = FilterStrings(originalArray);
        Console.WriteLine("Новый массив строк с длиной <= 3 символов:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        System.Collections.Generic.List<string> filteredList = new System.Collections.Generic.List<string>();
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                filteredList.Add(str);
            }
        }
        return filteredList.ToArray();
    }
    
}