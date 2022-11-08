// Написать программу масштабирования фигуры
Console.WriteLine("Введите 2 точки вершины A");
int a= int.Parse(Console.ReadLine());
int a1 = int.Parse(Console.ReadLine());
int [] A = {a, a1};

Console.WriteLine("Введите 2 точки вершины B");
int b = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int [] B = {b, b1};

Console.WriteLine("Введите 2 точки вершины C");
int c = int.Parse(Console.ReadLine());
int c1 = int.Parse(Console.ReadLine());
int [] C = {c, c1};

Console.WriteLine("Введите 2 точки вершины D");
int d = int.Parse(Console.ReadLine());
int d1 = int.Parse(Console.ReadLine());
int [] D = {d, d1};

Console.WriteLine($"Вершины вашей фигуры: A:({a},{a1});  B:({b},{b1});  C:({c},{c1});  D:({d},{d1}) ");

Console.WriteLine("Введите коэффициент масштабирования");
int k = int.Parse(Console.ReadLine());

Console.WriteLine("Координаты после приминения коэффициента масштабирования ");

foreach (int element in A)
{
    int AK = element * k;
    Console.Write($"{AK} ");
}
Console.WriteLine();
foreach (int element in B)
{
    int BK = element * k;
    Console.Write($"{BK} ");
}
Console.WriteLine();
foreach (int element in C)
{
    int CK = element * k;
    Console.Write($"{CK} ");
}
Console.WriteLine();
foreach (int element in D)
{
    int DK = element * k;
    Console.Write($"{DK} ");
}