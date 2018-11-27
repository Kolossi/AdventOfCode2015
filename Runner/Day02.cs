using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Runner
{
    class Day02 :  Day
    {
        public override string First(string input)
        {
            return GetLines(input).Sum(l => DoWrapLine(l)).ToString();
        }

        public override string Second(string input)
        {
            return GetLines(input).Sum(l => DoRibbonLine(l)).ToString();
        }

        public override string FirstTest(string input)
        {
            return DoWrapLine(input).ToString();
        }

        public override string SecondTest(string input)
        {
            return DoRibbonLine(input).ToString();
        }

        ////////////////////////////////////////////////////////

        public int DoWrapLine(string input)
        {
            var parts = input.Split("x");
            var w = int.Parse(parts[0]);
            var l = int.Parse(parts[1]);
            var h = int.Parse(parts[2]);

            return WrapSize(w, l, h);
        }
		public int DoRibbonLine(string input)
        {
            var parts = input.Split("x");
            var w = int.Parse(parts[0]);
            var l = int.Parse(parts[1]);
            var h = int.Parse(parts[2]);

            return RibbonSize(w, l, h);
        }

        public int WrapSize(int l, int w, int h)
        {
            int s1 = l * w, s2 = w * h, s3 = h * l;
            int smallest = Math.Min(Math.Min(s1, s2), s3);
            return s1 * 2 + s2 * 2 + s3 * 2 + smallest;
        }

        public int RibbonSize(int l, int w, int h)
        {
            int s1 = 2 * (l + w), s2 = 2 * (w + h), s3 = 2 * (h + l);
            int smallest = Math.Min(Math.Min(s1, s2), s3);
            return smallest + (l * w * h);
        }
    }
}
