using Internal;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("===================[Seja Bem vindo a empresa Lina]======================");



do{
Console.WriteLine("""
O que você deseja fazer ?
1 - Cadastrar o cliente
2 - Ver conta corrente
3 - Fazer credito em conta
4 - Fazer débito em conta
5 - Sair do sistema
""");

string opcao = Console.ReadLine()?.Trim();
Console.Clear();

bool sair = false;

switch(opcao)
{
    case "1":
    Console.WriteLine("Cadastro de Cliente");
    List<string> cadastro = 
    Console.clear();
    break;

    case "2":
    Console.Clear();
    break;

    case "3":
    Console.Clear();

    case "4":
    Console.Clear();
    break;

    case "5":
    sair = true;
    Console.Clear();
    break;
}

}while(sair == false);



