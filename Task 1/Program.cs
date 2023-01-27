// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

for (int i=1; i<=N; i++){
    int Q = i*i*i;
    Console.WriteLine($"Куб числа {i} - {Q}");
}