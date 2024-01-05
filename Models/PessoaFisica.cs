using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1__.NET.Models
{
    public class PessoaFisica
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apreseentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, Tenho {Idade} anos de idade.");
        }//public void Apreseentar()
    }//public class PessoaFisica
}