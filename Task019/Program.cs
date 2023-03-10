// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99999||number<10000)
Console.WriteLine("Введите пятизначное число заново");

else
{

int Palindrom (int x)
{
if ((x/10000) == x%10 && (x/1000)%10 == (x%100)/10) return 0;
return 1;
}

int palindrom = Palindrom(number);
string result = palindrom > 0 ? "Это число не палиндром" : "Это же палиндром!!!"; 

Console.Write(result);
}


