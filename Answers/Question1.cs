using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(int[] portfolios)
        {
            Array.Sort(portfolios); 
      
            ushort maxXor = ushort.MinValue;
            for(int i = 0; i < portfolios.Length - 1; i++)
                maxXor = Math.Max(maxXor, (ushort)(portfolios[i] ^ portfolios[i + 1])); 

            return maxXor; 
        }
    }
}
