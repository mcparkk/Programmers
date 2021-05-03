using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Meister
{
    public class GameMap
    {
        int[][,] searchingIndex = new int[4][,]
        {
            new int[,] {{-1, 0}},
            new int[,] {{0, -1}},
            new int[,] {{0, 1}},
            new int[,] {{1, 0}},
        };

        int mapsXLength = 0;
        int mapsYLength = 0;

        public int solution(int[,] maps)
        {
            mapsXLength = maps.GetLength(1);
            mapsYLength = maps.GetLength(0);
            int answer = 0;
            FineRoad(maps, 0, 0, mapsXLength, mapsYLength, searchingIndex, 0);
            answer = 4;
            return answer;
        }

        public void FineRoad(int[,] maps, int nowXIndex, int nowYIndex, int xlen, int ylen, int[][,] nextIndex , int answerCount)
        {
            if (nowXIndex == xlen && nowYIndex == ylen)
                return;
            else
            {
                maps[nowXIndex, nowYIndex] = 2;

                for (int i = 0; i < 4; i++)
                {
                    int nextSearchXIndex = nowXIndex + nextIndex[i][0, 1];
                    int nextSearchYIndex = nowYIndex + nextIndex[i][0, 0];

                    if (nextSearchXIndex >= 0 && nextSearchXIndex < xlen 
                        && nextSearchYIndex >= 0 && nextSearchYIndex < ylen 
                        && maps[nextSearchXIndex, nextSearchYIndex] != 2 
                        && maps[nextSearchXIndex, nextSearchYIndex] != 0)
                    {
                        answerCount++;
                        FineRoad(maps, nextSearchXIndex, nextSearchYIndex, xlen, ylen, nextIndex, answerCount);
                    }
                }
                return;
            }
        }
    }
}
