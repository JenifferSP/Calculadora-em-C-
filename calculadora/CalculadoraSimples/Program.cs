// See https://aka.ms/new-console-template for more information
double valor1, valor2, soma,
    subtracao, divisao, multi;
string nome;

Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();
Console.WriteLine("Bem vindo"+ " " + nome );

Console.WriteLine("Digite 2 valores para continuar - Adicione o 1º valor:");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Adicione o 2º valor:");
valor2 = Convert.ToDouble(Console.ReadLine());

soma = valor1 + valor2;
subtracao = valor1 - valor2;
divisao  = valor1 / valor2;
multi  = valor1 * valor2;

Console.WriteLine("A soma é:" + soma);
Console.WriteLine("A subtração é:" + subtracao);
Console.WriteLine("A divisão é:" + divisao);
Console.WriteLine("A multiplicação é:" + multi);

