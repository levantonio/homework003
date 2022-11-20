// Задача 23
// написать программу
// 1. принимает число на вход n
// 2. выдаёт таблицу кубов




Console.WriteLine("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int num1 = 1;
    while (num1 <= num)
    {
        int result = num1 * num1 * num1;
        Console.WriteLine($"Куб числа{num1,   4}  -->  {result,   6} ");
        
        num1++;
    }
}
if (N > 0)
    Cube(N);// ,без печати потому что метод void!!!
else
    Console.WriteLine("Некоректный ввод");
