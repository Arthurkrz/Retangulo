using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira o valor da largura do retângulo: ");
                dados.largura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor da altura do retângulo: ");
                dados.altura = double.Parse(Console.ReadLine());
                if (dados.largura != 0 && dados.altura != 0)
                {
                    CalculadoraArea.CalcularArea(dados);
                    CalculadoraPerimetro.CalcularPerimetro(dados);
                    CalculadoraDiagonal.CalcularDiagonal(dados);
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
            }
        }
    }
}
