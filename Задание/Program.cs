string[] Array = new string[] { };
Console.Write("Введите количество слов, которые будут проверены на соответствие условиям:");
int X = int.Parse(Console.ReadLine());
Array = new string[X];
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($" Введите {i + 1} слово/число: ");
    Array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Введенные слова:");
Console.WriteLine($"{PrintArray(Array)}");
Console.WriteLine();

int length = 3;  

int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

int numbers = CheckArray(Array, length); 

string[] newArrayStrings = new string[numbers]; 
NewArray(Array, newArrayStrings, length);

void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.WriteLine("Введенные слова/числа которые меньше, либо равны 3 знакам: ");
Console.WriteLine($"{PrintArray(newArrayStrings)}");