// See https://aka.ms/new-console-template for more information
using Estaciomaneto.Models;

void imprimirMenu() {
  Console.Clear();
  Console.WriteLine("1 - Adicionar Veículo");
  Console.WriteLine("2 - Remover Veículo");
  Console.WriteLine("3 - Listar Veículos");
  Console.WriteLine("4 - Fechar");
}

decimal precoInicial = 0;
decimal precoPorHora = 0;
bool deveFechar = false;

Console.WriteLine("Bem vindo ao Estaciona, o sistema de estacionamentos");
Console.WriteLine("Qual o preço inicial?");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Qual o preço por hora?");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

while (!deveFechar) {

  imprimirMenu();
  int opcao = Convert.ToInt32(Console.ReadLine());

  switch (opcao) {
  case 1:
    es.AdicionarVeiculo();
    break;
  case 2:
    es.RemoverVeiculo();
    break;
  case 3:
    es.ListarVeiculos();
    break;
  case 4:
    deveFechar = true;
    Console.WriteLine("Fechando...");
    break;
  default:
    Console.WriteLine("Opção Inválida");
    break;
  }
  Console.WriteLine("Pressione uma tecla para continuar");
  Console.ReadLine();
}

Console.WriteLine("Até mais!");
