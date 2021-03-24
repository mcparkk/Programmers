using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_Greedy_gymClothes
    {
        public int solution(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            List<int> students = new List<int>();

            for(int i = 0; i <n; i++)
                students.Add(1);

            foreach(var idx in lost)
                students[idx-1] -= 1;
             
            foreach(var idx in reserve)
                students[idx-1] += 1;

            for(int j = students.Count()-1; j > 0; j--)
            {
                if(students[j] > 1 && students[j-1] < 1)
                {
                    students[j - 1] += 1;
                    students[j] -= 1;
                }
            }
            
            for(int i = 0; i < students.Count()-1; i++)
            {
               if(students[i] > 1 && students[i+1] < 1)
                {
                    students[i + 1] += 1;
                    students[i] -= 1; 
                }
            }

            answer = students.Where(x => x > 0).Count();

            return answer;
        }
    }
}
