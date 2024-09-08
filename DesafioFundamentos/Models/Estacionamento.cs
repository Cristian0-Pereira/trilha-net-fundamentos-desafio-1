
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private decimal totalDiario = 0;
        public static List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            // Verifica se o veículo já contém
            if (!veiculos.Any(x => x == placa))
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículos adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo já adicionado.");
            }
        }

        public void RemoverVeiculo()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    // Para mostrar os veículos cadastrados antes de remover
                    Console.WriteLine(veiculo.ToUpper());
                }
                Console.WriteLine("Digite a placa do veículo para remover:");
                // Pedir para o usuário digitar a placa e armazenar na variável placa
                string placa = Console.ReadLine();
                // Verifica se o veículo existe
                if (veiculos.Any(x => x == placa))
                {
                    veiculos.Remove(placa); // Para remover a placa digitada da lista de veículos

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");             
                    
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    totalDiario += valorTotal; // Para calcular o total diário


                    Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal:f2}");
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else{
                Console.WriteLine("Não há veículos estacionados ainda!");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
        public void ExibirTotalDiario()
        {
            Console.WriteLine($"Total diário R$ {totalDiario:f2}");
        }
    }
}
