Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите n:");
double n = double.Parse(Console.ReadLine());
Console.Write("Введите D:");
double D = double.Parse(Console.ReadLine());
Console.WriteLine(D = y * y * ((0.5 * n + 4.8) / (Math.Sin(y))));
Console.WriteLine($"D={D:F2}");
