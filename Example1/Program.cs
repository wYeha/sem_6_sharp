// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    int result = Convert.ToInt32(text);
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Prompt($"Введи {i + 1}-й элемент:");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int HowMany(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введи число М: ");
int[] arr = InputArray(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine($" -> {HowMany(arr)}");