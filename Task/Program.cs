// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: ["hello","2","world",":-)"]->["2",":-)"];  ["1234","1567","-2","computer science"]->["-2"];  ["Russia","Denmark","Kazan"]->[]


string[] array1 = new string[4] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array1.Length];

void FillResultArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}
FillResultArray(array1, array2);
PrintArray(array1);
PrintArray(array2);