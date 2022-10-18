using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 矩阵卷积计算
{
    class Matrix
    {
        public Matrix(int am, int an)
        {
            M = am;
            N = an;
            Matrix_a = new double[M, N];
        }


        int M;
        int N;
        double[,] matrix;

        public int GetN
        {
            set { N = value; }
            get { return N; }
        }

        public int GetM
        {
            set { M = value; }
            get { return M; }
        }

        public double[,] Matrix_a
        {
            set { matrix = value; }
            get { return matrix; }
        }

    }
}
