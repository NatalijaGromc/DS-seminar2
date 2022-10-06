int N;
string userEnter;

Console.Write ("Введите число N: ");
userEnter = Console.ReadLine()!;
N = int.Parse(userEnter);

if (100<=N)

{
while (N>=1000)
{
N=N/10;
}
Console.Write($"{N/1000*10+N%10}");
}
else
{
Console.Write ($"Третья цифра отсутствует");
}
