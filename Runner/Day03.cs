using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Runner
{
    class Day03 :  Day
    {
        public override string First(string input)
        {
            return CountHouses(input).ToString();
        }

        public override string Second(string input)
        {
            return CountRobotHouses(input).ToString();
        }


        ////////////////////////////////////////////////////////
        
        public int CountHouses(string input)
        {
            var visited = new HashSet<XY>();
            var xy = new XY(0, 0);
            visited.Add(xy);

            foreach (var i in input.ToArray())
            {
                switch(i)
                {
                    case '^':
                        xy = xy.MoveN();
                        break;
                    case '>':
                        xy = xy.MoveE();
                        break;
                    case 'v':
                        xy = xy.MoveS();
                        break;
                    case '<':
                        xy = xy.MoveW();
                        break;
                    default:
                        throw new NotImplementedException();
                }
                visited.Add(xy);
            }

            return visited.Count;
        }

        public int CountRobotHouses(string input)
        {
            var visited = new HashSet<XY>();
            var santaxy = new XY(0, 0);
            var robotxy = new XY(0, 0);
            XY xy;
            visited.Add(santaxy);

            var isSanta = true;
            foreach (var i in input.ToArray())
            {
                xy = isSanta ? santaxy : robotxy;
                switch(i)
                {
                    case '^':
                        xy = xy.MoveN();
                        break;
                    case '>':
                        xy = xy.MoveE();
                        break;
                    case 'v':
                        xy = xy.MoveS();
                        break;
                    case '<':
                        xy = xy.MoveW();
                        break;
                    default:
                        throw new NotImplementedException();
                }
                visited.Add(xy);
                if (isSanta)
                {
                    santaxy = xy;
                }
                else
                {
                    robotxy = xy;
                }
                isSanta = !isSanta;
            }

            return visited.Count;
        }
    }
}
