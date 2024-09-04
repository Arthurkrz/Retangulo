using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao calculador de retângulo!\n\nInsira, linha por linha, os valores da largura e altura:");
            int larguraRetangulo = int.Parse(Console.ReadLine());
            int alturaRetangulo = int.Parse(Console.ReadLine());
            Retangulo r = new Retangulo(larguraRetangulo, alturaRetangulo);
            Console.Clear();
            string diagonal = r.CalcularDiagonal().ToString("F2");
            Console.WriteLine($"Área - {r.CalcularArea()};\nPerímetro - {r.CalcularPerimetro()};\nDiagonal - {diagonal}.");
        }
    }
}
