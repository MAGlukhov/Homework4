// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
string number = (Console.ReadLine());

int result = 0;
for(int i = 0; i < number.Length; i++)
{
    int bar = number[i] - '0';
    result = result + bar;
}

Console.WriteLine(result);