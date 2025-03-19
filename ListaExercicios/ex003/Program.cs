// Receber dois números inteiros e informar qual valor lido é o menor e qual é o maior.

int n1, n2;

Console.WriteLine("Informe um número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe um número: ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2){
    Console.WriteLine($"{n1} é maior e {n2} é menor.");
}
else if(n2 > n1){
    Console.WriteLine($"{n2} é maior e {n1} é menor.");
}
else{
    Console.WriteLine("Os números são iguais.");
}