using System;

namespace Retangulo
{
    public class DadosRetangulo
    {
        public double Altura;
        public double Largura;
        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return Altura + Largura * 2;
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }
    }
}
