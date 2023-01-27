// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int multi = 1;
int i = 1;
while (i<=N)
{
multi = multi * i;
i++;
}

Console.WriteLine($"Произведение чисел от 1 до {N} = {multi}");