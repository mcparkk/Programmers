using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_StrangeString
    {
        public string solution(string s)
        {
            string answer = "";

            s = s.ToLower();
            string[] splitAnswer = s.Split(' ');

            for(int i = 0; i<splitAnswer.Count(); i++)
            {
                for(int j =0; j<splitAnswer[i].Length; j++)
                {
                    answer += j % 2 == 0 ? (char)(splitAnswer[i][j]-32) : splitAnswer[i][j];
                }
                if (answer.Length == s.Length)
                    return answer;
                answer += " ";
            }
            
            return answer;
        }
    }
}
