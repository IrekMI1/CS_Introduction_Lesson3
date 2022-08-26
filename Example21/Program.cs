// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance3D(int[] a, int[] b)
{
    double distanceXY = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2));
    double distance3D = Math.Sqrt(Math.Pow(a[2] - b[2], 2) + Math.Pow(distanceXY, 2));
    return Math.Round(distance3D, 2);
}

try
{
    Console.Write("Введите координаты первой точки в формате x,y,z :\t");
    int[] first = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

    Console.Write("Введите координаты второй точки в формате x,y,z :\t");
    int[] second = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

    double distance = GetDistance3D(first, second);
    Console.WriteLine($"Расстояние между двумя точками в пространстве: {distance}");
}
catch
{
    Console.WriteLine("Неверный формат ввода координат!");
}