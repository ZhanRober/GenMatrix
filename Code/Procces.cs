using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenMatrix
{
    public partial class Procces : Form
    {
        Algorithms algos;
        public Procces()
        {
            InitializeComponent();
            algos = new Algorithms();
            PrintChromosomes();
        }

        private void PrintChromosomes()
        {
            foreach (var alg in algos.chromosomes)
            {
                foreach (var el in alg.chromosome)
                {
                    richTextBox1.AppendText(el.ToString());
                }
                richTextBox1.AppendText("-");
                richTextBox1.AppendText(alg.rating_int.ToString());
                richTextBox1.AppendText(";");
            }
            richTextBox1.AppendText("\n");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            algos.NewGen();
            PrintChromosomes ();
        }
    }
}
