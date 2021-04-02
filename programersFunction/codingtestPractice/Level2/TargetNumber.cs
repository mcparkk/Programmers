using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class TargetNumber
    {
        private int answer = 0;

        public int solution(int[] numbers, int target)
        {
            Dfs(numbers, target, 0, 0);
            return answer;
        }

        private void Dfs(int[] numbers, int target, int idx, int value)
        {
            if (idx == numbers.Length)
            {
                if (target == value)
                    answer++;
                return;
            }

            Dfs(numbers, target, idx + 1, value + numbers[idx]);
            Dfs(numbers, target, idx + 1, value - numbers[idx]);
        }

        // 다른 사람의 풀이 
        public int solution2(int[] numbers, int target)
        {
            int answer = 0;
            List<int> lstFrom = new List<int>(new int[] { 0 });
            List<int> lstTo = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (var num in lstFrom)
                {
                    lstTo.Add(num + numbers[i]);
                    lstTo.Add(num - numbers[i]);
                }
                lstFrom.Clear();
                lstFrom.AddRange(lstTo.ToArray());
                lstTo.Clear();
            }
            answer = lstFrom.Where(x => x == target).Count();
            return answer;
        }
    }
}
