double x1, x2, y1, y2, distancia;
Console.WriteLine("informe x1");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("informe y1");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("informe x2");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("informe y2");
y2 = Convert.ToDouble(Console.ReadLine());
distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("distancia igual a: " + distancia);


