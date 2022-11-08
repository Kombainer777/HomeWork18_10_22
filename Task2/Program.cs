// Показать числа Фибоначчи
Console.WriteLine("Введите предел для подсчета чисел Фибоначчи");
int num = int.Parse(Console.ReadLine());
int a = 1;
Console.Write($"{a} ");
int b = 1;
Console.Write($"{b} ");
int sum = 0;
int count = 3;
while (count < num)
{
    sum = a + b;
    Console.Write("{0} ", sum);
    a = b;
    b = sum;
    count = count+1;
}