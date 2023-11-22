﻿// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


System.Console.WriteLine("Введите количество эллементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[n];

void CreateArray(string[] stringArray)
{
    for(int i = 0; i < stringArray.Length; i++)
    {
        System.Console.WriteLine($"Введите {i + 1}-ый эллемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
