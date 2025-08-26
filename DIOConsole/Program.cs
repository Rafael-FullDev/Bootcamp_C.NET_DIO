using DIOConsole.Models;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Text.Json.Serialization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa pessoa1 = new Pessoa(nome: "Rafael", sobrenome: "ferreira", 18, DateTime.Now);

Pessoa pessoa2 = new Pessoa(nome: "Rafaela", sobrenome: "borges", 50, DateTime.Now);

Curso Ingles = new Curso();
Ingles.Nome = "Ingles";
Ingles.Alunos = new List<Pessoa>();

Ingles.AdicionarAluno(pessoa1);
Ingles.AdicionarAluno(pessoa2);
Ingles.ListarAlunos();



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

// Ler arquivos com tratamento de erro try catch expecifico e generico
/*try
{
    string[] linhas = File.ReadAllLines("../../../Arquivos/LerTexto.txt");

    foreach (string linha in linhas)
    {
        Console.Write(linha);
    }
}
catch (FileNotFoundException f)
{
    Console.WriteLine($"Ocorreu uma excessão, arquivo não encontrado. {f.Message}");
}
catch (Exception e)
{
    Console.WriteLine($"Ocorreu uma excessão do tipo genérica. {e.Message}");
}
*/


// queue(fila) na pratica primeiro a entrar primeiro a sair 
/*Queue<int> fila = new Queue<int>();

fila.Enqueue(20);
fila.Enqueue(10);
fila.Enqueue(30);
fila.Enqueue(100);

foreach(int cont in fila)
{
    Console.WriteLine(cont);
}

fila.Dequeue();

fila.Enqueue(40);

foreach (int cont in fila)
{
    Console.WriteLine(cont);
}*/


// Stack(pilha) na pratica primeiro a entrar ultimo a sair
/*Stack<int> fila = new Stack<int>();

fila.Push(20);
fila.Push(10);
fila.Push(30);
fila.Push(100);

foreach (int cont in fila)
{
    Console.WriteLine(cont);
}

fila.Pop();

fila.Push(40);

foreach (int cont in fila)
{
    Console.WriteLine(cont);
}*/

// dictionary(dicionario) tipo de lista em que os elementos sao achados por uma chave/id
/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "sao paulo");
estados.Add("MG", "Queijo");
estados.Add("RJ", "Rio de Tiroteio");
foreach (var cont in estados)
{
    Console.WriteLine(cont.Key);
}
estados.Add("BH", "sao paulo");
estados.Remove("RJ");
estados["BH"] = "Bahia";

string chave = "RJ";

if (estados.ContainsKey(chave))
{
    Console.WriteLine("Achou");
}
else
{
    Console.WriteLine("Não achou");

}*/


// tupla adequada por poder dar nome
/*(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Rafael", "ferreira", 10.5m);

Console.WriteLine(tupla.Id);
Console.WriteLine(tupla.Nome);
Console.WriteLine(tupla.Sobrenome);
Console.WriteLine(tupla.Altura);
*/

// forma valuetuple menos adequado por nao conseguir atribuir nome
/*ValueTuple<int, string, string, decimal> tupla1 = (1, "Rafael", "ferreira", 10.5m);
Console.WriteLine(tupla1.Item1);
Console.WriteLine(tupla1.Item2);
Console.WriteLine(tupla1.Item3);
Console.WriteLine(tupla1.Item4);*/

// forma de variavel onde encontra o tipo da variavel altomaticamente(nao tipada)
/*var tupla2 = Tuple.Create(1, "rafael", "ferreira", 10.5m);

Console.WriteLine(tupla2.Item1);
Console.WriteLine(tupla2.Item2);
Console.WriteLine(tupla2.Item3);
Console.WriteLine(tupla2.Item4);

int i = 0;*/

/*List<Pessoa> pessoas = new List<Pessoa>();

DateTime agora = DateTime.Now;*/

/*Pessoa pessoa1 = new Pessoa("rafael", "ferreira", 18, agora);
Pessoa pessoa2 = new Pessoa("rafaela", "ferreiro", 19, agora);
Pessoa pessoa3 = new Pessoa("rafaele", "ferreire", 20, agora);

pessoas.Add(pessoa1);
pessoas.Add(pessoa2);
pessoas.Add(pessoa3);


string serializado = JsonConvert.SerializeObject(pessoas, Formatting.Indented);

Console.WriteLine(serializado);

File.WriteAllText("../../../Arquivos/Pessoa.json", serializado);*/

/*string Desserializado = File.ReadAllText("../../../Arquivos/Pessoa.json");

List<Pessoa> pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(Desserializado);

foreach(Pessoa pessoa in pessoas)
{
    Console.WriteLine($"Nome: {pessoa.Nome} SobreNome: {pessoa.Sobrenome} Idade: {pessoa.Idade} Data: {pessoa.Data}");
}*/