using System;

namespace GeneticAlgorithm_console
{
	public static class GAUtil
	{
		private static Random random;

		static GAUtil()
		{
			random = new Random();
		}

		public static void Crossover(Chromosome first, Chromosome second)
		{
			var cutPoint = random.Next(1, first.Size - 1);
			
			Console.WriteLine("\n*Crossover at: "+ cutPoint);
			Console.WriteLine("BEFORE:");
			Console.WriteLine(first.ToString());
			Console.WriteLine(second.ToString());

			for (int i = cutPoint; i < first.Size; i++)
			{
				bool temp = first[i];
				first[i] = second[i];
				second[i] = temp;
			}

			Console.WriteLine("AFTER:");
			Console.WriteLine(first.ToString());
			Console.WriteLine(second.ToString());
			Console.WriteLine("================");
		}

		public static void Mutation(Chromosome chromosome, double mutationRate)
		{
			for (int i = 0; i < chromosome.Size; i++)
			{
				if (random.NextDouble() >= mutationRate)
				{
					chromosome[i] = random.NextDouble() > 0.5;
				}
			}
		}
	}
}