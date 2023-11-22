// Задача: 
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void CreateArray(string[] stringArray)
{
    for(int i = 0; i < stringArray.Length; i++)
    {
        System.Console.Write($"Введите {i + 1}-ый эллемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
}

string[] ArraySorted(string[] stringArray)
{
    int m = 0;
    for(int i = 0; i < stringArray.Length; i++)
    {
        if(stringArray[i].Length <= 3)
        {
            m++;
        }
    }
    string[] rezArray = new string[m];
    int k = 0;
    for(int i = 0; i < stringArray.Length; i++)
    {
        if(stringArray[i].Length <= 3)
        {
            rezArray[k] = stringArray[i];
            k++;
        }
    }
    return rezArray;
}

void PrintArray(string[] stringArray)
{
    System.Console.Write("[");
    for(int i = 0; i < stringArray.Length; i++)
    {
        System.Console.Write($"'{stringArray[i]}',");
    }
    System.Console.Write("]");
}


System.Console.Write("Введите количество эллементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[n];

CreateArray(stringArray);
PrintArray(ArraySorted(stringArray));
