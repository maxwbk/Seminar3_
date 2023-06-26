// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// разбиваем число на цифры и записываем в массив
int[] digits = new int[5];
for (int i = 0; i < 5; i++)
{
    digits[i] = number % 10;
    number /= 10;
}

// проверяем, является ли число палиндромом
bool isPalindrome = true;
for (int i = 0; i < 2; i++)
{
    if (digits[i] != digits[4 - i])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
{
    Console.WriteLine("Число является палиндромом!");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}

Console.ReadLine();
