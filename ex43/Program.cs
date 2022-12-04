// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double b1 = UserInput("Введите b1: ", "Ошибка ввода!");
double b2 = UserInput("Введите b2: ", "Ошибка ввода!");
double k1 = UserInput("Введите k1: ", "Ошибка ввода!");
double k2 = UserInput("Введите k2: ", "Ошибка ввода!");

double x = FindX(b1, b2, k1, k2);            // x   =   (b2 - b1) / (k1 - k2)
double y = FindY(b1, k1, x);
Console.WriteLine($"{x}, {y}");


double UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(double.TryParse(Console.ReadLine(), out double userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}

double FindX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY(double b1, double k1, double x)
{
    double y = k1 * x + b1;
    return y;
}