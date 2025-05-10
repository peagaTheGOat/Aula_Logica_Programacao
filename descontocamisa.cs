double codigo, preco, desconto, preco_com_desconto; 
string tamanho;
Console.WriteLine("Digite o código da camiseta: ");
codigo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o tamanho da camiseta (G, M ou P): ");
tamanho = Convert.ToString(Console.ReadLine()); 
Console.WriteLine("Digite o preço da camiseta: "); 
preco = Convert.ToDouble(Console.ReadLine()); 
if (tamanho == "G") 
{ 
    desconto = preco * 0.10; 
}
else if(tamanho == "M")
{ 
    desconto = preco * 0.20; 
}
else if(tamanho == "P")
{ 
    desconto = preco * 0.30; 
}
else 
{ 
    desconto = 0; 
}
preco_com_desconto = preco - desconto; 
Console.WriteLine("Código da camiseta: " + codigo);
Console.WriteLine("Tamanho da camiseta: " + tamanho);
Console.WriteLine("Preço sem desconto: R$ " + preco); 
Console.WriteLine("Valor ao desconto: R$ " + desconto);
Console.WriteLine("Preço com desconto: R$" + preco_com_desconto);
