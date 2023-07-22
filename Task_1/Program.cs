// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter a new number and press ENTER or just press ENTER when it's enough");

List<int> list = new List<int>(); // Создаем динамический массив.

bool PromptNumbers = true;

while(PromptNumbers) // Условие, при котором можно вводить любое количество чисел.
{
    string num = Console.ReadLine();

    if(num == "") // Если null, то набор чисел завершается.
    {
        PromptNumbers = false;
    }
    else
    {
        int numValue = Convert.ToInt32(num); // Конвертируем число в int
        list.Add(numValue); // и добавляем в массив.
    }
}

int CountPositiveNum() // Реализация функции подсчета позитивных чисел.
{
    int count = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (list[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("In your array of elements [ ");
foreach(int value in list)
{
    Console.Write(value + " "); // Выводим массив в одну строку.
}

Console.WriteLine($"] there are {CountPositiveNum()} positive numbers"); // Вызов функции подсчета позитивных чисел.