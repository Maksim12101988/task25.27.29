// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);


// double a;
// double b;
// double c;
// Console.WriteLine("Число которое возвести в степень:");
// a = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите степень, в которую хотите возвести число " + a + ":");
// b = Convert.ToDouble(Console.ReadLine());
// c = Math.Pow(a, b);
// Console.WriteLine("равно " + c + "");
// Console.ReadLine();
