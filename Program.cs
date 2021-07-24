using System;

namespace Fbs
{
	class Program
	{
		static void Main(string[] args)
		{

			int x = 0;
			int y = 1;
			int z;
			int contador = 0;
			for (contador = 0; contador < 100; contador++)
			{
				z = x + y;
				y = x;
				x = z;
				Console.WriteLine(z);

				contador++;
			}
			
		}
	}
}
