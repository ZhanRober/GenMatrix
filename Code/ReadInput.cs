using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GenMatrix
{
    public class ReadInput
    {
        public void ReadParametres(string line)
        {
            string[] paramentres = line.Replace(" ", "").Split(';');

            if (paramentres.Length < 4)
            {
                MessageBox.Show("Некорректное количество параметров", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(paramentres[0], out int populationSize) &&
                int.TryParse(paramentres[1], out int numberOfGeneration) &&
                double.TryParse(paramentres[2], NumberStyles.Any, CultureInfo.InvariantCulture, out double crossoverRate) &&
                double.TryParse(paramentres[3], NumberStyles.Any, CultureInfo.InvariantCulture, out double mutationRate))
            {
                Parametres.Instance.PopulationSize = populationSize;
                Parametres.Instance.NumberOfGeneration = numberOfGeneration;
                Parametres.Instance.CrossoverRate = crossoverRate;
                Parametres.Instance.MutationRate = mutationRate;
            }
            else
            {
                MessageBox.Show("Некорректные значения параметров", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReadMatrix(string line, StringBuilder name)
        {
            string[] parts = line.Replace(" ", "").Split(';');
            var matrixes = new List<Matrix_>(All_Matrix.Instance.get_matrixes());
            bool fl = true;
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out int number1) &&
                int.TryParse(parts[1], out int number2))
            {
                if (matrixes.Count > 0)
                {
                    if (matrixes[matrixes.Count - 1].width == number1)
                    {
                        Matrix_ matrix = new Matrix_(number1, number2, name.ToString());
                        All_Matrix.Instance.Add(matrix);
                    }
                    else fl = false;
                }
                else
                {
                    Matrix_ matrix = new Matrix_(number1, number2, name.ToString());
                    All_Matrix.Instance.Add(matrix);
                }
            }

            else
            {
                MessageBox.Show("Некорректно введены данные", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                if (fl != true)
                {
                    MessageBox.Show("Некорректно введены данные", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
