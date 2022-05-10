using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class AlgorithmOne : IAlgoInt
    {
        //Algorithm implementation meant to solve Problem 1 proposed by mihaigpm in his algorithms-codingchallenge repo.
        private int[] inputArray;
        public AlgorithmOne(int[] arr)
        {
            inputArray = arr;
        }
        public int Solve()
        {
            int sum = 0;
            foreach (int number in inputArray)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
