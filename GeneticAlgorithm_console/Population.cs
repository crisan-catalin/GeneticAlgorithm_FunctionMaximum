using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GeneticAlgorithm_console
{
	public class Population
	{
		private static int generation = 1;
		private Random random;
		private const int NumEliteChromosomes = 2;
		private const double MutationRate = 0.1;

		public List<Chromosome> _population;

		public Int32 Size
		{
			get { return _population.Count; }
		}

		public Int32 ChromosomeSize { get; set; }

		public Population(int size, int chromosomeSize)
		{
			random = new Random();
			_population = new List<Chromosome>(size);
			ChromosomeSize = chromosomeSize;
			for (int i = 0; i < size; i++)
			{
				_population.Add(new Chromosome(chromosomeSize, random));
			}

//			SortPopulation();
		}

		public Double BestSolution(out Double value)
		{
			List<Chromosome> temp = _population.ToList();
			temp.Sort();
			value = temp[0].Value;
			return temp[0].Fitness;
		}

		public Chromosome RouletteWheel()
		{
			var populationFitness = GetPopulationFitness();
			var randomFitness = random.Next(0, populationFitness);

			double partialSum = 0;
			for (int i = 0; i < _population.Count; i++)
			{
				partialSum += _population[i].Fitness;
				if (partialSum > randomFitness)
				{
					return _population[i];
				}
			}
			return null;
		}

		private void CalculateExpectedCount()
		{
			var populationFitness = GetPopulationFitness();

			for (int i = 0; i < _population.Count; i++)
			{
				_population[i].ExpectedCount = _population[i].Fitness / (populationFitness / _population.Count);
			}
		}

		private void CalculatePropabilityOfSelection()
		{
			var populationFitness = GetPopulationFitness();

			for (int i = 0; i < _population.Count; i++)
			{
				_population[i].ProbabilityOfSelection = _population[i].Fitness / populationFitness;
			}
		}

		private int GetPopulationFitness()
		{
			int result = 0;
			foreach (var chromosome in _population)
			{
				result += chromosome.Fitness;
			}
			return result;
		}

		private void ShowOldGeneration()
		{
			Console.WriteLine("GENERATION #" + generation);
			foreach (var chromosome in _population)
			{
				Console.WriteLine(chromosome.ToString());
			}
			generation++;
		}

		public void Evolve()
		{
			ShowOldGeneration();

			List<Chromosome> springs = new List<Chromosome>(_population.Count);
			for (int i = 0; i < _population.Count; i++)
			{
				springs.Add(RouletteWheel());
			}

			for (int i = 0; i < springs.Count; i += 2)
			{
				GAUtil.Crossover(springs[i], springs[i + 1]);
			}

			_population = springs;
		}
	}
}