using System;

namespace Retangulo
{
	public class CalculadoraPerimetro
	{
		public static double CalcularPerimetro(Dados dados)
		{
			double perimetro = (dados.altura + dados.largura) * 2;
			Console.WriteLine($"O perímetro é {perimetro}");
			return perimetro;
		}
	}
}