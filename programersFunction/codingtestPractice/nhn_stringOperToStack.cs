using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programersFunction.codingtestPractice
{
    public class nhn_stringOperToStack
    {
        // RG(B(2G)) -> RG(B(GG)) RG(BGBG) -> RGB GGG BGG
        // R(G(B)R) -> R(GBR) -> RGR BRR
        // 3R(B2G(R2B)) -> RRR BRG RGR RRG RBR GRB
        // R(G(2B(GB)B(GB))) -> RGR BRG RBR GRG RGR BRG RBR GRB RGR GRG RBR GRB
        // 2(B(GG))         -> BBGBG
        public string sulotion(string RGB)
        {
            string answer = "";

            Stack<string> bracketStack = new Stack<string>();


           
            return answer;
        }
    }
}
