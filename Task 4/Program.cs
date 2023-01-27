// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");

int A = int.Parse(Console.ReadLine());
int B = 0;
int sum = 0;


while(A != 0)
{
    B = A % 10;
  
    A = A / 10;

    sum = sum + B;   
}

Console.WriteLine(sum);