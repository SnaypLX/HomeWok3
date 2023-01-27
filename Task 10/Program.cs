// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]



int[] arr = new int[123];

    for (int i = 0; i < arr.Length; i++)
    {
         int num = new Random().Next(1,1000); 
         arr[i] = num;
       
    }
int number = 0;

    for(int i = 0; i < arr.Length; i++){
        if (arr[i] > 9 && arr[i] < 100)
        number = number + 1;
    }

Console.WriteLine($"количество элементов из отрезка [10,99] равна {number}");