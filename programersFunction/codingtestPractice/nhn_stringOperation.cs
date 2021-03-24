using System.Linq;

namespace programersFunction.codingtestPractice
{
    public class nhn_stringOperation
    {
        // RG(B(2G)) -> RG(B(GG)) RG(BGBG) -> RGB GGG BGG
        // R(G(B)R) -> R(GBR) -> RGR BRR
        // 3R(B2G(R2B)) -> RRR BRG RGR RRG RBR GRB
        // R(G(2B(GB)B(GB))) -> RGR BRG RBR GRG RGR BRG RBR GRB RGR GRG RBR GRB
        // 
        public string sulotion(string RGB)
        {
            string answer = "";

            string operatedString = PlusOperation(RGB);
            //RRR(BGG(RBB))
            answer = Multiplication(operatedString);    

            return answer;
        }

        private string Multiplication(string operatedString)
        {
            string result = "";
            string middleOperation = "";
            int idxOfCloseBracket = 0;
            int idxOfLastOpenBracket = 0;
            
            idxOfLastOpenBracket = operatedString.LastIndexOf('(');
            
            char[] splitStringToCharArr = (operatedString.Substring(idxOfLastOpenBracket-1, operatedString.Length - idxOfLastOpenBracket+1)).ToCharArray();

            foreach(var character in splitStringToCharArr)
            {
                if (character == ')')
                    break;
                idxOfCloseBracket++;
            }

            for(int i = 1; i< idxOfCloseBracket; i++)
            {   
                if(splitStringToCharArr[i] != '(')
                {
                    middleOperation += splitStringToCharArr[0];
                    middleOperation += splitStringToCharArr[i];
                }
            }
            
            idxOfCloseBracket += idxOfLastOpenBracket;

            result = operatedString.Substring(0, idxOfLastOpenBracket - 1) + middleOperation + operatedString.Substring(idxOfCloseBracket,operatedString.Length - idxOfCloseBracket);

            if (!result.Contains('('))
                return result;
            //RGB GGG BGG

            //RGR BRR

            //RRR BRG RGR RRG RBR GRB

            //RGR BRG RBR GRG RGR BRG RBR GRB RGR GRG RBR GRB
          
            return Multiplication(result); 
        }

        private string PlusOperation(string RGB)
        {
            string result = "";
            char[] splitstrToArr = RGB.ToCharArray();
            
            for(int i = 0; i<splitstrToArr.Length; i++)
            {
                //if ((int)splitstrToArr[i] < 39 && (int)splitstrToArr[i] >82)
                if (splitstrToArr[i] != 'R' && splitstrToArr[i] != 'G' && splitstrToArr[i] != 'B' && splitstrToArr[i] != '(' && splitstrToArr[i] != ')')
                {
                    int portion = (int)char.GetNumericValue(splitstrToArr[i]);
                    
                    for (int j = 0; j < portion; j++)
                    {
                        result += splitstrToArr[i + 1];
                    }
                    
                    i++;
                }
                else
                    result += splitstrToArr[i];
            }

            return result;
        }
    }
}
