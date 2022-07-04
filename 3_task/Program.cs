// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.Clear();
int num = InputInt("введите число ");
int a = 1;
while (a <= num)
{
    a++; 
    Console.WriteLine($"{a} * {a} * {a} = {a * a * a}");
}
Console.WriteLine();
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
