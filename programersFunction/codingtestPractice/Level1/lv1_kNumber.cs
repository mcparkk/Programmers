using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_kNumber
    {
        public int[] solution(int[] array, int[,] commands)
        {
            //int[] array = new int[] { 1, 5, 2, 6, 3, 7, 4 };
            //int[,] commands = new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int[] answer = new int[] { };
            int countOfcommans = commands.Length / 3;
            List<int> result = new List<int>();

            for(int i = 0; i<countOfcommans; i++)
            {
                int idxStart = commands[i, 0] -1;
                int idxEnd = commands[i, 1] -1;
                int idxSelect = commands[i, 2] -1;
                List<int> replaceArray = new List<int>();

                for(int idx = idxStart; idx <= idxEnd; idx++)
                {
                    replaceArray.Add(array[idx]);
                }
                replaceArray.Sort();
                result.Add(replaceArray[idxSelect]);
            }
            answer = result.ToArray();

            return answer;
        }
    }
}
