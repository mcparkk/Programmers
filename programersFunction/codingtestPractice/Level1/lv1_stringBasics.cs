using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersMain
{
    public class lv1_stringBasics
    {
        public bool solution(string s)
        {
            bool answer = true;

            if (s.Length == 4 || s.Length == 6)
            {
                foreach (var character in s)
                {
                    int charToASCII = (int)character;
                    answer = charToASCII >= 48 && charToASCII <= 57 ? true : false;
                    if (answer == false)
                        return answer;
                }
            }
            else
                answer = false;
            return answer;
        }
    }
}
