using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class Create_Large_Number
    {
        public string solution(string number, int k)
        {
            number = "9" + number;
            int index = 0;

            for (int i = 0; i < k; i++)
            {
                // -> 앞에서부터 최대한 지울수 있는 만큼 지우자
                while(true)
                {
                    if(number[index] < number[index+1])
                    {
                        number = number.Remove(index, 1);
                        index--;
                        break;
                    }
                    index++;
                }
            }
            return number.Remove(0,1);
        }
    
    public string Anothersolution(string number, int k)
        {
            string answer = "";
            number = "9" + number;
            StringBuilder sb = new StringBuilder(number);

            int index = 0;
            for (int i = 0; i < k; i++)
            {
                while (true)
                {
                    if (index + 1 == sb.Length)
                    {
                        sb.Remove(index, 1);
                        index--;
                        break;
                    }

                    if (sb[index] < sb[index + 1])
                    {
                        sb.Remove(index, 1);
                        index--;
                        break;
                    }
                    index++;
                }
            }

            return answer = sb.Remove(0, 1).ToString();
        }
        
        // 요것도 시간초과!!!!! 루이ㅏㅁㄴ룽ㄴ미ㅜ린물눔;ㅣㄹㅇ니;ㅜㄴ마ㅜ인;
        // c++ 로는 통과... 
        public string Failsolution2(string number, int k)
        {
            string answer = "";
            char max = number[0];
            int index = 0;
            
            for(int i = 0;  i< number.Length - k; i++)
            {
                // 그리디 알고리즘 -> 어차피 지울 수 있는 최대 범위는 K이기 때문에 k만큼만 탐색
                for(int j = index; j <= k+i; j++)
                {
                    if(max < number[j] || number[j] == 9)
                    {
                        max = number[j];
                        index = j;
                    }
                }
                answer += (char)max;
                index++;
                if(index < number.Length)
                    max = number[index];
            }
            return answer;
        }
        
        // 시간초과!!!!!!!!!!!!!!!!!!!!!!! ㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠㅠ
        public string Failsolution(string number, int k)
        {
            string answer = "";

            char max = number[0];
            int indexOfSearch = 0;
            int answerLenght = number.Length - k;

            for(int i = 0; i < answerLenght; i++)
            {
                int searchLen = indexOfSearch + k;
                for (int j = indexOfSearch; j < searchLen; j++)
                {
                    if (max < number[j + 1])
                    {
                        max = number[j + 1];
                        indexOfSearch = j + 1;
                    }

                    // 지운 수만큼 K 차감 
                    if (j+1 == searchLen)
                        k = j - (indexOfSearch-1);
                }
                // answer에 추가
                answer += max.ToString();
                // 다음 색인부터 찾기위해 index++
                indexOfSearch++;
                // 다음 for문의 시작 max값 미리 셋팅
                if(indexOfSearch != number.Length)
                    max = number[indexOfSearch];
            }

            return answer;
        }

    }
}
