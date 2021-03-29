using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace programersMain
{
    public class lv2_fucnDev
    {
        // progresses = {93,30,55}
        // speeds = {1,30,5}
        // return = {2,1}

        public int[] OtherSolution(int[] progresses, int[] speeds)
        {
            int[] answer = new int[] { };
            //var temp = progresses.Select((item,idx)=>)
            var tmp = progresses.Select( (item, idx) => (int)Math.Ceiling((double)(100 - item) / speeds[idx]) );
            

            List<int> deploy = new List<int>();
            List<int> Remains = new List<int>();

            int lastBig = -1;

            foreach (int itm in tmp)
            {
                if (lastBig < itm)
                    lastBig = itm;

                deploy.Add(lastBig);
            }
            var tmp2 = from itm in deploy
                       group itm by itm into g
                       select new
                       {
                           CNT = g.Count()
                       };
            
            answer = tmp2.Select(x => x.CNT).ToArray();

            return answer;
        }

        public int[] Mysolution(int[] progresses, int[] speeds)
        {

            List<int> result = new List<int>();
            Queue<int> completeDays = new Queue<int>();

            int countOfProgresses = progresses.Count();

            for (int i = 0; i < countOfProgresses; i++)
            {
                int completableDay = 0;
                while(progresses[i] < 100)
                {
                    progresses[i] += speeds[i];
                    completableDay++;
                }
                completeDays.Enqueue(completableDay);
            }
         
            int count = 1;
            int NowDay = completeDays.Dequeue();

            while (completeDays.Count() > 0)
            {
                int NextDay = completeDays.Dequeue();
                if(completeDays.Count() == 0)
                {
                    if (NowDay >= NextDay)
                    {
                        count++;
                        result.Add(count);
                    }
                    else
                    {
                        result.Add(count);
                        count=1;
                        result.Add(count);
                    }
                }
                else if(NowDay < NextDay)
                {
                    NowDay = NextDay;
                    result.Add(count);
                    count = 1;
                }
                else if(NowDay >= NextDay)
                {
                    count++;
                }
            }

            int[] answer = new int[result.Count];
            answer = result.ToArray();

            return answer;
        }
    }
}
