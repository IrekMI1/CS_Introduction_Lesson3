// Задача необязательная: Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, 
// пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
// Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.

void GetSqrtSum()
{
    Console.WriteLine("Вводите числа, пока сумма не равно 0:");
    int number;
    int sum = 0;
    double sumSqrt = 0;
    do
    {
        number = Convert.ToInt32(Console.ReadLine());
        sum = sum + number;
        sumSqrt = sumSqrt + Math.Pow(number, 2);
    } while (sum != 0);
    Console.WriteLine($"Сумма квадратов {sumSqrt}");
}

try
{
    GetSqrtSum();
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}