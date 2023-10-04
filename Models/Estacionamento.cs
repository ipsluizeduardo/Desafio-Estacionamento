using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();

            if(veiculos.Contains(placa))
            {
                Console.WriteLine("Placa ja cadastrada!");
            }
            else if (String.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Invalido! digite corretamente a placa do veiculo para estacionar: ");
            }
            else 
            {
                veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo() 
        {   
            Console.WriteLine("Digite a placa do veiculo para remover: ");

            string placa = Console.ReadLine().ToUpper();

            if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
            Console.WriteLine("Digite a quantidade de horas aque o veiculo permaneceu estacionado: ");

            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = valorTotal = precoInicial + (precoPorHora * horas);

            veiculos.Remove(placa);

            Console.WriteLine($"O veiculo {placa} foi removido e o preco total foi de: R$ {valorTotal}");
            }
            else 
            {
                Console.WriteLine("Desculpe, essse veiculo não está estacionado aqui. Confira se digitou a plca corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if(veiculos.Any())
            {
                Console.WriteLine($"Os veiculos estacionados são: ");

                foreach(string item in veiculos)
                {
                    Console.WriteLine($"Placa: {item}");
                }
            }
            else 
            {
                Console.WriteLine("Não há veiculos estacionados.");
            }
        }

    }
}