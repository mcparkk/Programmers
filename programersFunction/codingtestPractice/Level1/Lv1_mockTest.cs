using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace programersMain
{
    public class Lv1_mockTest
    {
        public int[] solution(int[] answers)
        {
            int[] answer = new int[] { };
            int countOfAnswer = answers.Count();

            int[] patternOfStudent_1 = { 1, 2, 3, 4, 5 };
            int[] patternOfStudent_2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] patternOfStudent_3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[][] groupOfPattern = { patternOfStudent_1, patternOfStudent_2, patternOfStudent_3 };
            
            Dictionary<int,int> countsOfCorrect = new Dictionary<int, int>();

            for (int i = 0; i < groupOfPattern.Count(); i++)
            {
                int countOfCorrectAnswer = 0;
                for (int j = 0; j < countOfAnswer; j++)
                {
                    if (answers[j] == groupOfPattern[i][j % groupOfPattern[i].Count()])
                    {
                        countOfCorrectAnswer++;
                    }
                }
                countsOfCorrect.Add(i+1, countOfCorrectAnswer);
            }

            var turnOfWin = countsOfCorrect.OrderByDescending(x => x.Value).First();
            int maxValue = turnOfWin.Value;
            var student = countsOfCorrect.Where(x => x.Value == maxValue).Select(x=>x.Key);

            answer = student.ToArray();
            
            return answer;
        }

    }
}
