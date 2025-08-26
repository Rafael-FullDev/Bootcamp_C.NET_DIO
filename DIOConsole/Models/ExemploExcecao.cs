using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOConsole.Models
{
    public class ExemploExcecao
    {
        public void metodo1()
        {
            try
            {
                metodo2();
            }
            catch(Exception e)
            {
                Console.WriteLine("Excessão tratada"+ e.Message);
            }
        }
        public void metodo2()
        {
            metodo3();
        }
        public void metodo3()
        {
            metodo4();
        }
        public void metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }

    }
}
