//Ввод координат точки A
Console.WriteLine("Введите координату x для точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y для точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

//Ввод координат точки B
Console.WriteLine("Введите координату x для точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y для точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z для точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Double Segment = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2));
//Округление до двух знаков после запятой
Double Distance = Math.Round(Segment, 2);

Console.WriteLine("Расстояние между точками в 3D: " + Distance);