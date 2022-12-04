// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Clear();

int userInput = UserInput("Введите число элементов будущего массива: ", "Ошибка ввода!");

int[] array = GetArray(userInput);

Console.WriteLine(String.Join(" ", array));

int evenNumbers = GetEvenNumbers(array);

Console.WriteLine($"Even numbers = {evenNumbers}");





//__________________________Методы_____________________________//
int UserInput(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out int userInput))
            return userInput;

        Console.WriteLine(errorMessage);
    }
}
//______________________________________________________________//

int[] GetArray(int userInput, int minValue, int maxValue)
{
    int[] res = new int[userInput];

    for (int i = 0; i < userInput; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

//________________________________________________________________//

int GetEvenNumbers(int[] arr)
{
    int evenNumbers = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) evenNumbers++;
    }
    return evenNumbers;
}