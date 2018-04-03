using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionMaximum.Core
{
	public class Population
	{
		private static int _generation = 1;
		private readonly Random _random;
		private readonly int _elitism;
		private int _cutPoints;
		private readonly double _mutationRate;

		public List<Chromosome> _population;

		public int Size => _population.Count;

		public int ChromosomeSize { get; set; }

		public Population(int size, int chromosomeSize, int elitism, int crossOverCutPoints, double mutationRate)
		{
			_random = new Random();
			_population = new List<Chromosome>(size);
			ChromosomeSize = chromosomeSize;
			for (int i = 0; i < size; i++)
			{
				_population.Add(new Chromosome(chromosomeSize, _random));
			}

			_elitism = elitism;
			_cutPoints = crossOverCutPoints;
			_mutationRate = mutationRate;
		}

		public double BestSolution(out double value)
		{
			List<Chromosome> temp = _population.ToList();
			temp.Sort();
			value = temp[0].Value;
			return temp[0].Fitness;
		}

		public Chromosome RouletteWheel()
		{
			var populationFitness = GetPopulationFitness();
			var randomFitness = _random.Next(0, populationFitness);

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
			Console.WriteLine("GENERATION #" + _generation);
			foreach (var chromosome in _population)
			{
				Console.WriteLine(chromosome.ToString());
			}
			_generation++;
		}

		private void Shuffle()
		{
			int size = _population.Count;
			for (int i = 0; i < size - 1; i++)
			{
				int randomIndex = _random.Next(i, size);
				var temp = _population[i];
				_population[i] = _population[randomIndex];
				_population[randomIndex] = temp;
			}
		}

		public void Evolve()
		{
			ShowOldGeneration();

			List<Chromosome> springs = new List<Chromosome>(_population.Count);

			_population.Sort();
			for (int i = 0; i < _elitism; i++)
			{
				springs.Add(new Chromosome(_population[i]));
			}

			for (int i = 0; i < _population.Count - _elitism; i++)
			{
				Shuffle();
				springs.Add(new Chromosome(RouletteWheel()));
			}

			for (int i = _elitism; i < springs.Count; i += 2)
			{
				GAUtil.Crossover(springs[i], springs[i + 1], _cutPoints);
			}

			for (int i = _elitism; i < springs.Count; i++)
			{
				GAUtil.Mutation(springs[i], _mutationRate);
			}

			_population = springs;
		}
	}
}