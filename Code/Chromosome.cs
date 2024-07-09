using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GenMatrix
{
    public class Chromosome
    {
        private static Random random = new Random();
        public List<int> chromosome;
        List<Matrix_> local_matrixes;
        public double rating;

        public Chromosome()
        {
            chromosome = CreateChromosome();
            local_matrixes = new List<Matrix_>(All_Matrix.Instance.get_matrixes());
            CountRating();
        }

        public Chromosome(Chromosome parent)
        {
            this.chromosome = new List<int>(parent.chromosome);
            this.local_matrixes = new List<Matrix_>(parent.local_matrixes);
            this.rating = parent.rating;
        }

        private List<int> CreateChromosome()
        { 
            List<int> numbers = Enumerable.Range(1, All_Matrix.Instance.NumberOfMatrix()-1).ToList();

            List<int> result = new List<int>();
            while (numbers.Count > 0)
            {
                var ind = random.Next(0, numbers.Count);
                result.Add(numbers[ind]);
                numbers.RemoveAt(ind);
            }

            return result;
        }

        public void CountRating()
        {
            List<int> copy = new List<int>(chromosome);
            List<Tuple<int, int>> originalListMatrix = All_Matrix.Instance.ListView();
            List<Tuple<int, int>> listMatrix = new List<Tuple<int, int>>();

            foreach (var matrix in originalListMatrix)
            {
                listMatrix.Add(new Tuple<int, int>(matrix.Item1, matrix.Item2));
            }

            int indCopy = 0;
            rating = 0;

            while (indCopy < copy.Count)
            {
                int ind = copy[indCopy];
                rating += listMatrix[ind - 1].Item1 * listMatrix[ind - 1].Item2 * listMatrix[ind].Item2;
                listMatrix[ind - 1] = new Tuple<int, int>(listMatrix[ind - 1].Item1, listMatrix[ind].Item2);
                listMatrix.RemoveAt(ind);
                EditChromosome(copy, ind);
                indCopy++;
            }
        }

        private void EditChromosome(List<int> copy, int curr)
        {
            for (int i = 0; i < copy.Count; i++)
            {
                if (copy[i] > curr) copy[i] -= 1;
            }
        }
    }
}
