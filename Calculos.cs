using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    public class Retangulo
    {
        private int _largura;
        public int altura;
        public int Largura
        {
            get
            {
                return _largura;
            }
            set
            {
                if (value > 0)
                {
                    _largura = value;
                }
            }
        }
        public Retangulo(int larguraRetangulo, int alturaRetangulo)
        {
            Largura = larguraRetangulo;
            altura = alturaRetangulo;
        }
        public double CalcularArea()
        {
            return Largura * altura;
        }
        public double CalcularPerimetro()
        {
            return (Largura * 2) + (altura * 2);
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (altura * altura));
        }
    }
}
