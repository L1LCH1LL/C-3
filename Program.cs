Console.WriteLine("Введите координаты точки А");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int pod = ((x1-x2) * (x1-x2)) + ((y1-y2) * (y1-y2)) + ((z1-z2)*(z1-z2));

double pod2 = Math.Sqrt(pod);

double pod3 = Math.Round(pod2, 2);

Console.WriteLine(pod3);


