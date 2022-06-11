using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page285Submission
{
    static class StaticDivider
    {
        public static void DivThree(int input, out int answer, out int remainder)
        {
            answer = input / 3;
            remainder = input % 3;
        }

        public static void DivThree(float input, out float answer)
        {
            answer = input / 3f;
        }
    }
}
