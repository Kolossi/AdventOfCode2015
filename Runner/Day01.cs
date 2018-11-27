using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Runner
{
    class Day01 :  Day
    {
        public override string First(string input)
        {
            return (input.ToArray().Count(c => c == '(') - input.ToArray().Count(c => c == ')')).ToString();
        }

        public override string Second(string input)
        {
            int floor = 0, count=0;
            foreach (var i in input.ToArray())
            {
                floor += i == '(' ? 1 : -1;
                count++;
                if (floor == -1) return count.ToString();
            }
            return "";
        }


        ////////////////////////////////////////////////////////
    }
}
