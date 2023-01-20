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
2 - Ver conta corrente
3 - Fazer credito em conta
4 - Fazer débito em conta
5 - Sair do sistema
""");

string opcao = Console.ReadLine()?.Trim();
Console.Clear();


List<string> global = new List<string>();

switch(opcao)
{
    case "1":

    Console.WriteLine("===========Cadastro do Cliente============");
    
    List<string> cadastro = new List<string>();
    var id = Guid.NewGuid();
    Console.WriteLine("000 GUID " + id);

    Console.WriteLine("Digite seu Nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine($"Digite seu Telefone {nome}");
    string Tel = Console.ReadLine();

    Console.WriteLine($"Digite seu E-mail {nome}");
    string email = Console.ReadLine();

    cadastro.Add(id.ToString());
    cadastro.Add(nome);
    cadastro.Add(Tel);
    cadastro.Add(email);

    global.Add(cadastro.ToString());

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
    sair = true;
    Console.Clear();
    break;
}

}while(sair =! false);



