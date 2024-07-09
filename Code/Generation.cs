using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMatrix
{
    public class Generation
    {
        private Random random = new Random();
        private ReadInput input = new ReadInput();

        public Generation()
        {
            RandMatrix();
            RandParametres();
        }

        private void RandMatrix()
        {
            int count = random.Next(4, 10);
            int param1 = random.Next(1,30);
            int param2;
            StringBuilder name = new StringBuilder("A_0");
            StringBuilder matrix = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                name.Replace(i.ToString(), (i+1).ToString());
                param2 = random.Next(1, 30);
                matrix.Append(param1.ToString());
                matrix.Append(";");
                matrix.Append(param2.ToString());
                input.ReadMatrix(matrix.ToString(), name);
                param1 = param2;
                matrix.Clear();
            }
        }

        private void RandParametres()
        {
            List<double> param = new List<double>();
            param.Add(random.Next(6, 30));
            param.Add(random.Next(10, 100));
            param.Add(random.Next(6,9)/10);
            param[2] = Math.Round(param[2], 2);
            param.Add(random.Next(1, 4) / 10);
            param[3] = Math.Round(param[3], 2);

            StringBuilder res = new StringBuilder();
            foreach (var i in param)
            {
                res.Append(i.ToString());
                res.Append(";");
            }
            input.ReadParametres(res.ToString());
        }
    }
}
