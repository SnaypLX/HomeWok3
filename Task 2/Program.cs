// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());
int sum = 0;
int i = 1;
while (i<=A)
{
sum = sum + i;
i++;
}

Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");