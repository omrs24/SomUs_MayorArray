using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomUs_MayorArray
{
    internal class MaxNum
    {
        int[] InputArray;
        public MaxNum(int[] int_array) 
        {
            this.InputArray = int_array;
        }

        public int GetMaxArrayNum()
        {
            int maxval = 0;
            for (int i = 0; i < InputArray.Length; i++)
            {
                if (InputArray[i] > maxval)
                {
                    maxval = InputArray[i];
                }
            }

            return maxval;

        }

    }
}
