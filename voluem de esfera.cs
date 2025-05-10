using System.Globalization;

decimal raio, volume;
Console.WriteLine("Digite o raio da esfera: ");
raio = decimal.Parse(Console.ReadLine());
volume = (4.0 / 3) * Math.PI * Math.Pow(raio, 3);

string decimalFormat = "F11";

Console.WriteLine("O volume da esfera é: " + volume.ToString(decimalFormat, CultureInfo.InvariantCulture))

# ToString("F7", CultureInfo.InvariantCulture)); forma de escolher as casas decimais de uma if
# using System.Globalization; como se fosse um import from do pythom