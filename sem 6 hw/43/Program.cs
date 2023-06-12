// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Данный код покажет, пересекаются ли прямые, заданные уравнениями.");
double b1 = Imput("Введите b1: ");
double k1 = Imput("Введите k1: ");
double b2 = Imput("Введите b2: ");
double k2 = Imput("Введите k2: ");
if (k1-k2 == 0) Console.WriteLine("Пересечение невозможно");
else
Console.WriteLine($"Координаты точки пересечения: {Intersection(b1,k1,b2,k2)}");

double[] Intersection(double b1, double k1, double b2, double k2)
{
    double[] res = new double[2];
    res[0] = Convert.ToDouble((b2-b1)/(k1-k2));
    res [1] = Convert.ToDouble((k2*b1 + b2*k1)/(k1-k2));
    return res;
}


double Imput(string smth)
{
    Console.WriteLine(smth);
    double res = int.Parse(Console.ReadLine());
    return res;
}