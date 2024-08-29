using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao calculador de retângulo!\n\nInsira, linha por linha, os valores da largura e altura:");
            int largura = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());
            Calculos r = new Calculos(largura, altura);
            Console.Clear();
            string diagonal = r.CalcularDiagonal(largura, altura).ToString("F2");
            Console.WriteLine($"Área - {r.CalcularArea(largura, altura)};\nPerímetro - {r.CalcularPerimetro(largura, altura)};\nDiagonal - {diagonal}.");
        }
    }
}
