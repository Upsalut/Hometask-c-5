// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2
// b1 k1 и b2 и k2 заданы
double PrintValue(string text)
{
    Console.Write($"Введите значение {text}: ");
    double value = double.Parse(Console.ReadLine() ?? "");
    return(value);
}
double k1=PrintValue("k1");
double k2=PrintValue("k2");
double b1=PrintValue("b1");
double b2=PrintValue("b2");

if (k1==k2)
Console.WriteLine("При таких значениях прямые не пересекаются");
else
{
double x=(b1-b2)/(k1-k2);
double y=k2*x+b2;
Console.WriteLine($"Координаты точки пересечения для k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} равны х = {x} и y = {y}.");
}
