using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.Monthly_Code_Challenge
{
    public class bracketTrun
    {
        public int solution(string s)
        {
            int answer = 0;
            var casesOfBracketTurn = GetBracketTurnList(s);
            foreach(var caseOfBracketTurn in casesOfBracketTurn)
                answer += CheckingCorrectBracket(caseOfBracketTurn);
            return answer;
        }

        // 만들수 있는 문자열 리스트에 저장 후 반환 
        private List<string> GetBracketTurnList(string s)
        {
            List<string> resultList = new List<string>();
            resultList.Add(s);

            char temp;
            for (int i = 0; i < s.Length - 1; i++)
            {
                temp = s[0];
                s = s.Substring(1, s.Length - 1) + temp;
                resultList.Add(s);
            }

            return resultList;
        }

        // 문자열 검증 후 결과 반환 
        private int CheckingCorrectBracket(string s)
        {
            Stack<char> bracketStack = new Stack<char>();
            bracketStack.Push('-');
            
            foreach (var bracket in s)
            {
                if (bracket == '{' || bracket == '(' || bracket == '[')
                    bracketStack.Push(bracket);
                else
                {
                    if (bracket == '}')
                    {
                        if (bracketStack.Peek() == '{') bracketStack.Pop();
                        else return 0;
                    }
                    else if (bracket == ')')
                    {
                        if (bracketStack.Peek() == '(') bracketStack.Pop();
                        else return 0;
                    }
                    else if (bracket == ']')
                    {
                        if (bracketStack.Peek() == '[') bracketStack.Pop();
                        else return 0;
                    }
                }

                if (bracketStack.Count < 1)
                    return 0;
            }
            if (bracketStack.Count != 1)
                return 0;

            return 1;
        }
    }
}
