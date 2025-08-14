namespace DIOConsole.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
        }

        public int ContarAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool DeletarAluno(Pessoa Aluno) => Alunos.Remove(Aluno);

        public void ListarAlunos()
        {
            Console.WriteLine($"Nome do Curso: {Nome}");
            for(int cont = 0; cont < Alunos.Count; cont++)
            {
                string texto = $"N° {cont + 1} - {Alunos[cont].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }

    }
}
