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
    public partial class UserEnter : Form
    {
        private int count = 0;
        private StringBuilder name = new StringBuilder("A_0");
        private ReadInput read_input = new ReadInput();
        public UserEnter()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var window = new UserEnterParametres();
            window.Owner = this;
            window.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.count++;
            this.name.Replace((count - 1).ToString(), count.ToString());
            string input = this.InputText.Text;
            read_input.ReadMatrix(input, name);
            this.InputText.Text = "";
        }

    }
}
