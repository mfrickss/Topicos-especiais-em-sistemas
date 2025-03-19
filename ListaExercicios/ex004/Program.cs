// Desenvolver um algoritmo para ler o valor inteiro da idade de uma pessoa e imprimir uma das mensagens: se idade <= 13: Criança, se idade > 13 e <= 18: Adolescente, se idade > 18 e <= 60: Adulto e se idade > 60: Idoso

int idade;

Console.WriteLine("Informe sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());


while (idade != 0)
{
    if (idade <= 0)
    {
        Console.WriteLine("Você ainda nem nasceu!");
    }
    else if (idade >= 1 && idade <= 13)
    {
        Console.WriteLine("Você é uma criança!");
    }
    else if (idade >= 14 && idade <= 18)
    {
        Console.WriteLine("Você é adoslecente!");
    }
    else if (idade > 18 && idade <= 60)
    {
        Console.WriteLine("Você é adulto!");
    }
    else
    {
        Console.WriteLine("Você ta veio!");
    }
    Console.WriteLine("Informe sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}