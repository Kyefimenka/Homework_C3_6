// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.


int k1, k2, b1, b2, x0, y0;

Console.WriteLine("First line coefficients:");

Console.Write("k1 = ");
k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b1 = ");
b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second line coefficients:");

Console.Write("k2 = ");
k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
b2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2)
{
    Console.WriteLine("Lines are parallel");
    return;
}

x0 = (b2 - b1) / (k1 - k2);
y0 = (k1 * b2 - k2 *b1) / (k1 -k2);


Console.WriteLine($"Intersection: ({x0}, {y0})");
