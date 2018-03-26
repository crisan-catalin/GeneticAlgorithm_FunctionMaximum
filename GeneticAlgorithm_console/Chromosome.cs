using System;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace GeneticAlgorithm_console
{
	public class Chromosome : IComparable<Chromosome>
	{
		private BitArray _genes;

		public Int32 Size
		{
			get { return _genes.Count; }
		}

		public Int32 Value
		{
			get
			{
				int result = 0;

				for (int i = 0; i < _genes.Count; i++)
				{
					if (_genes.Get(i))
					{
						result += Convert.ToInt32(Math.Pow(2, _genes.Count - 1 - i));
					}
				}
				return result;
			}
		}

		public Int32 Fitness
		{
			get
			{
				return 4 * (int) Math.Pow(Value, 4) + 3 * (int) Math.Pow(Value, 3) + 2 * (int) Math.Pow(Value, 2) + Value + 1;
			}
		}

		public Double ProbabilityOfSelection { get; set; }

		public Double ExpectedCount { get; set; }

		public bool this[int index]
		{
			get { return _genes.Get(index); }
			set { _genes.Set(index, value); }
		}


		public Chromosome(int chromosomeSize, Random random)
		{
			_genes = new BitArray(chromosomeSize);
			for (int i = 0; i < chromosomeSize; i++)
			{
				_genes.Set(i, random.NextDouble() > 0.5);
			}
		}

		public int CompareTo(Chromosome other)
		{
			return Convert.ToInt32(other.Fitness - Fitness);
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (bool gene in _genes)
			{
				stringBuilder.Append(gene ? 1 : 0);
			}
			return stringBuilder.ToString() + " | Fitness: " + Fitness;
		}
	}
}