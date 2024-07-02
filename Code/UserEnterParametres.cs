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
            Parametres.Instance.PopulationSize = int.Parse(this.PopulationSize.Text.Replace(" ", ""));
            Parametres.Instance.NumberOfGeneration = int.Parse(this.NumberOfGeneration.Text.Replace(" ", ""));
            Parametres.Instance.CrossoverRate = double.Parse(this.CrossoverRate.Text.Replace(" ", ""), CultureInfo.InvariantCulture);
            Parametres.Instance.MutationRate = double.Parse(this.MutationRate.Text.Replace(" ", ""), CultureInfo.InvariantCulture);
            var window = new Procces();
            window.Owner = this;
            window.Show();
            this.Hide();
        }
    }
}
