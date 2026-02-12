// See https://aka.ms/new-console-template for more information

//Lista de Exercíco Logi
//Nivel 1: Varíaveis e Operações Básicas
#region 1. Calculadora de Média Simples
using System.Runtime.CompilerServices;

Console.WriteLine("--- Cálculo de Média ---");

Console.Write("Digite a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a quarta nota: ");
double nota4 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Sua média é: {media:F1}");
Console.ReadKey();
#endregion

// Converter Idade
#region 2. Conversor de Idade
Console.Write("Digite sua ideda: ");
int idade = Convert.ToInt16(Console.ReadLine());

int dias = (idade * 365);
Console.WriteLine($"Seu dia de nascido é: {dias}");
Console.ReadKey();

#endregion

// Troca de Valore

#region 3. Troca de valores
double variavelA = 5689;
double variavelB = 1023;

Console.WriteLine($"Antes da troca -> variavelB: {variavelB} variavelA: {variavelA}\n");

// Lógica de troca (Swap)
double variavelC = variavelA;
variavelA = variavelB;
variavelB = variavelC;

Console.WriteLine($"Depois da troca -> variavelB: {variavelB} variavelA: {variavelA}");

Console.ReadKey();
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

#region 2. Classificador de Número
Console.Write("Digite um numero: ");
double numero = Convert.ToDouble(Console.ReadLine());

if (numero == 0)
{
    Console.WriteLine("Zero");
}

else if (numero > 0 && numero % 2 == 0)
{
    Console.WriteLine("Par e positivo");
}
else if (numero > 0 && numero % 2 != 0)
{
    Console.WriteLine("Ímpar e positivo");
}
else
{
    Console.WriteLine("Negativo");
}
Console.ReadKey();
#endregion

#region

string user = "admin";
string password = "12345";

Console.Write("Digite o usuário: ");
string inputUser = Console.ReadLine();

Console.Write("Digite sua senha: ");
string inputPassword = Console.ReadLine();

if (inputUser == user && inputPassword == password)
{
    Console.WriteLine("Login efetuado com sucesso!");
}
else
{
    Console.WriteLine("Usuário ou senha inválidos.");
}

Console.ReadKey();

#endregion