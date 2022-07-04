//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
int num1 = InputInt("введите число ");
int num3 = 0;
int num2 = 0;
int a = num1;
int count = 0;
 while(count < 5)
{
    num2 = num1 % 10;
    num1 = num1 / 10;
    num3 = (num3 * 10) + num2;
    count++;
}
if(a == num3)
{
    Console.WriteLine("это число палиндром");
}
else
{
    Console.WriteLine("это число не является палиндромом");
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
