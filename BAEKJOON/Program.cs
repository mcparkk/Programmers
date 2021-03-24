using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAEKJOON
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputStringArr = new string[n];

            for(int i = 0; i<inputStringArr.Length; i++)
                inputStringArr[i] = Console.ReadLine();

            foreach(string item in inputStringArr)
            {
                string result = function(item);

                Console.WriteLine(result);
            }
        }

        private static string function(string item)
        {
            string answer = "YES";
            char[] bracketArr = item.ToCharArray();
            Stack<char> charStack = new Stack<char>();

            foreach(char bracket in bracketArr)
            {
                if (bracket == '(')
                    charStack.Push(bracket);
                else
                {
                    if (charStack.Count() == 0)
                    {
                        return "NO";
                    }
                    charStack.Pop();
                }
            }
            if (charStack.Count() != 0)
                return "NO";
                    
            return answer;
        }
        
    }
}
