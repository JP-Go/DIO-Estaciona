namespace Estaciomaneto.Models {

public class Estacionamento {

  private decimal PrecoInicial = 0;
  private decimal PrecoPorHora = 0;
  private List<string> Veiculos = new List<string>();

  public Estacionamento(decimal precoInicial, decimal precoPorHora) {
    this.PrecoInicial = precoInicial;
    this.PrecoPorHora = precoPorHora;
  }

  public void AdicionarVeiculo() {
    Console.WriteLine("Digite a placa do veículo para estacionar:");
    string? placa = Console.ReadLine();
    while (placa == "" || placa == null) {
      Console.WriteLine("Placa inválida. Digite uma placa válida:");
      placa = Console.ReadLine();
    }
    Veiculos.Add(placa);
  }
  public void RemoverVeiculo() {
    Console.WriteLine("Digite a placa do veículo para remover:");
    string? placa = Console.ReadLine();
    while (placa == "" || placa == null) {
      Console.WriteLine("Placa inválida. Digite uma placa válida:");
      placa = Console.ReadLine();
    }
    if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper())) {
      int indice =
          Veiculos.FindIndex(0, 1, x => x.ToUpper() == placa.ToUpper());
      Console.WriteLine(
          "Digite a quantidade de horas que o veículo permaneceu estacionado:");
      int horas = Convert.ToInt32(Console.ReadLine());
      decimal total = this.PrecoInicial + this.PrecoPorHora * horas;
      Veiculos.RemoveAt(indice);
      Console.WriteLine(
          $"Veículo {placa} removido com sucesso. Valor a pagar: R$ {Math.Round(total,2)}");
    } else {
      Console.WriteLine("Veículo não encontrado");
    }
  }
  public void ListarVeiculos() {
    if (Veiculos.Any()) {
      Console.WriteLine("Os veículos estacionados são:");
      foreach (string veiculo in Veiculos) {
        Console.WriteLine(veiculo);
      }
    } else {
      Console.WriteLine("Não há veículos estacionados.");
    }
  }
}
}
