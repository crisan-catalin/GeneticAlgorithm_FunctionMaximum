using System;
using System.Collections;
using System.Text;

namespace FunctionMaximum.Core
{
	public class Chromosome : IComparable<Chromosome>
	{
		private readonly BitArray _genes;

		public int Size => _genes.Count;

		public int Value
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

		public int Fitness
		{
			get
			{
				return 4 * (int) Math.Pow(Value, 4) + 3 * (int) Math.Pow(Value, 3) + 2 * (int) Math.Pow(Value, 2) + Value + 1;
			}
		}

		public double ProbabilityOfSelection { get; set; }

		public double ExpectedCount { get; set; }

		public bool this[int index]
		{
			get { return _genes.Get(index); }
			set { _genes.Set(index, value); }
		}

		public Chromosome(Chromosome chromosome)
		{
			_genes = new BitArray(chromosome.Size);
			for (int i = 0; i < chromosome.Size; i++)
			{
				_genes.Set(i,chromosome._genes.Get(i));
			}
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