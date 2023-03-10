// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Это второй вариант, который я попробовал. Но он нерабочий(
//Почему??? прошу подсказать

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
char[] num = number.ToCharArray(); //преобразовываем число в массив

int Palindrom (int digits); //определяем метод
{
int n = digits.Length; //определяем длину массива
for (int i=0; i<= n/2; i++)
{
    if(num[i]==num[n-(i+1)])  //в цикле сравниваем первый и последний элемент массива
    return 0;
    else 
    return 1;
}
}
int palindrom = Palindrom(num);
string result = palindrom > 0 ? "Это не палиндром" : "Число - палиндром"; 
Console.Write(result);


