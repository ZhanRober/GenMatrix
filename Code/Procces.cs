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
            algos.CalculateSum();
            foreach (var alg in algos.chromosomes)
            {
                string formattedChromosome = GetMatrixMultiplicationOrder(alg.chromosome);
                richTextBox1.AppendText(formattedChromosome);
                richTextBox1.AppendText("\n");
            }
            richTextBox1.AppendText(algos.sum.ToString());
            richTextBox1.AppendText("\n");
            algos.CalculateSum();
        }

        private string GetMatrixMultiplicationOrder(List<int> chromosome)
        {
            int n = All_Matrix.Instance.NumberOfMatrix();  // Предположим, что у вас 10 матриц

            // Имена матриц
            var matrixNames = Enumerable.Range(1, n).Select(i => $"A_{i}").ToList();

            // Стек для хранения подстрок
            Stack<string> stack = new Stack<string>();

            // Отмечаем, какие матрицы уже включены в выражение
            bool[] included = new bool[n];

            foreach (int idx in chromosome)
            {
                int leftIdx = idx - 1;
                int rightIdx = idx;

                // Получение матриц
                string leftMatrix = included[leftIdx] ? stack.Pop() : matrixNames[leftIdx];
                string rightMatrix = included[rightIdx] ? stack.Pop() : matrixNames[rightIdx];

                // Формирование строки с учетом скобок
                string multiplicationOrder = $"({leftMatrix}*{rightMatrix})";

                // Помещаем строку в стек
                stack.Push(multiplicationOrder);

                // Отмечаем, что эти матрицы включены
                included[leftIdx] = true;
                included[rightIdx] = true;
            }

            // Итоговая строка порядка умножения матриц
            while (stack.Count > 1)
            {
                string right = stack.Pop();
                string left = stack.Pop();
                stack.Push($"({left}*{right})");
            }

            return stack.Pop();
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
