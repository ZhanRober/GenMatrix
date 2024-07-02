using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace GenMatrix
{
    public class Algorithms
    {
        public List<Chromosome> chromosomes;
        int sum;
        List<double> probability;
        private static Random random = new Random();


        public Algorithms() 
        {
            chromosomes = new List<Chromosome>();
            for (int i = 0; i < Parametres.Instance.PopulationSize; i++)
            {
                var element = new Chromosome();
                chromosomes.Add(element);
            }
            FillProbability();
        }

        private void FillProbability()
        {
            probability = new List<double>();
            CalculateSum();
            foreach (var chromosome in chromosomes)
            {
                probability.Add(Math.Round((double)chromosome.rating_int / (double)sum, 2));
            }
        }
        
        private void CalculateSum()
        {
            foreach (var chromosome in chromosomes)
            {
                sum += chromosome.rating_int; 
            }
        }

        public void NewGen()
        {
            int ind = random.Next(0,chromosomes.Count-1);
            Crossing(chromosomes[ind], chromosomes[ind+1]);
        }

        private void Crossing(Chromosome first, Chromosome second)
        {
            List<int> part_first = new List<int>();
            List<int> part_second = new List<int>();
            int first_ind, second_ind;
            while (true)
            {
                first_ind = random.Next(0, first.chromosome.Count / 2);
                second_ind = random.Next(first_ind+1, first.chromosome.Count);
                if (second_ind - first_ind != first.chromosome.Count - 1)
                {
                    part_first = first.chromosome.GetRange(first_ind, second_ind);
                    part_second = second.chromosome.GetRange(first_ind, second_ind);
                    break;
                }
            }
            ReplacePart(first, part_second, part_first, first_ind);
            ReplacePart(second, part_first, part_second, first_ind);
        }

        private static void ReplacePart(Chromosome element, List<int> newPart, List<int> oldPart, int start)
        {
            int size = element.chromosome.Count;
            HashSet<int> newPartSet = new HashSet<int>(newPart);

            List<int> offspring = new List<int>(new int[size]);

            for (int i = 0; i < newPart.Count; i++)
            {
                offspring[start + i] = newPart[i];
            }

            int currentPos = (start + newPart.Count) % size;
            for (int i = 0; i < size; i++)
            {
                int elementIdx = (start + newPart.Count + i) % size;
                if (!newPartSet.Contains(element.chromosome[elementIdx]))
                {
                    offspring[currentPos] = element.chromosome[elementIdx];
                    currentPos = (currentPos + 1) % size;
                }
            }

            element.chromosome = offspring;
        }
    }
}
