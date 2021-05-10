using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class Delivery
    {
        public int solution(int N, int[,] road, int K)
        {
            HashSet<int> resultSet = new HashSet<int>();
            List<List<int>> roadIndexList = new List<List<int>>();

            for(int i = 0; i < road.GetLength(0); i++)
            {
                roadIndexList.Add(new List<int>());
                for(int j = 0; j < 3; j++)
                    roadIndexList[i].Add(road[i, j]);
            }

            for(int i =0; i< road.GetLength(0); i++)
            {
                if (road[i,0] == 1 || road[i,1] == 1)
                {
                    int searchingVliage = road
                    SearchingRoad(, road, K, ref resultSet);
                }
            }

            return resultSet.Count;
        }

        private void SearchingRoad(int searchingIndex, int[,] road, int k, ref HashSet<int> resultSet)
        {
            road[searchingIndex,0]
        }
    }
}
