using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_cipher
    {
        public string solution(string s, int n)
        {
            string answer = "";

            foreach(char a in s)
            {
                int character = (int)a;
                if (65 <= character && character <= 90)
                {
                    int replaceCharater = (character + n) > 90 ? (character+n)-26: character + n;
                    answer += (char)replaceCharater;
                }
                else if (97 <= character && character <= 122)
                {
                    int replaceCharater = (character + n) > 122 ? (character + n) - 26 : character + n;
                    answer += (char)replaceCharater;
                }
                else
                    answer += a.ToString();
            }
            
            return answer;
        }
    }
}
