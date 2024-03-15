using System;

namespace Retangulo
{
    public class CalculadoraDiagonal
    {
        public static double CalcularDiagonal(Dados dados)
        {
            double raizquadrada = Math.Sqrt((dados.altura * dados.altura) + (dados.largura * dados.largura));
            Console.WriteLine($"A Diagonal é {raizquadrada}");
            return raizquadrada;
        }
    }
}
