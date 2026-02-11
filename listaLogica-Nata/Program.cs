// See https://aka.ms/new-console-template for more information

//Lista de Exercíco Logi
//Nivel 1: Varíaveis e Operações Básicas
#region 1. Calculadora de Média Simples
Console.WriteLine("--- Cálculo de Média ---");

Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4)/4;

Console.WriteLine($"Sua média é: {media:F1}");
Console.ReadKey();
#endregion
