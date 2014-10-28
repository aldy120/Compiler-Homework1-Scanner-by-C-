using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace compilerHw1
{
    class FiniteStateMachine
    {
        private static int[][] stateFunctionTable;
        public static bool isAccept(string theText)
        {
            int tempState=1;
            int theSymbolNum;
            int textLength=theText.Length;
            //char[] theTextChar = new char[textLength];
            
            for (int i = 0; i < textLength; i++)
            {
                if (theText[i] == ' ')
                    continue;

                theSymbolNum = classify(theText[i]);

                tempState = stateFunctionTable[tempState][theSymbolNum];
            }
            if (tempState == 2 || tempState == 4 || tempState == 7)
                return true;
            return false;
            
        }
        private static int classify(char c)
        {
            if (char.IsDigit(c))
                return 0;
            if (c == '.')
                return 1;
            if (c == 'E')
                return 2;
            if (c == '+' || c == '-')
                return 3;            
            return 4;
        }
        
        public static void buildStateFunctionTable()
        {
            /*
             *          0 1 2 3
             * state    D . e +-else
             *     0    0 0 0 0 0
             *     1    2 0 0 0 0
             *     2    2 3 5 0 0
             *     3    4 0 0 0 0
             *     4    4 5 0 0 0
             *     5    7 0 0 6 0
             *     6    7 0 0 0 0
             *     7    7 0 0 0 0
             */                 
            stateFunctionTable=new int[8][];
            stateFunctionTable[0]=new int[5]{0,0,0,0,0};
            stateFunctionTable[1]=new int[5]{2,0,0,0,0};
            stateFunctionTable[2]=new int[5]{2,3,5,0,0};
            stateFunctionTable[3]=new int[5]{4,0,0,0,0};
            stateFunctionTable[4]=new int[5]{4,5,0,0,0};
            stateFunctionTable[5]=new int[5]{7,0,0,6,0};
            stateFunctionTable[6]=new int[5]{7,0,0,0,0};
            stateFunctionTable[7]=new int[5]{7,0,0,0,0};


        }

    }
}
