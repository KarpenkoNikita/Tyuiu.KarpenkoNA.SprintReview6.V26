using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KarpenkoNA.SprintReview6.V26.Lib;

namespace Tyuiu.KarpenkoNA.SprintReview6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        Random rnd = new Random();

        private void buttonResult_KNA_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBoxN1_KNA.Text) < Convert.ToInt32(textBoxN2_KNA.Text) && Convert.ToInt32(textBoxK_KNA.Text) < Convert.ToInt32(textBoxL_KNA.Text) && Convert.ToInt32(textBoxR_KNA.Text) < Convert.ToInt32(textBoxRows_KNA.Text))
            {
                int N = Convert.ToInt32(textBoxRows_KNA.Text);
                int M = Convert.ToInt32(textBoxColumns_KNA.Text);
                int K = Convert.ToInt32(textBoxK_KNA.Text);
                int L = Convert.ToInt32(textBoxL_KNA.Text);
                int R = Convert.ToInt32(textBoxR_KNA.Text);
                int n1 = Convert.ToInt32(textBoxN1_KNA.Text);
                int n2 = Convert.ToInt32(textBoxN2_KNA.Text);
                int[,] mrtx = new int[N, M];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        mrtx[i, j] = rnd.Next(n1, n2);
                    }
                }

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (mrtx[i, j] < 0)
                        {
                            mrtx[i, j] = mrtx[i, j] * -1;
                        }
                    }
                }

                for (int j = 0; j < M; j++)
                {
                    for (int i = 0; i < N; i = i + 2)
                    {
                        if (j % 2 == 0)
                        {
                            mrtx[i, j] = mrtx[i, j] * -1;
                        }
                        else
                            for (int p = 1; p < N; p = p + 2)
                            {
                                {
                                    mrtx[p, j] = mrtx[p, j] * -1;
                                }
                            }

                    }
                }

                textBoxResult_KNA.Text = Convert.ToString(ds.GetMatrix(mrtx, R, K, L));

                dataGridViewMas_KNA.RowCount = N;
                dataGridViewMas_KNA.ColumnCount = M;

                for (int i = 0; i < N; i++)
                {
                    dataGridViewMas_KNA.Columns[i].Width = 25;
                }

                for (int r = 0; r < N; r++)
                {
                    for (int c = 0; c < M; c++)
                    {
                        dataGridViewMas_KNA.Rows[r].Cells[c].Value = mrtx[r, c];
                    }
                }


            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
