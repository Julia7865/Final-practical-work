// Написать программу, 
// которая из имеющегося массива строк формирует массив из строк, 
// длина которых маньше либо равна 3 символа.


Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
EnteringArrayString(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
int newLength = 3;
int counter = NewArrayLenght(array, newLength);

if (counter <= 0) Console.Write("[]");
else
{
    string[] newArray = new string[counter];
    StringArrayLengthThree(array, newArray, counter);
    Console.Write($"[{string.Join(", ", newArray)}]");
}


void EnteringArrayString(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите текст массива: ");
        arr[i] = Console.ReadLine();
    }
}

int NewArrayLenght(string[] arr, int newLen)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= newLen) count++;
    }
    return count;
}


void StringArrayLengthThree(string[] arr, string[] newArray, int newLength)
{
    int newIndex = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= newLength) 
        {
            newArray[newIndex] = arr[i];
            newIndex++;
        }
    }
}





