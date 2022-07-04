//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
int x1 = InputInt("введите первую координату Х : ");
int x2 = InputInt("введите вторую координату Х : ");
int x3 = InputInt("введите третью координату X : ");
int y1 = InputInt("введите первую координату Y : ");
int y2 = InputInt("введите вторую координату Y : ");
int y3 = InputInt("введите третью координату Y : ");
double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 + y2) * (y1 + y2) + (x3 - y3) * (x3 - y3));
Console.WriteLine(result);
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}