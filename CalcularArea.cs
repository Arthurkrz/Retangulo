using System;

namespace Retangulo
{
    public class CalculadoraArea
    {
        public static double CalcularArea(Dados dados)
        {
            double area = (dados.largura * dados.altura);
            Console.WriteLine($"A área é {area}");
            return area;
        }
    }
}
