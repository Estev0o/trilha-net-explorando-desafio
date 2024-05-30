using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "João Pedro Benitez");
Pessoa p2 = new Pessoa(nome: "Julia Almeida");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);


Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine("Nome dos hóspedes: ");
foreach (var hospede in hospedes)
{
    Console.WriteLine(hospede.Nome);
}
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");