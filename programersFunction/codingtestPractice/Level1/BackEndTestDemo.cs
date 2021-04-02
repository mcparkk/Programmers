using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level1
{
    public class BackEndTestDemo
    {
        public int[] solution(int[,] v)
        {
            List<int> listOfX = new List<int>();
            List<int> listOfY = new List<int>();
            Stack<int> stackOfX = new Stack<int>();
            Stack<int> stackOfY = new Stack<int>();

            for(int i = 0; i<3; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    if (j % 2 == 0)
                    {
                        listOfX.Add(v[i, j]);
                    }
                    else
                    {
                        listOfY.Add(v[i, j]);
                    }
                }
            }

            var sortingOfListX = listOfX.OrderBy(x => x).ToArray();
            var sortingOfListY = listOfY.OrderBy(x => x).ToArray();

            for(int i = 0; i < sortingOfListX.Length; i++)
            {
                if (stackOfX.Count() != 0)
                {
                    if (stackOfX.Peek() == sortingOfListX[i])
                        stackOfX.Pop();
                    else
                        stackOfX.Push(sortingOfListX[i]);
                }
                else
                    stackOfX.Push(sortingOfListX[i]);
            }

            for (int i = 0; i < sortingOfListY.Length; i++)
            {
                if (stackOfY.Count() != 0)
                {
                    if (stackOfY.Peek() == sortingOfListY[i])
                        stackOfY.Pop();
                    else
                        stackOfY.Push(sortingOfListY[i]);
                }
                else
                    stackOfY.Push(sortingOfListY[i]);
            }
            int[] answer = { stackOfX.Pop(), stackOfY.Pop()};
            return answer;
        }
    }
}
