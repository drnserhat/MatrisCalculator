using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrisCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt11a.Text == "" || txt12.Text == "" || txt12a.Text == "" || txt13.Text == "" || txt13a.Text == "" || txt21.Text == "" || txt21a.Text == "" || txt22.Text == "" || txt22a.Text == "" || txt23.Text == "" || txt23a.Text == "" || txt31.Text == "" || txt31a.Text == "" || txt32.Text == "" || txt32a.Text == "" || txt33.Text == "" || txt33a.Text == "")
            {
                MessageBox.Show("A VE B MATRISINDE BOŞ YER BIRAKMAYINIZ!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);
                int text11a = Convert.ToInt32(txt11a.Text);
                int text12 = Convert.ToInt32(txt12.Text);
                int text12a = Convert.ToInt32(txt12a.Text);
                int text13 = Convert.ToInt32(txt13.Text);
                int text13a = Convert.ToInt32(txt13a.Text);
                int text21 = Convert.ToInt32(txt21.Text);
                int text21a = Convert.ToInt32(txt21a.Text);
                int text22 = Convert.ToInt32(txt22.Text);
                int text22a = Convert.ToInt32(txt22a.Text);
                int text23 = Convert.ToInt32(txt23.Text);
                int text23a = Convert.ToInt32(txt23a.Text);
                int text31 = Convert.ToInt32(txt31.Text);
                int text31a = Convert.ToInt32(txt31a.Text);
                int text32 = Convert.ToInt32(txt32.Text);
                int text32a = Convert.ToInt32(txt32a.Text);
                int text33 = Convert.ToInt32(txt33.Text);
                int text33a = Convert.ToInt32(txt33a.Text);

                int sonuc11 = text11 + text11a;
                int sonuc12 = text12 + text12a;
                int sonuc13 = text13 + text13a;
                int sonuc21 = text21 + text21a;
                int sonuc22 = text22 + text22a;
                int sonuc23 = text23 + text23a;
                int sonuc31 = text31 + text31a;
                int sonuc32 = text32 + text32a;
                int sonuc33 = text33 + text33a;
                MessageBox.Show(sonuc11 + "\t" + sonuc12 + "\t" + sonuc13 + "\n" + sonuc21 + "\t" + sonuc22 + "\t" + sonuc23 + "\n" + sonuc31 + "\t" + sonuc32 + "\t" + sonuc33);
            }
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt11a.Text == "" || txt12.Text == "" || txt12a.Text == "" || txt13.Text == "" || txt13a.Text == "" || txt21.Text == "" || txt21a.Text == "" || txt22.Text == "" || txt22a.Text == "" || txt23.Text == "" || txt23a.Text == "" || txt31.Text == "" || txt31a.Text == "" || txt32.Text == "" || txt32a.Text == "" || txt33.Text == "" || txt33a.Text == "")
            {
                MessageBox.Show("A VE B MATRISINDE BOŞ YER BIRAKMAYINIZ!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);
                int text11a = Convert.ToInt32(txt11a.Text);
                int text12 = Convert.ToInt32(txt12.Text);
                int text12a = Convert.ToInt32(txt12a.Text);
                int text13 = Convert.ToInt32(txt13.Text);
                int text13a = Convert.ToInt32(txt13a.Text);
                int text21 = Convert.ToInt32(txt21.Text);
                int text21a = Convert.ToInt32(txt21a.Text);
                int text22 = Convert.ToInt32(txt22.Text);
                int text22a = Convert.ToInt32(txt22a.Text);
                int text23 = Convert.ToInt32(txt23.Text);
                int text23a = Convert.ToInt32(txt23a.Text);
                int text31 = Convert.ToInt32(txt31.Text);
                int text31a = Convert.ToInt32(txt31a.Text);
                int text32 = Convert.ToInt32(txt32.Text);
                int text32a = Convert.ToInt32(txt32a.Text);
                int text33 = Convert.ToInt32(txt33.Text);
                int text33a = Convert.ToInt32(txt33a.Text);
                int sonuc11 = text11 - text11a;
                int sonuc12 = text12 - text12a;
                int sonuc13 = text13 - text13a;
                int sonuc21 = text21 - text21a;
                int sonuc22 = text22 - text22a;
                int sonuc23 = text23 - text23a;
                int sonuc31 = text31 - text31a;
                int sonuc32 = text32 - text32a;
                int sonuc33 = text33 - text33a;
                MessageBox.Show(sonuc11 + "\t" + sonuc12 + "\t" + sonuc13 + "\n" + sonuc21 + "\t" + sonuc22 + "\t" + sonuc23 + "\n" + sonuc31 + "\t" + sonuc32 + "\t" + sonuc33);
            }
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt11a.Text == "" || txt12.Text == "" || txt12a.Text == "" || txt13.Text == "" || txt13a.Text == "" || txt21.Text == "" || txt21a.Text == "" || txt22.Text == "" || txt22a.Text == "" || txt23.Text == "" || txt23a.Text == "" || txt31.Text == "" || txt31a.Text == "" || txt32.Text == "" || txt32a.Text == "" || txt33.Text == "" || txt33a.Text == "")
            {
                MessageBox.Show("A VE B MATRISINDE BOŞ YER BIRAKMAYINIZ!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);
                int text11a = Convert.ToInt32(txt11a.Text);
                int text12 = Convert.ToInt32(txt12.Text);
                int text12a = Convert.ToInt32(txt12a.Text);
                int text13 = Convert.ToInt32(txt13.Text);
                int text13a = Convert.ToInt32(txt13a.Text);
                int text21 = Convert.ToInt32(txt21.Text);
                int text21a = Convert.ToInt32(txt21a.Text);
                int text22 = Convert.ToInt32(txt22.Text);
                int text22a = Convert.ToInt32(txt22a.Text);
                int text23 = Convert.ToInt32(txt23.Text);
                int text23a = Convert.ToInt32(txt23a.Text);
                int text31 = Convert.ToInt32(txt31.Text);
                int text31a = Convert.ToInt32(txt31a.Text);
                int text32 = Convert.ToInt32(txt32.Text);
                int text32a = Convert.ToInt32(txt32a.Text);
                int text33 = Convert.ToInt32(txt33.Text);
                int text33a = Convert.ToInt32(txt33a.Text);

                int[,] A = new int[10, 10];
                int[,] B = new int[10, 10];
                A[0, 0] = text11;
                A[0, 1] = text12;
                A[0, 2] = text13;
                A[1, 0] = text21;
                A[1, 1] = text22;
                A[1, 2] = text23;
                A[2, 0] = text31;
                A[2, 1] = text32;
                A[2, 2] = text33;
                B[0, 0] = text11a;
                B[0, 1] = text12a;
                B[0, 2] = text13a;
                B[1, 0] = text21a;
                B[1, 1] = text22a;
                B[1, 2] = text23a;
                B[2, 0] = text31a;
                B[2, 1] = text32a;
                B[2, 2] = text33a;
                int[,] C = new int[10, 10];
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            C[i, k] += A[i, j] * B[j, k];
                        }
                    }
                }
                MessageBox.Show(C[0, 0] + "\t" + C[0, 1] + "\t" + C[0, 2] + "\n" + C[1, 0] + "\t" + C[1, 1] + "\t" + C[1, 2] + "\t" + "\n" + C[2, 0] + "\t" + C[2, 1] + "\t" + C[2, 2]);
            }
           }

        private void btnDet_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" ||  txt12.Text == ""  || txt13.Text == "" || txt21.Text == ""  || txt22.Text == ""  || txt23.Text == ""  || txt31.Text == "" || txt32.Text == "" ||  txt33.Text == "")
            {
                MessageBox.Show("Lütfen A matrisinde boş alan bırakmayınız!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);

                int text12 = Convert.ToInt32(txt12.Text);

                int text13 = Convert.ToInt32(txt13.Text);

                int text21 = Convert.ToInt32(txt21.Text);

                int text22 = Convert.ToInt32(txt22.Text);

                int text23 = Convert.ToInt32(txt23.Text);

                int text31 = Convert.ToInt32(txt31.Text);

                int text32 = Convert.ToInt32(txt32.Text);

                int text33 = Convert.ToInt32(txt33.Text);


                int[,] A = new int[10, 10];
                int[,] B = new int[10, 10];
                A[0, 0] = text11;
                A[0, 1] = text12;
                A[0, 2] = text13;
                A[1, 0] = text21;
                A[1, 1] = text22;
                A[1, 2] = text23;
                A[2, 0] = text31;
                A[2, 1] = text32;
                A[2, 2] = text33;
                int determinant = 0;
                for (int i = 0; i < 3; i++)
                {
                    determinant = determinant + (A[0, i] * (A[1, (i + 1) % 3] * A[2, (i + 2) % 3] - A[1, (i + 2) % 3] * A[2, (i + 1) % 3]));
                }

                MessageBox.Show("determianant: " + determinant);
            }
        }


        private void btnTranspoz_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt12.Text == "" || txt13.Text == "" || txt21.Text == "" || txt22.Text == "" || txt23.Text == "" || txt31.Text == "" || txt32.Text == "" || txt33.Text == "")
            {
                MessageBox.Show("Lütfen A matrisinde boş alan bırakmayınız!!!");
            }
            else { 
            int text11 = Convert.ToInt32(txt11.Text);

            int text12 = Convert.ToInt32(txt12.Text);

            int text13 = Convert.ToInt32(txt13.Text);

            int text21 = Convert.ToInt32(txt21.Text);

            int text22 = Convert.ToInt32(txt22.Text);

            int text23 = Convert.ToInt32(txt23.Text);

            int text31 = Convert.ToInt32(txt31.Text);

            int text32 = Convert.ToInt32(txt32.Text);

            int text33 = Convert.ToInt32(txt33.Text);


            int[,] A = new int[10, 10];
            int[,] B = new int[10, 10];
            A[0, 0] = text11;
            A[0, 1] = text12;
            A[0, 2] = text13;
            A[1, 0] = text21;
            A[1, 1] = text22;
            A[1, 2] = text23;
            A[2, 0] = text31;
            A[2, 1] = text32;
            A[2, 2] = text33;

            MessageBox.Show(A[0, 0] + "\t" + A[1, 0] + "\t" + A[2, 0] + "\n" + A[0, 1] + "\t" + A[1, 1] + "\t" + A[2, 1] + "\n" + A[0, 2] + "\t" + A[1, 2] + "\t" + A[2, 2] + "\n");
        }
        }

        private void btnInvulatif_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt12.Text == "" || txt13.Text == "" || txt21.Text == "" || txt22.Text == "" || txt23.Text == "" || txt31.Text == "" || txt32.Text == "" || txt33.Text == "")
            {
                MessageBox.Show("Lütfen A matrisinde boş alan bırakmayınız!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);

                int text12 = Convert.ToInt32(txt12.Text);

                int text13 = Convert.ToInt32(txt13.Text);

                int text21 = Convert.ToInt32(txt21.Text);

                int text22 = Convert.ToInt32(txt22.Text);

                int text23 = Convert.ToInt32(txt23.Text);

                int text31 = Convert.ToInt32(txt31.Text);

                int text32 = Convert.ToInt32(txt32.Text);

                int text33 = Convert.ToInt32(txt33.Text);


                int[,] A = new int[10, 10];
                int[,] C = new int[10, 10];
                A[0, 0] = text11;
                A[0, 1] = text12;
                A[0, 2] = text13;
                A[1, 0] = text21;
                A[1, 1] = text22;
                A[1, 2] = text23;
                A[2, 0] = text31;
                A[2, 1] = text32;
                A[2, 2] = text33;

                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            C[i, k] += A[i, j] * A[j, k];
                        }
                    }
                }
                if (InvulatifMatris(A))
                {
                    MessageBox.Show(C[0, 0] + "\t" + C[0, 1] + "\t" + C[0, 2] + "\n" + C[1, 0] + "\t" + C[1, 1] + "\t" + C[1, 2] + "\t" + "\n" + C[2, 0] + "\t" + C[2, 1] + "\t" + C[2, 2] + "\n" + "İnvulatif matristir");

                }
                else
                {
                    MessageBox.Show(C[0, 0] + "\t" + C[0, 1] + "\t" + C[0, 2] + "\n" + C[1, 0] + "\t" + C[1, 1] + "\t" + C[1, 2] + "\t" + "\n" + C[2, 0] + "\t" + C[2, 1] + "\t" + C[2, 2] + "\n" + "İnvulatif matris değildir");

                }
            }
        }
        private bool InvulatifMatris(int[,] A)
        {
            int[,] C = new int[3, 3];


            islem(A, C);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j && C[i, j] != 1)
                        return false;
                    if (i != j && C[i, j] != 0)
                        return false;
                }
            }
            return true;
        }
        private void islem(int[,] A, int[,] C)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                        C[i, j] += A[i, k] * A[k, j];
                }
            }
        }

        static readonly int N = 3;

        static void islem(int[,] A, int[,] temp, int p, int q, int n)
        {
            int i = 0, j = 0;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {

                    if (row != p && col != q)
                    {
                        temp[i, j++] = A[row, col];


                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }


        static int determinant(int[,] A, int n)
        {
            int D = 0;
            if (n == 1)
                return A[0, 0];

            int[,] temp = new int[N, N];

            int sign = 1;
            for (int f = 0; f < n; f++)
            {

                islem(A, temp, 0, f, n);
                D += sign * A[0, f] * determinant(temp, n - 1);


                sign = -sign;
            }
            return D;
        }


        static void Bitisik(int[,] A, int[,] adj)
        {
            if (N == 1)
            {
                adj[0, 0] = 1;
                return;
            }


            int sign = 1;
            int[,] temp = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    islem(A, temp, i, j, N);


                    sign = ((i + j) % 2 == 0) ? 1 : -1;


                    adj[j, i] = (sign) * (determinant(temp, N - 1));
                }
            }
        }


        static bool islemTers(int[,] A, float[,] ters)
        {
            int det = determinant(A, N);
            if (det == 0)
            {
                MessageBox.Show("determinantı 0 olan matrislerin tersi yoktur.");
                return false;
            }


            int[,] adj = new int[N, N];
            Bitisik(A, adj);


            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    ters[i, j] = adj[i, j] / (float)det;

            return true;
        }


        
        static void display(float[,] A)
        {
            MessageBox.Show("Matrisin Tersi:\n " + A[0, 0] + "\t" + A[0, 1] + "\t" + A[0, 2] + "\n" + A[1, 0] + "\t" + A[1, 1] + "\t" + A[1, 2] + "\t" + "\n" + A[2, 0] + "\t" + A[2, 1] + "\t" + A[2, 2] + "\n");

        }
        private void btnTers_Click(object sender, EventArgs e)
        {
            if (txt11.Text == "" || txt12.Text == "" || txt13.Text == "" || txt21.Text == "" || txt22.Text == "" || txt23.Text == "" || txt31.Text == "" || txt32.Text == "" || txt33.Text == "")
            {
                MessageBox.Show("Lütfen A matrisinde boş alan bırakmayınız!!!");
            }
            else
            {
                int text11 = Convert.ToInt32(txt11.Text);

                int text12 = Convert.ToInt32(txt12.Text);

                int text13 = Convert.ToInt32(txt13.Text);

                int text21 = Convert.ToInt32(txt21.Text);

                int text22 = Convert.ToInt32(txt22.Text);

                int text23 = Convert.ToInt32(txt23.Text);

                int text31 = Convert.ToInt32(txt31.Text);

                int text32 = Convert.ToInt32(txt32.Text);

                int text33 = Convert.ToInt32(txt33.Text);


                int[,] A = new int[10, 10];
                int[,] C = new int[10, 10];
                A[0, 0] = text11;
                A[0, 1] = text12;
                A[0, 2] = text13;
                A[1, 0] = text21;
                A[1, 1] = text22;
                A[1, 2] = text23;
                A[2, 0] = text31;
                A[2, 1] = text32;
                A[2, 2] = text33;

                int[,] adj = new int[N, N];

                float[,] inv = new float[N, N];


                if (islemTers(A, inv))
                    display(inv);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt11.Clear();
            txt11a.Clear();
            txt12.Clear();
            txt12a.Clear();
            txt13.Clear();
            txt13a.Clear();
            txt21.Clear();
            txt21a.Clear();
            txt22.Clear();
            txt22a.Clear();
            txt23.Clear();
            txt23a.Clear();
            txt31.Clear();
            txt31a.Clear();
            txt32.Clear();
            txt32a.Clear();
            txt33.Clear();
            txt33a.Clear();
          
        }
    }
}
