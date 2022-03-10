/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int changeNumber = 0;

//переворачиваем введенное число: 12345 -> 54321
while (userNumber > 0)
{
    changeNumber *= 10;
    changeNumber += userNumber % 10;
    userNumber /= 10;
}

if (changeNumber == number)
{
    Console.WriteLine(number + " - палидром.");
}
else
{
    Console.WriteLine(number + " - не палидром.");
}