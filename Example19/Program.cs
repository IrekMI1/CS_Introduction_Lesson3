// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string CheckPalindrome(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int fourthDigit = num % 100 / 10;
    int lastDigit = num % 10;

    if (Math.Ceiling(Math.Log(num, 10)) != 5) 
    {
        return "Число должно быть пятизначным и положительным!";
    }
    else if (firstDigit == lastDigit && secondDigit == fourthDigit)
    {
        return "Да";
    } 
    else return "Нет";
}

try
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(CheckPalindrome(number));
}
catch 
{
    Console.WriteLine("Нужно было вводить целое число!");
}




