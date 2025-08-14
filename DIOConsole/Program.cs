using DIOConsole.Models;
using System.Globalization;

/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa pessoa1 = new Pessoa(nome: "Rafael", sobrenome: "ferreira", 18);

Pessoa pessoa2 = new Pessoa(nome: "Rafaela", sobrenome: "borges", 50);

Curso Ingles = new Curso();
Ingles.Nome = "Ingles";
Ingles.Alunos = new List<Pessoa>();

Ingles.AdicionarAluno(pessoa1);
Ingles.AdicionarAluno(pessoa2);
Ingles.ListarAlunos();*/



// numero monetario com culture Info apenas para o console
/*decimal numero = 82.40m;

Console.WriteLine($"{numero:C2}", CultureInfo.CreateSpecificCulture("en-US"));*/

//numero em porcentagem
/*double porcentagem = .1234;

Console.WriteLine($"{porcentagem.ToString("p")}");*/

// alocando numero com cerquilha
/*int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));*/

// datetime
/*DateTime dataHora = DateTime.Now;
Console.WriteLine(dataHora.ToString("dd-MM-yyyy HH:mm"));*/

// parse normal
/*DateTime dataHora = DateTime.Parse("17/04/2025 18:00");
Console.WriteLine(dataHora);*/

/*//tryparse
string dataHora = "2024-07-27 18:38";

bool sucesso = DateTime.TryParseExact(dataHora,
    "yyyy-MM-dd HH:mm",
    CultureInfo.InvariantCulture,
    DateTimeStyles.None,
    out DateTime data);

if (sucesso) { 
Console.WriteLine(data);
}
else
{
    Console.WriteLine($"{data} não é uma datavalida");
}*/
/*decimal num = 10;

float.TryParse(num, out float numero);*/


/*Calculadora calc = new Calculadora();
calc.somar(10, 2);
calc.subtrair(10, 2);
calc.multiplicar(10, 2);
calc.dividir(10, 2);
calc.potenciar(200, 100);
calc.seno(30);
calc.coseno(30);
calc.tangente(30);*/

// Ler arquivos

string[] linhas = File.ReadAllLines("../../../Arquivos/LerTexto.txt");

foreach(string linha in linhas)
{
    Console.Write(linha);
}