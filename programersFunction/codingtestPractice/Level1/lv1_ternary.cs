using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice
{
    public class lv1_ternary
    {
        public int solution(int n)
        {
            int answer = 0;
            int multiple = 1;
            
            Stack<int> portionStack = new Stack<int>();
            
            while(true)
            {
                if (n < 3)
                {
                    portionStack.Push(n);
                    break;
                }

                portionStack.Push(n % 3);
                n = n / 3;
            }

            answer += portionStack.Pop() * multiple;

            while(portionStack.Count>0)
            {
                multiple *= 3;
                answer += portionStack.Pop() * multiple;
            }

            return answer;
        }
    }
}
