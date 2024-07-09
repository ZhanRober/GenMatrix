using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GenMatrix
{
    public partial class UserEnterParametres : Form
    {
        public UserEnterParametres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.PopulationSize.Text.Replace(" ", ""), out int populationSize))
            {
                Parametres.Instance.PopulationSize = populationSize;
            }
            else
            {
                MessageBox.Show("Некорректное значение для PopulationSize", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(this.NumberOfGeneration.Text.Replace(" ", ""), out int numberOfGeneration))
            {
                Parametres.Instance.NumberOfGeneration = numberOfGeneration;
            }
            else
            {
                MessageBox.Show("Некорректное значение для NumberOfGeneration", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(this.CrossoverRate.Text.Replace(" ", ""), NumberStyles.Any, CultureInfo.InvariantCulture, out double crossoverRate ) && crossoverRate >= 0 && crossoverRate < 1)
            {
                Parametres.Instance.CrossoverRate = crossoverRate;
            }
            else
            {
                MessageBox.Show("Некорректное значение для CrossoverRate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (double.TryParse(this.MutationRate.Text.Replace(" ", ""), NumberStyles.Any, CultureInfo.InvariantCulture, out double mutationRate) && mutationRate>=0 && mutationRate<1)
            {
                Parametres.Instance.MutationRate = mutationRate;
            }
            else
            {
                MessageBox.Show("Некорректное значение для MutationRate", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var window = new Procces();
            window.Owner = this;
            window.Show();
            this.Hide();
        }

        
    }
}
