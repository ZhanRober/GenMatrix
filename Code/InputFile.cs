using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenMatrix
{
    public partial class InputFile : Form
    {
        ReadInput read_input = new ReadInput();
        public InputFile()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if(ReadFile())
            {
                var window = new Procces();
                window.Owner = this;
                window.Show();
                this.Hide();
            }
        }
        
        private bool ReadFile()
        {
            string file_path = this.InputText.Text.Replace(" ", "");
            try
            {
                using (StreamReader reader = new StreamReader(file_path))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        read_input.ReadParametres(line);
                    }
                    int count = 1;
                    StringBuilder name = new StringBuilder("A_0");
                    while ((line = reader.ReadLine()) != null)
                    {
                        name.Replace((count - 1).ToString(), count.ToString());
                        read_input.ReadMatrix(line, name);
                    }
                }
                return true;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Файл не найден", "Open File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка", "Open File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
