// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter first slope number: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first y-intercept: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second slope number: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second y-intercept: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double FindX()
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double FindY()
{
    double y = k1 * FindX() + b1;
    return y;
}

Console.WriteLine($"Coordinates of the point of intersection are: {FindX()}; {FindY()}");