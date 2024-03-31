using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosRetangulo dadosretangulo = new DadosRetangulo();
            {
                Console.WriteLine("Insira o valor da largura do retângulo: ");
                dadosretangulo.Largura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor da altura do retângulo: ");
                dadosretangulo.Altura = double.Parse(Console.ReadLine());
                if (dadosretangulo.Largura != 0 && dadosretangulo.Altura != 0)
                {
                    double area = dadosretangulo.CalcularArea();
                    double perimetro = dadosretangulo.CalcularPerimetro();
                    double diagonal = dadosretangulo.CalcularDiagonal();
                    Console.WriteLine($"A área do retângulo é {area} \n O perímetro do retângulo é {perimetro} \n A diagonal do retângulo é {diagonal}");
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
            }
        }
    }
}
