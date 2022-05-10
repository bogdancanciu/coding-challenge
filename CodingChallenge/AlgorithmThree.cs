using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    public class AlgorithmThree : IAlgoString
    {
        //Algorithm implementation meant to solve Problem 3 proposed by mihaigpm in his algorithms-codingchallenge repo.
        private Stack<char> firstStack;
        private Stack<char> secondStack;
        public AlgorithmThree(Stack<char> s1, Stack<char> s2)
        {
            firstStack = s1;
            secondStack = s2;
        }
        public string Solve()
        {
            string lexMin = "";
            while (firstStack.Count != 0 && secondStack.Count != 0)
            {
                if (firstStack.Peek() <= secondStack.Peek())
                {
                    lexMin += firstStack.Pop();
                }
                else
                {
                    lexMin += secondStack.Pop();
                }
            }
            if (firstStack.Count != 0)
            {
                while (firstStack.Count != 0)
                {
                    lexMin += firstStack.Pop();
                }
            }
            else
            {
                while (secondStack.Count != 0)
                {
                    lexMin += secondStack.Pop();
                }
            }
            return lexMin;
        }
    }
}
