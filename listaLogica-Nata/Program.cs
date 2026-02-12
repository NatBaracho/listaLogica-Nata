// See https://aka.ms/new-console-template for more information

//Lista de Exercíco Logi
//Nivel 1: Varíaveis e Operações Básicas
#region 1. Calculadora de Média Simples
using System.ComponentModel.Design;

//Console.WriteLine("--- Cálculo de Média ---");

//Console.Write("Digite a primeira nota: ");
//double nota1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite a segunda nota: ");
//double nota2 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite a terceira nota: ");
//double nota3 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite a quarta nota: ");
//double nota4 = Convert.ToDouble(Console.ReadLine());

//double media = (nota1 + nota2 + nota3 + nota4) / 4;

//Console.WriteLine($"Sua média é: {media:F1}");
//Console.ReadKey();
#endregion

// Converter Idade
#region 2. Conversor de Idade
//Console.Write("Digite sua ideda: ");
//int idade = Convert.ToInt16(Console.ReadLine());

//int dias = (idade * 365);
//Console.WriteLine($"Seu dia de nascido é: {dias}");
//Console.ReadKey();

#endregion

// Troca de Valore

#region 3. Troca de valores
//double variavelA = 5689;
//double variavelB = 1023;

//Console.WriteLine($"Antes da troca -> variavelB: {variavelB} variavelA: {variavelA}\n");

//// Lógica de troca (Swap)
//double variavelC = variavelA; 
//variavelA = variavelB;        
//variavelB = variavelC;       

//Console.WriteLine($"Depois da troca -> variavelB: {variavelB} variavelA: {variavelA}");

//Console.ReadKey();
#endregion


//Nivel 2: Estruturas Condicionais (if, else if, else)
#region 1: Verificador de Maioridade
Console.Write("Digite sua ideda: ");
int idade1 = Convert.ToInt16(Console.ReadLine());

if (idade1 >= 18)
{
    Console.WriteLine("Entrado autorisada");
}
else
{
    Console.WriteLine("Entrada não autorisada");
}
Console.ReadKey();
#endregion