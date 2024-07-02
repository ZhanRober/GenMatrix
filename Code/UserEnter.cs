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
        //private All_Matrix elements = new All_Matrix();
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
            string parts = input.Replace(" ", "");
            string[] pair_numbers = parts.Split(';');

            if (pair_numbers.Length == 2)
            {
                int number1 = int.Parse(pair_numbers[0]);
                int number2 = int.Parse(pair_numbers[1]);
                Matrix_ matrix = new Matrix_(number1, number2, name.ToString());
                All_Matrix.Instance.Add(matrix);
            }
            else
            {
                MessageBox.Show("Некорректно введены данные", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.InputText.Text = "";
        }

    }
}
