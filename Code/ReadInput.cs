using System;
using System.Collections.Generic;
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

            Parametres.Instance.PopulationSize = int.Parse(paramentres[0]);
            Parametres.Instance.NumberOfGeneration = int.Parse(paramentres[1]);
            Parametres.Instance.CrossoverRate = double.Parse(paramentres[2], CultureInfo.InvariantCulture);
            Parametres.Instance.MutationRate = double.Parse(paramentres[3], CultureInfo.InvariantCulture);
        }

        public void ReadMatrix(string line, StringBuilder name)
        {
            string[] parts = line.Replace(" ", "").Split(';');

            if (parts.Length == 2)
            {
                int number1 = int.Parse(parts[0]);
                int number2 = int.Parse(parts[1]);
                Matrix_ matrix = new Matrix_(number1, number2, name.ToString());
                All_Matrix.Instance.Add(matrix);
            }
            else
            {
                MessageBox.Show("Некорректно введены данные", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
