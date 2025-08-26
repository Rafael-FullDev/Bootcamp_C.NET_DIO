using System.Text.RegularExpressions;

namespace Hotel
{
    public class Reserva
    {
        public  List<Pessoa> Pessoas { get; set; }
        public  Suite Suites { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
            
        }
        public Reserva(List<Pessoa> pessoas, Suite suites, int diasReservados)
        {
            this.Pessoas = pessoas;
            this.Suites = suites;
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes()
        {
            Console.WriteLine("Digite o Nome do Hospede a ser cadastrado");
            var nome = Console.ReadLine();
            var sobrenome1 = Regex.IsMatch(nome, @"^[A-Za-z]+$") ? nome : throw new Exception("Não e permitido numeros ou caracteres especiais");

            Console.WriteLine("Digite o SobreNome do Hospede a ser cadastrado");
            var sobrenome = Console.ReadLine();
            var nome1 = Regex.IsMatch(sobrenome, @"^[A-Za-z]+$") ? sobrenome : throw new Exception("Não e permitido numeros ou caracteres especiais");

            Pessoa pessoa = new Pessoa(nome1, sobrenome1);
            Console.WriteLine($"O Hospede {nome} {sobrenome} foi registrado");
            Pessoas.Add(pessoa);
        }

        public Suite CadastrarSuite(int dias)
        {
            Console.WriteLine("Digite o Tipo da Suite a ser cadastrada");
            var tipo = Console.ReadLine();
            var Rtipo = Regex.IsMatch(tipo, @"^[A-Za-z]+$") ? tipo : throw new Exception("Não e permitido numeros ou caracteres especiais");

            Console.WriteLine("Digite o valor da Suite a ser cadastrada");
            var valor = Console.ReadLine();
            var Rvalor = Regex.IsMatch(valor, @"^\d+$") ? valor : throw new Exception("Não e permitido numeros ou caracteres especiais");

            var sucesso = decimal.TryParse(valor, out decimal resultado) ? resultado : throw new Exception("Valor invalido, por favor informe um valor valido");
            Console.WriteLine("Digite a capacidade da Suite a ser cadastrada");
            var capacidade = Console.ReadLine();
            var DRegex = Regex.IsMatch(capacidade, @"^\d+([.,]\d+)?$") ? capacidade : throw new Exception("Não e permitido numeros ou caracteres especiais");
            var Bcapacidade = int.TryParse(DRegex, out int Tcapacidade) ? Tcapacidade : throw new Exception("Valor invalido, por favor informe um valor valido");


            Suite suite = new Suite(tipo, Bcapacidade, resultado);
            Console.WriteLine($"A suite {tipo} na capacidade de {capacidade} e valor de {resultado} foi registrada");

            CalcularValorDiaria(sucesso, dias);

            return suite;
        }

        public int ObterQuantidadeHospedes() => Pessoas.Count();

        public decimal CalcularValorDiaria(decimal sucesso, int dias)
        {
            var diaria = sucesso * dias;
            return diaria;
        }
    }
}