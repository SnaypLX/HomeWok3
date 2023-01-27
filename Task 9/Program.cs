// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел

Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());


int[] arr = new int[A];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(100,1000); 
         arr[i] = num;
       
    }

int chet = 0;
int nechet= 0;

foreach (int item in arr)
{
    Console.WriteLine(item);
}


for (int i = 0; i < arr.Length; i++)
{
if (arr[i] % 2 == 0){
 chet = chet + 1;
}
else{
    nechet = nechet + 1;
}


}

Console.WriteLine($"Количество четных {chet}");
Console.WriteLine($"Количество нечетных {nechet}");

