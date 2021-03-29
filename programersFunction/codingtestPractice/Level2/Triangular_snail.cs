using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class Triangular_snail
    {
        public int[] solution(int n)
        {
            // 가변배열 
            int[][] resultArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                resultArray[i] = new int[i + 1];
            }

            int addNum = 1;
            int addCount = n;
            int addColIndex = 0;
            int addRowIndex = 0;

            // 반복 
            while (addCount > 0)
            {
                // 아래로 채우는 로직 
                for (int i = 0; i < addCount; i++)
                {
                    resultArray[addColIndex][addRowIndex] = addNum;
                    addNum++;
                    addColIndex++;
                }
                addCount--;
                addColIndex--;

                // 오른쪽으로 채우는 로직
                for (int i = 0 ; i < addCount; i++)
                {
                    resultArray[addColIndex][addRowIndex + 1] = addNum;
                    addNum++;
                    addRowIndex++;
                }
                addCount--;
                addColIndex--;
                addRowIndex--;

                // 위로 채우는 로직 
                for (int i = addCount; i > 0; i--)
                {
                    resultArray[addColIndex][addRowIndex] = addNum;
                    addNum++;
                    addColIndex--;
                    addRowIndex--;
                }
                addCount--;
                addColIndex += 2;
                addRowIndex += 1;
            }
            
            List<int> answerList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                foreach (var num in resultArray[i])
                    answerList.Add(num);
            }

            return answerList.ToArray();
        }
    }
}
