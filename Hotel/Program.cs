using Hotel;

List<Pessoa> pessoas;
List<Suite> suite1 = new List<Suite>();

Console.WriteLine("Seja bem vindo ao hotel!");
Console.Write("Digite quantos dias o cliente ira ficar no hotel: ");
string dias = Console.ReadLine();
var Bdias = int.TryParse(dias, out int IDias) ? IDias : throw new Exception("Valor invalido");
Reserva reserva = new Reserva();

string laco = "s";
string opcao;
while (laco == "s")
{
    Console.Write("A seguir em nosso cardapio " +
        "\n1 - Cadastro de Hospedes" +
        "\n2 - Cadastro de Suites" +
        "\n3 - Quantidade de Hospedes" +
        "\n4 - Valor da diaria" +
        "\n5 - encerrar" +
        "\n \n qual opção deseja? ");
    opcao = Console.ReadLine();
    var BOpcao = int.TryParse(opcao, out int IOpcao) ? IOpcao : throw new Exception("Valor Invalido");
    switch (BOpcao)
    {
        case (int)OpcoesEnum.CadastrarHospedes:
            reserva.Pessoas = new List<Pessoa>();
            reserva.CadastrarHospedes();
            break;
        case (int)OpcoesEnum.CadastrarSuites:
            var suite = reserva.CadastrarSuite(Bdias);
            suite1.Add(suite);
            reserva.Suites = suite;
            break;
        case (int)OpcoesEnum.ObterQuantidadDeHospedes:
            var cont = reserva.ObterQuantidadeHospedes();
            Console.WriteLine(cont);
            break;
        case (int)OpcoesEnum.ValorDaDiaria:
            var cont1 = reserva.CalcularValorDiaria(reserva.Suites.ValorDiaria, Bdias);
            Console.WriteLine(cont1);
            break;
        case (int)OpcoesEnum.Encerrar:
            Console.WriteLine("Programa encerrado!");
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
    Console.Write("Deseja continuar? ");
    laco = Console.ReadLine();
}
Console.WriteLine("Obrigado por se hospedar em meu hotel, até logo!");