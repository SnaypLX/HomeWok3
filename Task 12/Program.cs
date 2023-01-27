// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.



Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());


int[] arr = new int[A];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(1,99); 
         arr[i] = num;
       
    }

int Pr = 0;
foreach (int item in arr)
{
    Console.WriteLine(item);
}


for (int j = 0; j < arr.Length/2; j++)
{
Pr = arr[j] * arr[arr.Length-1-j];
Console.WriteLine($"Произведение пары чисел равна {Pr}");

}





