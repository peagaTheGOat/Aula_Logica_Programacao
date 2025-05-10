double numero, resultado;
Console.WriteLine(" escolha um numero ");
numero = Convert.ToDouble(Console.ReadLine());
resultado = numero * 6;
if (numero > 90)
{
    Console.WriteLine(numero + " é o seu numero e " + resultado + " é o seu sextuplo ");
}
else
    Console.WriteLine(numero + " é o seu numero ");
