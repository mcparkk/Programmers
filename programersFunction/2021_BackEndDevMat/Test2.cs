using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice._2021_BackEndDevMat
{
    public class Test2
    {
        public int[] solution(int rows, int columns, int[,] queries)
        {
            List<int> resultList = new List<int>();
            List<List<int>> listOfQueries = new List<List<int>>();

            // map 초기화
            int[,] maps = new int[rows, columns];


            // 행렬 생성 
            int inputNum = 1;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    maps[i, j] = inputNum;
                    inputNum++;
                }
            }

            //Queries 나누기
            for (int i = 0; i < queries.Length / 4; i++)
            {
                listOfQueries.Add(new List<int>());

                for (int j = 0; j < 4; j++)
                    listOfQueries[i].Add(queries[i, j]);
            }

            
            foreach(var list in listOfQueries)
                resultList.Add(trySpin(list, ref maps));
            
            return resultList.ToArray();
        }

        // 회전을 진행하고 가장 작은수 return 
        private int trySpin(List<int> queriesRow, ref int[,] maps)
        {
            int startX = queriesRow[0]-1;
            int startY = queriesRow[1]-1;
            int endX = queriesRow[2]-1;
            int endY = queriesRow[3]-1;

            List<int> listOfnumbers = new List<int>();
            int temp = 0;
            int nowNum = 0;

            // 오른쪽으로 
            for(int i = startY; i <= endY; i++)
            {
                nowNum = maps[startX, i];
                maps[startX, i] = temp;
                temp = nowNum;
                listOfnumbers.Add(temp);
            }

            // 아래로
            for(int i = startX+1; i<= endX; i++)
            {
                nowNum = maps[i, endY];
                maps[i, endY] = temp;
                temp = nowNum;
                listOfnumbers.Add(temp);
            }

            // 왼쪽으로 
            for(int i = endY-1; i >=startY; i--)
            {
                nowNum = maps[endX, i];
                maps[endX, i] = temp;
                temp = nowNum;
                listOfnumbers.Add(temp);
            }

            // 위로 
            for(int i = endX-1; i>=startX; i--)
            {
                nowNum = maps[i, startY];
                maps[i, startY] = temp;
                temp = nowNum;
                if(temp != 0)
                    listOfnumbers.Add(temp);
            }

            return listOfnumbers.Min();
        }
    }
}
