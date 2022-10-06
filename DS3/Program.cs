int N;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);

if ((6<=N)&&(N<=8))
{
    Console.Write ($"Выходной");
}

if ((1<=N)&&(N<6))
{
Console.Write($"Будний день");
}
