using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenMatrix
{
    public partial class Procces : Form
    {
        Algorithms algos;
        int count = 1;
        List<double> sums = new List<double>();
        public Procces()
        {
            InitializeComponent();
            algos = new Algorithms();
            PrintChromosomes();
            sums.Add(algos.sum);
        }

        private void PrintChromosomes()
        {
            foreach (var alg in algos.chromosomes)
            {
                foreach (var el in alg.chromosome)
                {
                    richTextBox1.AppendText(el.ToString());
                    richTextBox1.AppendText(" ");
                }
                richTextBox1.AppendText("; ");
            }
            algos.CalculateSum();
            richTextBox1.AppendText(" - ");
            richTextBox1.AppendText(algos.sum.ToString());
            richTextBox1.AppendText("\n");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (count <= Parametres.Instance.NumberOfGeneration)
            {
                algos.NewGen();
                PrintChromosomes();
                count++;
                sums.Add(algos.sum);
            }
            else
            {
                MessageBox.Show("Достигнуто последнее поколение", "GenerationError", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            while(count<= Parametres.Instance.NumberOfGeneration)
            {
                algos.NewGen();
                PrintChromosomes();
                count++;
                sums.Add(algos.sum);
            }
        }

        private void Graphic_Click(object sender, EventArgs e)
        {
            var window = new Graphic(sums);
            window.Owner = this;
            window.Show();
        }
    }
}
