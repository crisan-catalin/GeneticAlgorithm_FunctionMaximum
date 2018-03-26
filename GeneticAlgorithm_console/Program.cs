using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm_console
{
	class Program
	{
		static void Main(string[] args)
		{
			Population p = new Population(4, 6);

			Double bestValue;
			Double bestSolution = p.BestSolution(out bestValue);

			for(int i =0;i<100;i++)
			{
				Console.WriteLine("Best solution: " + bestSolution);
				Console.WriteLine("        Value: " + bestValue);
				p.Evolve();
				Double newValue;
				Double newSolution = p.BestSolution(out newValue);
				if (bestSolution > newSolution)
				{
//					break;
				}
				else
				{
					bestSolution = newSolution;
					bestValue = newValue;
				}
			}
		}
	}
}