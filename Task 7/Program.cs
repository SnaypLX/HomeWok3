// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран


int[] arr = new int[8];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(2); 
         arr[i] = num;
       
    }
foreach (int item in arr)
{
    Console.WriteLine(item);
}
