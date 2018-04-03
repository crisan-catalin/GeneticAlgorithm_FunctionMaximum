using System;
using System.Collections.Generic;
using FunctionMaximum.Core;

namespace FunctionMaximum.Core
{
	public static class GAUtil
	{
		private static Random random;

		static GAUtil()
		{
			random = new Random();
		}

		public static void Crossover(Chromosome first, Chromosome second, int cutPoints)
		{
			var numberOfCutPoints = random.Next(1, cutPoints);
			List<int> randomCutPoints = new List<int>(numberOfCutPoints);
			do
			{
				var point = random.Next(1, first.Size);
				if (!randomCutPoints.Contains(point))
				{
					randomCutPoints.Add(point);
				}
			} while (randomCutPoints.Count == numberOfCutPoints);
			randomCutPoints.Sort();

			for (int i = 0; i < randomCutPoints.Count; i += 2)
			{
				var lastIndex = randomCutPoints.Count > i + 1 ? randomCutPoints[i + 1] : first.Size;
				for (int j = randomCutPoints[i]; j < lastIndex; j++)
				{
					bool temp = first[j];
					first[j] = second[j];
					second[j] = temp;
				}
			}
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