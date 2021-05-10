using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class NExpression
    {
        public int solution(int N, int number)
        {
            if (N == number) return 1;
            int answer = -1;

            List<HashSet<int>> setList = new List<HashSet<int>>();

            setList.Add(new HashSet<int> { N });

            int[] makingNumArray = { 1, 11, 111, 1111, 11111, 111111, 1111111};
            
            for(int i = 1; i <=8; i++)
            {
                HashSet<int> numSet = new HashSet<int>();
                
                // 이전 set에 사칙연산 
                foreach (int lastSetNums in setList[i-1])
                {
                    numSet.Add(lastSetNums + N);
                    numSet.Add(lastSetNums - N);
                    numSet.Add(lastSetNums * N);
                    numSet.Add(lastSetNums / N);
                    numSet.Add(N + lastSetNums);
                    numSet.Add(N - lastSetNums);
                    numSet.Add(N * lastSetNums);
                    if(lastSetNums != 0)
                        numSet.Add(N / lastSetNums);
                }

                // 단일 연산 
                int leftNum = 0;
                int rightNum = 0;
                for (int j = i; j >= 2; j--)
                {
                    leftNum = makingNumArray[i - j] * N;
                    rightNum = makingNumArray[j - 2] * N;

                    numSet.Add(leftNum + rightNum);
                    numSet.Add(leftNum - rightNum);
                    numSet.Add(leftNum * rightNum);
                    numSet.Add(leftNum / rightNum);
                }

                if (numSet.Contains(number))
                    return i;
                else
                    setList.Add(numSet);
            }

            return answer;
        }
    }
}
