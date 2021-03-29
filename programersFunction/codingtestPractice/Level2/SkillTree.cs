using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class SkillTree
    {
        public int solution2(string skill, string[] skill_trees)
        {
            int answer = 0;

            for (int idx = 0; idx < skill_trees.Count(); idx++)
            {
                int checkPoint = skill_trees[idx].IndexOf(skill[0]);

                for (int j = 1; j < skill.Length; j++)
                {

                    checkPoint -= skill_trees[idx].IndexOf(skill[j]);

                    if (checkPoint > -1)
                    {
                        checkPoint = 1;
                        break;
                    }
                }
                if (checkPoint <= -1)
                    answer++;

            }
            return answer;
        }

        public int solution(string skill, string[] skill_trees)
        {
            int answer = 0;

            for (int idx = 0; idx < skill_trees.Count(); idx++)
            {
                bool isSkillable = true;
                int checkPoint = 0;
                for (int j = 0; j < skill.Length; j++)
                {
                    if (isSkillable == false)
                        break;
                    else if (skill_trees[idx].IndexOf(skill[j]) == -1)       // 중간에 없는 값이 하나라도 나오면 
                    {
                        for (int k = j + 1; k < skill.Length; k++)
                        {
                            if (skill_trees[idx].IndexOf(skill[k]) != -1)
                            {
                                isSkillable = false;
                                break;
                            }
                        }
                    }
                    // 아닐경우 일반 순환 
                    else
                    {
                        if (checkPoint > skill_trees[idx].IndexOf(skill[j]))
                        {
                            isSkillable = false;
                            break;
                        }
                        else
                            checkPoint = skill_trees[idx].IndexOf(skill[j]);
                    }
                }
                if (isSkillable)
                    answer++;

            }
            return answer;
        }
    }
}

