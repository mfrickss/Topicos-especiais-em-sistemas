// See https://aka.ms/new-console-template for more information
double reais, dolar, euro, pesoARG;

Console.WriteLine("Informe valor em reais: R$");
reais = Convert.ToDouble(Console.ReadLine());

dolar = reais * 5.17;
euro = reais * 6.14;
pesoARG = reais * 0.05;

Console.WriteLine($"O valor R${reais} em dolar é: U${dolar}.\nO valor R${reais} em euro é: €{euro}.\nO valor R${reais} em peso argentino é: AR${pesoARG}.\n");
