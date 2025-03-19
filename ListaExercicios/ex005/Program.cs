//  Criar um algoritmo que receba um valor positivo inteiro e imprima a sequência Fibonacci até o valor lido. Por exemplo: caso o usuário insira o número 15, o programa deve imprimir na tela os números 0, 1, 1, 2, 3, 5, 8, 13.

int num, ant, prox;

Console.WriteLine("Informe um número: ");
num = Convert.ToInt32(Console.ReadLine());

ant = 0;
prox = 1;


Console.WriteLine("Sequência de Fibonacci: ");
Console.Write(ant + "\n");
for(int i = 0; prox <=  num; i ++){

    Console.WriteLine(prox + " ");
    int aux = ant + prox;
    ant = prox;
    prox = aux; 
}

 Console.WriteLine();
