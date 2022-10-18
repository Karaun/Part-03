using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace 矩阵卷积计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Hashtable mx_list = new Hashtable();

        private void button1_Click(object sender, EventArgs e)
        {
            #region 被卷积矩阵
            //获取数据，创建被卷积矩阵
            string[] line1 = txtMatrix1.Text.Split('\n');
            int M1 = line1.Length;
            int N1 = 0;
            string[][] rank1 = new string[line1.Length][];
            
            for (int j = 0; j < line1.Length; j++)
            {
                rank1[j] = line1[j].Split(' ');
                N1 = rank1[j].Length;
            }

            Matrix a = new Matrix(M1, N1);
            //为矩阵赋值
            for (int b = 0; b < M1; b++)
            {
                for (int c = 0; c < N1; c++)
                {
                    a.Matrix_a[b, c] = Convert.ToDouble(rank1[b][c]);
                }
            }
            #endregion


            //获取数据，创建核矩阵
            string[] line = txtMatrix2.Text.Split('\n');
            int M = line.Length;
            int N = 0;
            string[][] rank = new string[line.Length][];

            for (int j = 0; j < line.Length; j++)
            {
                rank[j] = line[j].Split(' ');
                N = rank[j].Length;
            }

            Matrix a1 = new Matrix(M, N);
            //为矩阵赋值
            for (int b = 0; b < M; b++)
            {
                for (int c = 0; c < N; c++)
                {
                    a1.Matrix_a[b, c] = Convert.ToDouble(rank[b][c]);
                }
            }

       

            //卷积算法1
            Matrix out_come = new Matrix(M1, N1);

            for (int q = 0; q < M1; q++)
            {
                for (int w = 0; w < N1; w++)
                {
                    double t = 0.0;
                    double temp1 = 0;
                    double temp2 = 0;
                    
                    for (int i = 0; i < M; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            //算法1
                            if (q - i - 1 < 0 || w - j - 1 < 0 || q - i > M1 || w - j > N1)
                            {
                                t += 0;
                            }
                            else
                            {
                                temp1 += a1.Matrix_a[i, j] * a.Matrix_a[q - i - 1, w - j - 1];
                                temp2 += a1.Matrix_a[i, j];
                            }

                            
                            /*//算法2
                            try
                            {
                                temp1 += a1.Matrix_a[i, j] * a.Matrix_a[q - i - 1, w - j - 1];
                                //MessageBox.Show(a1.Matrix_a[i, j] + "+" + a.Matrix_a[q - i - 1, w - i - 1]);
                                temp2 += a1.Matrix_a[i, j];
                                //MessageBox.Show(a1.Matrix_a[i, j] + "");
                            }
                            catch
                            {
                                t += 0;
                            }
                            */

                        }
                    }
                    t = temp1 / temp2;
                    out_come.Matrix_a[q, w] = t;   
                }
            }

            string result = null;
            for (int b = 0; b < M1; b++)
            {
                for (int c = 0; c < N1; c++)
                {
                    result =  result +(out_come.Matrix_a[b, c].ToString("#0.00")) + "\r\n";

                }
            }

            txtMatrix3.Text = result;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region 被卷积矩阵
            //获取数据，创建被卷积矩阵
            string[] line1 = txtMatrix1.Text.Split('\n');
            int M1 = line1.Length;
            int N1 = 0;
            string[][] rank1 = new string[line1.Length][];

            for (int j = 0; j < line1.Length; j++)
            {
                rank1[j] = line1[j].Split(' ');
                N1 = rank1[j].Length;
            }

            Matrix a = new Matrix(M1, N1);
            //为矩阵赋值
            for (int b = 0; b < M1; b++)
            {
                for (int c = 0; c < N1; c++)
                {
                    a.Matrix_a[b, c] = Convert.ToDouble(rank1[b][c]);
                }
            }
            #endregion


            #region 核卷积
            //获取数据，创建核矩阵
            string[] line = txtMatrix2.Text.Split('\n');
            int M = line.Length;
            int N = 0;
            string[][] rank = new string[line.Length][];

            for (int j = 0; j < line.Length; j++)
            {
                rank[j] = line[j].Split(' ');
                N = rank[j].Length;
            }

            Matrix a1 = new Matrix(M, N);
            //为矩阵赋值
            for (int b = 0; b < M; b++)
            {
                for (int c = 0; c < N; c++)
                {
                    a1.Matrix_a[b, c] = Convert.ToDouble(rank[b][c]);
                }
            }
            #endregion

            Matrix out_come = new Matrix(M1, N1);

            for (int q = 0; q < M1; q++)
            {
                for (int w = 0; w < N1; w++)
                {
                    double t = 0.0;
                    double temp1 = 0;
                    double temp2 = 0;

                    for (int i = 0; i < M; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (q - i - 1 < 0 || w - j - 1 < 0 || q - i > M1 || w - j > N1)
                            {
                                t += 0;
                            }
                            else
                            {

                                temp1 += a1.Matrix_a[i, j] * a.Matrix_a[M1 - 1 - (q - i - 1), N1 - 1 - (w - j - 1)];
                                temp2 += a1.Matrix_a[i, j];
                            }
                            


                        }
                    }
                    t = temp1 / temp2;
                    out_come.Matrix_a[q, w] = t;
                }
            }

            string result = null;
            for (int b = 0; b < M1; b++)
            {
                for (int c = 0; c < N1; c++)
                {
                    result = result + (out_come.Matrix_a[b, c].ToString("#0.00")) + "\r\n";

                }
            }

            txtMatrix3.Text = result;

        }

        private void 打开被卷积矩阵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你要打开的文件";
            ofd.Filter = "txt|*.txt|All|*.*";
            ofd.ShowDialog();

            string path = ofd.FileName;

            if (path == "")
            {
                return;
            }

            using (FileStream FsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = FsRead.Read(buffer, 0, buffer.Length);
                txtMatrix1.Text = Encoding.UTF8.GetString(buffer, 0, r);


            }
        }

        private void 打开核矩阵ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你要打开的文件";
            ofd.Filter = "txt|*.txt|All|*.*";
            ofd.ShowDialog();

            string path = ofd.FileName;

            if (path == "")
            {
                return;
            }

            using (FileStream FsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = FsRead.Read(buffer, 0, buffer.Length);
                txtMatrix2.Text = Encoding.UTF8.GetString(buffer, 0, r);


            }
        }

        private void 导出结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择保存路径";
            sfd.Filter = "tx|*.txt|All|*.*";
            sfd.ShowDialog();

            string outcome = sfd.FileName;
            if (outcome == "")
            {
                return;
            }
            using (FileStream FsWrite = new FileStream(outcome, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(txtMatrix3.Text);
                FsWrite.Write(buffer, 0, buffer.Length);

            }
        }
    }
}
