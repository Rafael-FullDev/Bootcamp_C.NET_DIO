namespace DIOConsole.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa(string nome, string sobrenome, int idade)
        {
            Sobrenome = sobrenome;
            Nome = nome;
            Idade = idade;
        }

        public string Sobrenome { get; set; }

        public string Nome {
            get => _nome;
            

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        public int Idade {

            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");

                    
                }
                _idade = value;
            } 
        
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public void Apresentar()
        {
            Console.WriteLine($"Nome:{NomeCompleto}, Idade:{Idade}");
        }


    }
}