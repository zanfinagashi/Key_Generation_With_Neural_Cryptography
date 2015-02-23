using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Key_Generation_With_Neural_Cryptography
{
    public partial class NeuralCryptographyForm : Form
    {
        const string _string="ABCDEFGHIJKLMNOPQRSTUVWXYZ_012345678";
        public NeuralCryptographyForm()
        {
            InitializeComponent();

           
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


             nud_K.Value = 12;
             nud_N.Value = 5;
             nud_L.Value = 6;


         
           
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgv_A.Rows.Clear();
            dgv_B.Rows.Clear();

            int K = (int)nud_K.Value,
                N = (int)nud_N.Value,
                L = (int)nud_L.Value;

            object[] dataA = new object[K * N];
            object[] dataB = new object[K * N];

            for (int i = 0; i < N; i++)
            {
                dgv_A.Columns.Add("", "");
                dgv_B.Columns.Add("", "");
            }

            NeuralCryptography A = new NeuralCryptography(K, L, N);
            NeuralCryptography B = new NeuralCryptography(K, L, N);
            InputVector inpV = new InputVector();

            A.IntAll();
            B.IntAll();

            A.RandomWeight(false);
            B.RandomWeight(true);

            int difference = calculateWeightDifference(A, B);

            string result = "Failed";
            int steps = 0;


            while (difference != 0)
            {
                
                inpV.inputVector(K * N);
                A.CountOutput(inpV.input);
                B.CountOutput(inpV.input);

                if (A.output == B.output)
                {
                    A.UpdateWeights(inpV.input);
                    B.UpdateWeights(inpV.input);
                    difference = calculateWeightDifference(A, B);


                    dgv_A.Rows.Clear();
                    dgv_B.Rows.Clear();

                    for (int i = 0; i < K; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            {
                                dataA[j] = A.w[i * N + j];
                                dataB[j] = B.w[i * N + j];

                            }


                        }

                        dgv_A.Rows.Add(dataA);
                        dgv_B.Rows.Add(dataB);
                        
                    }

                    //this.Refresh();
                    
                   
                    if (difference == 0)
                    { 
                        result = "Success"; 
                        break; 
                    }
                }

                steps++;
            }

            int key_size = _string.Length / (A.L * 2 + 1);
            int key_length = A.K * A.N / key_size;

            for (int i = 1; i < key_length; i++)
            {
                int k = 1;
                for (int j = (i-1)*key_size; j < i*key_size -1; j++)
                {
                    k = k + A.w[j] + A.L;
                    txt_Key.Text = txt_Key.Text + _string[k];
                }
                
            }

            txt_Status.Text = "Status:" + result + "\r\n Number of iterations:" + steps;
                    
         

        }


        static int calculateWeightDifference(NeuralCryptography X, NeuralCryptography Y)
        {
            int difference = 0;
            for (int i = 0; i < X.K * X.N - 1; i++)
            {
                difference = difference + Math.Abs(X.w[i] - Y.w[i]);
            }
            return difference;
        }

       
    }

    
}
