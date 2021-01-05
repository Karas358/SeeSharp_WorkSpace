using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace
{
    public class CountSay
    {
        public string countAndSay(int num)
        { 
            string seq = "1";
            if(0 < num && num < 31)
            {
                if (num == 1) return seq;
                
                StringBuilder sb = new StringBuilder();
                for(int x = 0; x < num - 1; x++)
                {   
                    int leftCur = 0, rightCur = 0;
                    char[] charSeq = seq.ToCharArray();
                    int counter = 0;
                    while(rightCur < charSeq.Length)
                    {
                        if(charSeq[leftCur] == charSeq[rightCur])
                        {
                            counter++;
                        }
                        else if(rightCur > charSeq.Length && charSeq[leftCur] != charSeq[rightCur])
                        {
                            leftCur = rightCur; 
                            sb.Append(counter).Append(charSeq[leftCur]);
                            seq = sb.ToString();
                            sb.Clear();
                        }
                        rightCur++;
                    }
                }
                return seq;
            }
            return "0";
        }
    }
}
