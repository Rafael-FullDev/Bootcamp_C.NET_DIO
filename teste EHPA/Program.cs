using teste_EHPA.Models;

ContaCorrente conta = new ContaCorrente(1000.00m,1);

conta.VerConta();
conta.Sacar(500.00m);
conta.VerConta();
conta.Sacar(500.00m);
conta.VerConta();
conta.Sacar(500m);

// criação do objeto da classe de abstração
/*Pessoa pessoa = new Pessoa();
pessoa.Nome = "Rafael";
pessoa.Idade = 18;

pessoa.Apresentar();*/
