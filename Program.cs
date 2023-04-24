// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Write("Enter the number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] arrayNew = new string[array.Length];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Input {i+1} element: ");
    string element = Convert.ToString(Console.ReadLine());
    array [i] = element;
}

void SecondArray(string[] array, string[] arrayNew)
{
    int len = 3;
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= len)
            {
                arrayNew[count] = array[i];
                count++;
            }
    }
}

SecondArray(array, arrayNew);

Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", arrayNew)}]");



