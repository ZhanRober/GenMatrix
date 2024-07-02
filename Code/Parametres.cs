using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMatrix
{
    public class Parametres
    {
        private static Parametres _instance;
        private static readonly object _lock = new object();

        private int population_size;
        private int number_of_generation;
        private double crossover_rate;
        private double mutation_rate;

        private Parametres() { }

        public static Parametres Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Parametres();
                    }
                    return _instance;
                }
            }
        }

        public int PopulationSize
        {
            get { return population_size; }
            set { population_size = value; }
        }

        public int NumberOfGeneration
        {
            get { return number_of_generation; }
            set { number_of_generation = value; }
        }

        public double CrossoverRate
        {
            get { return crossover_rate; }
            set { crossover_rate = value; }
        }

        public double MutationRate
        {
            get { return mutation_rate; }
            set { mutation_rate = value; }
        }
    }
}
