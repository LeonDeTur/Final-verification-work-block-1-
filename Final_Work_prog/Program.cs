// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

// [“Russia”, “Denmark”, “Kazan”] → []
string[] temporaryArray = new string[0];

Console.WriteLine("Вводите данные. Когда закочите, введите пробел.");
string? tmp = Console.ReadLine();
while (ValidateForNotSpace(tmp) == true)
{

    temporaryArray = AddStringInArray(temporaryArray, tmp);
    tmp = Console.ReadLine();
}
Console.WriteLine("Введённый вами массив:");
PrintArray(temporaryArray);
Console.WriteLine();

Console.WriteLine("Массив с элементами, количество знаков которых меньше или равно 3:");
PrintArray (RewriteArrayWihtMaxLengthThree(temporaryArray));

// Методы
string[] AddStringInArray (string[] array, string input)
{
    string[] SecondArray = new string[array.Length + 1];
    for (int i = 0; i < SecondArray.Length - 1; i++)
    {
        SecondArray[i] = array[i];
    }
    SecondArray[SecondArray.Length - 1] = input;
    return SecondArray;  
}

bool ValidateForNotSpace (string? x)
{
    if (x != " ") {return true;}
    return false;
}

int CountElementsLengthMoreThanThree (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 3) {count ++;}
    }
    return count;
}

string[] RewriteArrayWihtMaxLengthThree (string[] array)
{
    string[] newArray = new string[array.Length - CountElementsLengthMoreThanThree(array)];
    int j = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        while (array[j].Length > 3)
        {
            j++;
        }
        newArray[i] = array[j];
        j++;
    }
    return newArray;

}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"<<{array[i]}>> ");
    }
    Console.WriteLine();
}

