// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());


Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());

int Stepen = 1;

for(int i = 1; i <=B; i++){
Stepen = Stepen * A;
}
Console.WriteLine($" {A} ^ {B} = {Stepen}");