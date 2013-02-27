using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Recursion
    {
        public void Combine(string str)
        {
            int length = str.Length;
            char[] instr = str.ToCharArray();
            StringBuilder outstr = new StringBuilder();

            DoCombine(instr, outstr, length, 0);
        }

        private void DoCombine(char[] instr, StringBuilder outstr, int length, int start)
        {
            for (int i = start; i < length; i++)
            {
                outstr.Append(instr[i]);
                Console.WriteLine(outstr);

                if (i < length - 1)
                {
                    DoCombine(instr, outstr, length, i + 1);
                }

                outstr.Length = outstr.Length - 1;
            }
        }
    }
}
