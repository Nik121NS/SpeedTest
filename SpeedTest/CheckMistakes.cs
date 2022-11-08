using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    internal static class CheckMistakes
    {
        public static int Result(string textUser, string textBD)
        {
           
            int symbolsCount = 0;
            if(textUser.Length != 0)
            {
                
                for (int i = 0; i < textUser.Length; i++)
                {
                    if (textBD[i] == textUser[i])
                    {
                        symbolsCount++;
                    }
                    
                }
            }
            else
            {
               
            }
            
            return symbolsCount;
        }
    }
}
