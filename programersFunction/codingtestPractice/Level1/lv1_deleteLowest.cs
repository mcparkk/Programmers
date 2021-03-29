using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice
{
    public class lv1_deleteLowest
    {
        public int[] solution(int[] arr)
        {
            int lowestNum = arr.Min();
            List<int> resultList = new List<int>();
            
            if(arr.Length == 1)
            {
                resultList.Add(-1);
                return resultList.ToArray();
            }

            foreach(int num in arr)
            {
                if (num != lowestNum)
                    resultList.Add(num);
            }

            if (resultList.Count() < 1)
                resultList.Add(-1);

            return resultList.ToArray();
        }
    }
}
