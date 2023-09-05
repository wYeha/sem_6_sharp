// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System.Runtime.Intrinsics.X86;

double Prompt(string message)
{
    Console.Write(message);
    string text = Console.ReadLine();
    double result = Convert.ToInt32(text);
    return result;
}

bool ValidateLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

void Result(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);
}

double k1 = Prompt("Введи k1 "), b1 = Prompt("Введи b1 "), k2 = Prompt("Введи k2 "), b2 = Prompt("Введи b2 ");
if (ValidateLines(k1, b1, k2, b2)) Result(k1, b1, k2, b2);