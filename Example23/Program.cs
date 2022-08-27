// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string GetPow3(int number)
{
    int numberPow3;
    List<int> result = new List<int>();
    if (number < 1) return "Число меньше 1!";
    else
    {
        for(int i = 1; i <= number; i++)
        {
            numberPow3 = Convert.ToInt32(Math.Pow(i, 3));
            result.Add(numberPow3);
        }
        return string.Join(", ", result.ToArray());
    }
}

try
{
    Console.Write("Введите целое число больше 1:\t");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(GetPow3(num));
}
catch
{
    Console.WriteLine("Неверный ввод!");
}