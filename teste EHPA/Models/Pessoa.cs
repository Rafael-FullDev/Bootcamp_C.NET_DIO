namespace teste_EHPA.Models
{
    public class Pessoa
    {
        // abstração
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}
