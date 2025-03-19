// See https://aka.ms/new-console-template for more information


double altura, largura, area;

Console.WriteLine("Informe altura: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe largura: ");
largura = Convert.ToDouble(Console.ReadLine());

area = largura * altura;
Console.WriteLine($"A area é: {area}.");