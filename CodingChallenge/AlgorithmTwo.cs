using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class AlgorithmTwo : IAlgoChar
    {
        //Algorithm implementation meant to solve Problem 2 proposed by mihaigpm in his algorithms-codingchallenge repo.
        private char[] inputArray;
        public AlgorithmTwo(char[] arr)
        {
            inputArray = arr;
        }
        public char Solve()
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i + 1] - inputArray[i] != 1)
                {
                    return (char)(inputArray[i] + 1);
                }
            }
            return '0';
        }
    }
}
