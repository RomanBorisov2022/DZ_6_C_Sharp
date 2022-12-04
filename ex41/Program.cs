// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();


int userInput = UserInput("Введите число элементов будущего массива: ", "Ошибка ввода!");

int[] array = GetArray(userInput);

Console.WriteLine(String.Join(" ", array));

int positiveNumbers = GetPositiveNumbers(array);

Console.WriteLine($"Positive numbers = {positiveNumbers}");





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

int[] GetArray(int userInput)
{
    int[] res = new int[userInput];

    for (int i = 0; i < userInput; i++)
    {
        res[i] = UserInput("Введите число: ", "Ошибка ввода!");
    }
    return res;
}

//________________________________________________________________//

int GetPositiveNumbers(int[] arr)
{
    int positiveNumbers = 0;
    foreach (int el in arr)
    {
        if (el > 0) positiveNumbers++;
    }
    return positiveNumbers;
}