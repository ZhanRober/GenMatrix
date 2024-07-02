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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HandsInput_Click(object sender, EventArgs e)
        {
            var window = new UserEnter();
            window.Owner = this;
            window.Show();
        }

        private void FileInput_Click(object sender, EventArgs e)
        {
            var window = new InputFile();
            window.Owner = this;
            window.Show();
        }

        private void RandomInput_Click(object sender, EventArgs e)
        {
            //var window = new Procces();
            //window.Owner = this;
            //window.Show();
        }
    }
}
