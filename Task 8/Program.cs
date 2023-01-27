// Определить, присутствует ли в заданном массиве, некоторое число

Console.WriteLine("Введите размер массива");
int A = int.Parse(Console.ReadLine());

int[] arr = new int[A];

Console.WriteLine("Введите Число");
int B = int.Parse(Console.ReadLine());






for (int i = 0; i < arr.Length; i++)
{
         int num = new Random().Next(99); 
         arr[i] = num;
       
}

for (int j = 0; j<arr.Length; j++){
if (B == arr[j])
Console.WriteLine($"Число {B} присутствует в данном массиве");
break;

}