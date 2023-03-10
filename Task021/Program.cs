//21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int numXA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numYA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int numZA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("X: ");
int numXB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int numYB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int numZB = Convert.ToInt32(Console.ReadLine());

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{ 
    double interval = Math.Round(MathF.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)), 2, MidpointRounding.ToZero);
    return interval;
}

double distance3D = Distance3D(numXA, numYA, numZA, numXB, numYB, numZB);
Console.WriteLine(distance3D);

