// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

for (int i=1; i<=N; i++){
    int Q = i*i*i;
        if (Q % 2 == 0)

        
    Console.WriteLine($"Куб числа {i} - {Q}, и он закачивается на четную цифру");
       
}

