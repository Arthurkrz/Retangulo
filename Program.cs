using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double largura;
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira o valor da largura do retângulo: ");
                largura = double.Parse(Console.ReadLine());
                Console.WriteLine("Insira o valor da altura do retângulo: ");
                altura = double.Parse(Console.ReadLine());
                if (largura != 0 && altura != 0)
                {
                    double area = (largura * altura);
                    Console.WriteLine($"A área é {area}.");
                    double perimetro = (altura + largura) * 2;
                    Console.WriteLine($"O perímetro é {perimetro}.");
                    double raizquadrada = Math.Sqrt((altura * altura) + (largura * largura));
                    Console.WriteLine($"A diagonal é {raizquadrada}.");
                    controle = false;
                }
            }
        }
    }
}