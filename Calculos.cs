using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    public class Retangulo
    {
        private int _largura;
        public int Altura { get; set; }
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
            Altura = alturaRetangulo;
        }
        public double CalcularArea()
        {
            return Largura * Altura;
        }
        public double CalcularPerimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }
        public double CalcularDiagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
    }
}
