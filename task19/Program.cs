// 19. Написать программу которая:
// 1. принимант на вход целое пятизначное число
// 2. проверяет является ли оно палиндромом

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;
    if(num1 == num5 && num2 == num4) Console.WriteLine($"Число {num} -> является палиндромом");
    else Console.WriteLine($"Число {num} -> не является палиндромом");

}     
if(number > 9999 && number <= 99999 ) Palindrome(number);
else Console.WriteLine("Некоректный ввод");
