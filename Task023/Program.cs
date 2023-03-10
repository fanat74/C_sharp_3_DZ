// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

ListOfCubes(num);
void ListOfCubes(int endpoint)
{
    int i = 1;
    while (i<=endpoint)
    {
 Console.WriteLine($"{i} -> {i*i*i}");
 i++;
    }
}