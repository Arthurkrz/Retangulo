using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    public class Calculos
    {
        public int largura;
        public int altura;
        public double CalcularArea(int largura, int altura)
        {
            return largura * altura;
        }
        public double CalcularPerimetro(int largura, int altura)
        {
            return (largura * 2) + (altura * 2);
        }
        public double CalcularDiagonal(int largura, int altura)
        {
            return Math.Sqrt((largura * largura) + (altura * altura));
        }
        public Calculos(int l, int a)
        {
            l = largura;
            a = altura;
        }
    }
}
