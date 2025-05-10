double A, B, C; 
Console.WriteLine("Digite o valor do lado A: "); 
A = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Digite o valor do lado B: "); 
B = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Digite ovalor do lado C: "); 
C = Convert.ToDouble(Console.ReadLine());
if ((A + B > C) && (A + C > B) && (B + C > A))
{
    if ((A == B) && (B == C))
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if ((A == B) || (A == C) || (B == C))
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}

else
{
    Console.WriteLine("Os valores fornecidos não formam um triângulo");
}
