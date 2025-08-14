using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIOConsole.Models
{
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public void somar(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        }

        public void subtrair(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 - n2}");
        }

        public void multiplicar(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 * n2}");
        }

        public void dividir(int n1, int n2)
        {
            Console.WriteLine($"{n1} + {n2} = {n1 / n2}");
        }

        public void potenciar(int n1, int n2)
        {
            double potencia = Math.Pow(n1,n2);
            Console.WriteLine($"{n1} ^ {n2} = {potencia}");
        }
        public void seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"o seno de: {angulo} é igual {Math.Round(seno,4)}");
        }
        public void coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"o seno de: {angulo} é igual {Math.Round(coseno, 4)}");
        }
        public void tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"o seno de: {angulo} é igual {Math.Round(tangente, 4)}");
        }
    }
}
