using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice.Level2
{
    public class Truct_Passing_Bridge
    { 
        public int solution(int bridge_length, int weight, int[] truck_weights)
        {
            // 다리 위의 트럭 Queue
            Queue<int> trucksOnBridge = new Queue<int>(0);
            Stack<int> waitingStack = new Stack<int>(truck_weights.Reverse());

            for (int i = 0; i < bridge_length; i++)
                trucksOnBridge.Enqueue(0);

            // 경과 시간 
            int time = 0;
            // 다리 위 무게
            int weightOnBridge = 0;

            while (true)
            {
                if (waitingStack.Count() == 0)
                {
                    time += bridge_length;
                    break;
                }

                if(trucksOnBridge.Peek() != 0)
                    weightOnBridge -= trucksOnBridge.Dequeue();
                else
                    trucksOnBridge.Dequeue();

                if (weightOnBridge + waitingStack.Peek() <= weight)
                {
                    weightOnBridge += waitingStack.Peek();
                    trucksOnBridge.Enqueue(waitingStack.Pop());
                }
                else
                    trucksOnBridge.Enqueue(0);

                time++;
            }

            return time;
        }
    }
}
