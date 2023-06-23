// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0) {
    Console.WriteLine("Число четное");
}
else {
    Console.WriteLine("Число нечетное");
}
Console.WriteLine("Конец программы");