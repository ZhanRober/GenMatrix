using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GenMatrix
{
    public class Matrix_
    {
        public int hight;
        public int width;
        string name;

        public Matrix_(int hight, int width, string name)
        {
            this.hight = hight;
            this.width = width;
            this.name = name;
        }

        public string get_name() { return name; }
    }

    public class All_Matrix
    {
        private static All_Matrix _instance;
        private static readonly object _lock = new object();

        private List<Matrix_> matrixes;

        private All_Matrix()
        {
            matrixes = new List<Matrix_>();
        }

        public static All_Matrix Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new All_Matrix();
                    }
                    return _instance;
                }
            }
        }

        public List<Matrix_> get_matrixes() { return matrixes; }

        public void Add(Matrix_ matrix)
        {
            if (matrix == null) return;
            matrixes.Add(matrix);
        }

        public string PrintAll()
        {
            StringBuilder result = new StringBuilder();
            foreach (Matrix_ matrix in matrixes)
            {
                result.Append(matrix.get_name() + ";");
            }
            return result.ToString();
        }

        public int NumberOfMatrix()
        {
            return matrixes.Count;
        }

        public List<Tuple<int,int>> ListView()
        {
            List<Tuple<int,int>> result = new List<Tuple<int,int>>();
            foreach (Matrix_ matrix in matrixes)
            {
                result.Add(new Tuple<int,int>(matrix.hight, matrix.width));
            }
            return result;
        }
    }

}
