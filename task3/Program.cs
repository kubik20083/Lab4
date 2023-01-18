
Console.Write("Введите желаемую длину массива, программа заполнит его: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
System.Console.Write($"array[{number}] = ");
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write(array[i] + ", ");
}




