//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями;
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем;
Console.WriteLine("Даны два уравнения: y = k1 * x + b1, y = k2 * x + b2. Задайте значения  b1, k1, b2 и k2 для определения точки пересечения");
Console.WriteLine("Введите число b1 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1 : ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 : ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2 : ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}

else
{
    Console.WriteLine( "Точка пересечения двух прямых " + "(" +  (x) + ";" + (y) + ")") ;
}




