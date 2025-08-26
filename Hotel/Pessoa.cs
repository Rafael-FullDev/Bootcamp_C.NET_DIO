using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void CadastrarHospedes()
        {
            Console.WriteLine("Digite o Nome do Hospede a ser cadastrado");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite o SobreNome do Hospede a ser cadastrado");
            var sobrenome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, sobrenome);
            Console.WriteLine($"O Hospede {nome} {sobrenome} foi registrado");
            
        }
    }
}
