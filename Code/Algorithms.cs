using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;
using System.Xml.Linq;
using System.Runtime.ExceptionServices;

namespace GenMatrix
{
    public class Algorithms
    {
        public List<Chromosome> chromosomes;
        public double sum;
        double sum_ratings;
        List<double> probability;
        List<double> sequential_probability;
        private Random random = new Random();


        public Algorithms()
        {
            chromosomes = new List<Chromosome>();
            for (int i = 0; i < Parametres.Instance.PopulationSize; i++)
            {
                var element = new Chromosome();
                chromosomes.Add(element);
            }
        }

        private void FillProbability()
        {
            probability = new List<double>();
            sequential_probability = new List<double>();
            sum_ratings = 0;

            CalculateSum();
            CountShare();
            for (int i = 0; i < chromosomes.Count; i++)
            {
                chromosomes[i].rating = Math.Round(1 / probability[i], 2);
            }
            probability.Clear();
            CalculateSum();
            CountShare();
            CountSequentialProbability();
        }

        private void CountSequentialProbability()
        {
            for (int i = 0; i < probability.Count; i++)
            {
                sum_ratings += probability[i];
                sequential_probability.Add(Math.Round(sum_ratings,2));
            }
            sum_ratings = Math.Round(sum_ratings,2);
        }

        private void CountShare()
        {
            foreach (var chromosome in chromosomes)
            {
                probability.Add(Math.Round((double)chromosome.rating / (double)sum, 2));
            }
        }

        public void CalculateSum()
        {
            sum = 0;
            foreach (var chromosome in chromosomes)
            {
                sum += chromosome.rating;
            }
            sum = Math.Round(sum, 2);
        }

        public void NewGen()
        {
            FillProbability();
            List<Chromosome> new_gen = new List<Chromosome>();
            while (new_gen.Count < chromosomes.Count)
            {
                new_gen.Add(Selection());
            }
            chromosomes.Clear();
            bool fl = false;
            while (new_gen.Count!=0)
            {
                if (new_gen.Count == 1)
                {
                    chromosomes.Add(Mutation(new Chromosome(new_gen[0])));
                    new_gen.Remove(new_gen[0]);
                }
                else
                {
                    Tuple<Chromosome, Chromosome> childs = GetPair(new_gen, fl);
                    if (fl && Math.Round(random.NextDouble(), 2) <= Parametres.Instance.CrossoverRate)
                    {
                        Crossing(childs.Item1, childs.Item2);
                    }
                    chromosomes.Add(Mutation(new Chromosome(childs.Item1)));
                    chromosomes.Add(Mutation(new Chromosome(childs.Item2)));
                }
            }
            CalculateSum();
        }

        private void Crossing(Chromosome first, Chromosome second)
        {
            List<int> part_first = new List<int>();
            List<int> part_second = new List<int>();
            int first_ind, second_ind;
            while (true)
            {
                first_ind = random.Next(0, first.chromosome.Count / 2);
                second_ind = random.Next(first_ind + 1, first.chromosome.Count);
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

        private Chromosome Selection()
        {
            double element = Math.Round(random.NextDouble() * sum_ratings,2);
            var ind = 0;
            foreach (double i in sequential_probability)
            {
                if (i > element) break;
                ind++;
            }
            if (ind == chromosomes.Count) ind--;
            
            return new Chromosome(chromosomes[ind]);
        }

        private Tuple<Chromosome, Chromosome> GetPair(List<Chromosome> newchrome, bool fl)
        {
            Chromosome first = new Chromosome(newchrome[0]);
            Chromosome second = null;
            fl = false;
            int ind = 1;
            for (int i = 1; i<newchrome.Count; i++)
            {
                if (first.chromosome == newchrome[i].chromosome)
                {
                    for (int j = i + 1; j < newchrome.Count; j++)
                    {
                        if (first.chromosome != newchrome[j].chromosome)
                        {
                            second = new Chromosome(newchrome[j]);
                            ind = j;
                            fl = true;
                        }
                    }
                }
                else
                {
                    second = new Chromosome(newchrome[i]);
                    ind = i;
                    fl = true;
                }
                if (fl) break;
            }
            if (!fl)
            {
                second = new Chromosome(newchrome[1]);
                ind = 1;
            }
            newchrome.Remove(newchrome[ind]);
            newchrome.Remove(newchrome[0]);
            return new Tuple<Chromosome,Chromosome>(first, second);
        }

        private Chromosome Mutation(Chromosome item)
        {
            //Chromosome item = new Chromosome(element);

            if (Math.Round(random.NextDouble(), 2) <= Parametres.Instance.MutationRate)
            {
                for (int i = item.chromosome.Count - 1; i >= 1; i--)
                {
                    int j = random.Next(i + 1);
                    var tmp = item.chromosome[j];
                    item.chromosome[j] = item.chromosome[i];
                    item.chromosome[i] = tmp;
                }
            }
            item.CountRating();
            return item;
        }
    }
}
