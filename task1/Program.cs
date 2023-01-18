Console.WriteLine("Калькулятор. Возведение в степень.");
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которою хотите возвести число");
int b = Convert.ToInt32(Console.ReadLine());
int result = a;

for (int i = 1; i < b; i++)
{
result = result * a;
}
Console.WriteLine($"{a} в степени {b} равно: " + result);