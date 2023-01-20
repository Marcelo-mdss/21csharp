using System.Collections.Specialized;
using System.ComponentModel;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("===================[Seja Bem vindo a empresa Lina]======================");
bool sair = false;
do{
Console.WriteLine("""
O que você deseja fazer ?
1 - Cadastrar o cliente
2 - Mostrar Cadastro
3 - Ver conta corrente
4 - Fazer credito em conta
5 - Fazer débito em conta
6 - Sair do sistema
""");

string? opcao = Console.ReadLine()?.Trim();
Console.Clear();


List<string[]> global = new List<string[]>();

switch(opcao)
{
    case "1":

    Console.WriteLine("===========Cadastro do Cliente============");
    
    string[] cadastro = new string[4];
    var id = Guid.NewGuid();
    Console.WriteLine("000 GUID " + id);

    Console.WriteLine("Digite seu Nome: ");
    string? nome = Console.ReadLine();

    Console.WriteLine($"Digite seu Telefone {nome}");
    string? Tel = Console.ReadLine();

    Console.WriteLine($"Digite seu E-mail {nome}");
    string? email = Console.ReadLine();

    cadastro[0] = id.ToString();
    cadastro[1] = nome ?? "[Sem Nome]" ;
    cadastro[2] = Tel ?? "[Sem Telefone]";
    cadastro[3] = email ?? "[Sem email]";

    global.Add(cadastro);

    Console.Clear();
    break;

    case "2":
    Console.WriteLine(global);
    Console.Clear();
    break;

    case "3":
    Console.Clear();
    break;

    case "4":
    Console.Clear();
    break;

    case "5":

    break;

    case "6":
    sair = true;
    Console.Clear();
    break;


}

}while(sair == true);



