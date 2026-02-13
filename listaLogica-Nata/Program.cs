// See https://aka.ms/new-console-template for more information

//Lista de Exercíco Logi
//Nivel 1: Varíaveis e Operações Básicas
#region 1. Calculadora de Média Simples
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

//Console.WriteLine($"Sua média é: {media:F2}\n");
//Console.ReadKey();
#endregion
#region 2. Conversor de Idade
//Console.Write("Digite sua ideda: ");
//int idade = Convert.ToInt16(Console.ReadLine());

//int dias = (idade * 365);
//Console.WriteLine($"Seus dias de nascido são: {dias}\n");
//Console.ReadKey();

#endregion
#region 3. Troca de valores
//double variavelA = 5689;
//double variavelB = 1023;

//Console.WriteLine($"Antes da troca -> variavelB: {variavelB} variavelA: {variavelA}\n");

//// Lógica de troca (Swap)
//double variavelC = variavelA;
//variavelA = variavelB;
//variavelB = variavelC;

//Console.WriteLine($"Depois da troca -> variavelB: {variavelB} variavelA: {variavelA}\n");

//Console.ReadKey();
#endregion


//Nivel 2: Estruturas Condicionais (if, else if, else)
#region 1: Verificador de Maioridade
//Console.Write("Digite sua ideda: ");
//int idade1 = Convert.ToInt16(Console.ReadLine());

//if (idade1 >= 18)
//{
//    Console.WriteLine("Entrado autorisada\n");
//}
//else
//{
//    Console.WriteLine("Entrada não autorisada\n");
//}
//Console.ReadKey();
#endregion
#region 2. Classificador de Número
//Console.Write("Digite um numero: ");
//double numero = Convert.ToDouble(Console.ReadLine());

//if (numero == 0)
//{
//    Console.WriteLine("Zero\n");
//}

//else if (numero > 0 && numero % 2 == 0)
//{
//    Console.WriteLine("Par e positivo\n");
//}
//else if (numero > 0 && numero % 2 != 0)
//{
//    Console.WriteLine("Ímpar e positivo\n");
//}
//else
//{
//    Console.WriteLine("Negativo\n");
//}
//    Console.ReadKey();
#endregion
#region 3. Validação de login simples

//string user = "admin";
//string password = "12345";

//Console.Write("Digite o usuário: ");
//string inputUser = Console.ReadLine();

//Console.Write("Digite sua senha: ");
//string inputPassword = Console.ReadLine();

//if (inputUser == user && inputPassword == password)
//{
//    Console.WriteLine("Login efetuado com sucesso!\n");
//}
//else
//{
//    Console.WriteLine("Usuário ou senha inválidos.\n");
//}

//Console.ReadKey();

#endregion

// Nível 3: Estruturas de Repetição (Loops)
#region 1. Contagem Regressiva

//Console.WriteLine("Aperte Enter para iniciar");
//Console.ReadLine();

//for (int i = 10 ; i >= 1; i--)
//{
//    Console.WriteLine(i);
//    Thread.Sleep(1000);
//}

//Console.WriteLine("Lançar\n");
//Console.ReadKey();

#endregion
#region 2. Soma de ímpares(Loop While)

//int soma = 0;
//int numero3 = -1;
//Console.WriteLine("Digite números inteiros (digite 0 para ver o total e sair):");

//while (numero3 != 0)
//{
//    Console.Write("Digite um número: ");
//    numero = Convert.ToInt32(Console.ReadLine());

//    if (numero3 % 2 != 0)
//    {
//        soma += numero3;
//    }
//}

//Console.WriteLine("-------------------------------------------------------");
//Console.WriteLine($"A soma total dos números ímpares digitados é: {soma}");
//Console.WriteLine("-------------------------------------------------------\n");
//Console.ReadKey();
#endregion

#region 3. Tabuada Personalizada

Console.WriteLine("Digite um numero");
int numero4 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int tabuada = numero4 * i;
    Console.WriteLine($"{numero4} x {i} = {tabuada}");
}
#endregion

