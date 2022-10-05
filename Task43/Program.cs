// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void XPoint(double[,] valuesArr)
{
    double x = (valuesArr[0, 1] - valuesArr[0, 0]) / (valuesArr[1, 0] - valuesArr[1, 1]);
    double y = valuesArr[1, 0] * x + valuesArr[0, 0];
    Console.WriteLine($"({x}; {y})");
}

double[,] valuesArray = new double[2, 2];
Console.WriteLine("Введите b1: ");
valuesArray[0, 0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
valuesArray[1, 0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
valuesArray[0, 1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
valuesArray[1, 1] = Convert.ToDouble(Console.ReadLine());

XPoint(valuesArray);