using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Key_Generation_With_Neural_Cryptography
{
    class InputVector
    {

        public int[] input;
        public void inputVector(int length)
        {
            input = new int[length];
            Random r = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                if (r.Next(0, 2) == 0)
                    input[i] = -1;
                else
                {
                    input[i] = 1;

                }
            }
        }

    }
}
