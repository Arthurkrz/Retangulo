using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    public class Retangulo
    {
        public int largura;
        public int altura;
        public Retangulo(int larguraRetangulo, int alturaRetangulo)
        {
            largura = larguraRetangulo;
            altura = alturaRetangulo;
        }
        public double CalcularArea()
        {
            return largura * altura;
        }
        public double CalcularPerimetro()
        {
            return (largura * 2) + (altura * 2);
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
    }
}
