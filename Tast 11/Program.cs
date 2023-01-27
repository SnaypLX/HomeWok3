// Найти сумму чисел одномерного массива стоящих на нечетной позиции


Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());


int[] arr = new int[A];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(1,1000); 
         arr[i] = num;
       
    }

int sum = 0;


for (int i = 1; i < arr.Length; i = i + 2)
{
sum = sum + arr[i];


}


Console.WriteLine($"Сумма чисел на нечетной позиции равна  {sum}");
