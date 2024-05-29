using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1__.NET.commom.Models
{
    public class PessoaFisica
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        private List<string> veiculos = new List<string>();

        public void Apreseentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, Tenho {Idade} anos de idade.");
        }//public void Apreseentar()

         public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);

        }//public void AdicionarVeiculo()

        public void Lista()
        {
            foreach (string placa in veiculos)
            {
                Console.WriteLine(placa.ToUpper());
            }
        }

    }//public class PessoaFisica
}