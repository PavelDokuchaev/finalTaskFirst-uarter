/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] generateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] finalArray(string[] incomingArray)
{
    string[] resultArray = new string[incomingArray.Length];
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i].Length <= 3)
        {
            resultArray[count] = incomingArray[i];
            count++;
        }
    }
    Array.Resize(ref resultArray, count);

    return resultArray;
}

void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine("Задайте длинну массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
string[] currentArray = generateArray(userNumber);
Console.WriteLine("Заданный пользователем массив: ");
printArray(currentArray);
string[] convertArray = finalArray(currentArray);
Console.WriteLine("Сформированный массив из строк, длина которых меньше либо равна 3 символа: ");
printArray(convertArray);
