/*
Console.Write("Введите длину: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите ширину: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Площадь: {a * b}");
Console.WriteLine($"Периметр: {2 * (a + b)}");
*/
/*
Console.Write("Введите сумму в рублях: ");
double rub = double.Parse(Console.ReadLine());
Console.Write("Введите курс доллара: ");
double rate = double.Parse(Console.ReadLine());

Console.WriteLine($"В долларах: {rub / rate:F2}");
*/
/*
double sum = 0;
for (int i = 1; i <= 7; i++)
{
    Console.Write($"Температура в день {i}: ");
    sum += double.Parse(Console.ReadLine());
}
Console.WriteLine($"Средняя температура: {sum / 7:F2}");5,
*/
/*
for (int student = 1; student <= 3; student++)
{
    double sum = 0;

    Console.WriteLine($"\nСтудент {student}:");
    for (int grade = 1; grade <= 5; grade++)
    {
        Console.Write($"  Оценка {grade}: ");
        sum += double.Parse(Console.ReadLine());
    }

    double average = sum / 5;
    Console.WriteLine($"Средняя оценка студента {student}: {average:F2}");
}
*/
/*
int[,] m = new int[3, 3];

Console.WriteLine("Введите 9 чисел через пробел:");
string[] parts = Console.ReadLine().Split(' ');

int k = 0;
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        m[i, j] = int.Parse(parts[k++]);

int[,] t = new int[3, 3];
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        t[j, i] = m[i, j];

Console.WriteLine("\nБыло:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write(m[i, j] + " ");
    Console.WriteLine();
}

Console.WriteLine("\nСтало:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
        Console.Write(t[i, j] + " ");
    Console.WriteLine();
}
*/