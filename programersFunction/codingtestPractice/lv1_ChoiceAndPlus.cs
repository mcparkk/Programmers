using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice
{
    public class lv1_ChoiceAndPlus
    {
        public int[] solution(int[] numbers)
        {
            int[] answer = new int[] { };
            List<int> AllOfAnswer = new List<int>();

            for(int i = 0; i<numbers.Length; i++)
            {
                for(int j = i+1; j<numbers.Length; j++)
                {
                    AllOfAnswer.Add(numbers[i] + numbers[j]);
                }
            }
            
            AllOfAnswer.Sort();
            answer = AllOfAnswer.Distinct().ToArray();
            
            return answer;
        }
    }
}
