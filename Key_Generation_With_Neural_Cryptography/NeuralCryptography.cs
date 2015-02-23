using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Key_Generation_With_Neural_Cryptography
{
    class NeuralCryptography
    {
        public int K { get; set; }
        public int L { get; set; }
        public int N { get; set; }

        public NeuralCryptography(int k, int l, int n)
        {
            this.K = k;
            this.L = l;
            this.N = n;            
        }

        public int[] w,h;
        public int output;    

        public void CountOutput(int[] X)
        {
            int sum;
            output = 1;
            for (int i = 0; i < K; i++)
            {
                sum = 0;

                for (int j = 0; j < N; j++)
                {
                    sum = sum + w[i * N + j] * X[i * N + j];
                    h[i] = sign(sum);
                    output = output * sign(sum);
                    
                }
            }
        }        
        public void RandomWeight(bool test) 
        {
             Random r = new Random();
            for (int i = 0; i < K*N; i++)
            {
                if (test == false)
                    w[i] = L - r.Next(2 * L + 1);
                else
                {
                    w[i] = L - r.Next(2 * L + 1);
                    w[i] = L - r.Next(2 * L + 1);
                }

            }          
        }       
        public void UpdateWeights(int[] X)
        {
            int new_W;

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    new_W = w[i * N + j];
                    //Hebbian Leraning Rule
                    new_W = new_W + X[i * N + j] * output * Equale(output, h[i]) * Equale(output, output);

                    if (new_W > L)                    
                        new_W = L;

                    if (new_W < -L)
                        new_W = -L;

                    w[i * N + j] = new_W;
                    
                }
                
            }
        }        
        public void IntAll() 
        {
            w = new int[K*N];
            h = new int[K];
        }
        private int Equale(int x, int y)
        {
            if (x == y)
            {
                return 1;
            }

            else
                return 0;
        }
        private int sign(int value)
        {
            if (value > 0)
            
                return 1;
            
            else
                return -1;
        }
        
    }
}
