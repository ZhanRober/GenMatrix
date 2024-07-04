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
            List<Tuple<int, int>> list_matrix = All_Matrix.Instance.ListView();

            int ind_copy = 0;
            rating = 0; 

            while(ind_copy<copy.Count)
            {
                int ind = copy[ind_copy];
                rating += list_matrix[ind - 1].Item1 * list_matrix[ind - 1].Item2 * list_matrix[ind].Item2;
                list_matrix[ind - 1] = new Tuple<int,int>(list_matrix[ind-1].Item1,list_matrix[ind].Item2);
                list_matrix.RemoveAt(ind);
                EditChromosome(copy, ind);
                ind_copy++;
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
