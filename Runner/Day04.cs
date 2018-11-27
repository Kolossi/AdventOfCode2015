using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Runner
{
    class Day04 :  Day
    {
        public override string First(string input)
        {
            return Get50Hash(input);
        }

        public override string Second(string input)
        {
            return Get60Hash(input);
        }


        ////////////////////////////////////////////////////////

        public string Get50Hash(string input)
        {
            int i = 0;
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                while (true)
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + i.ToString());
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    if (hashBytes[0] == 0 && hashBytes[1] == 0 && (hashBytes[2] & 0xf0) == 0) break;
                    i++;
                }
            }
            return i.ToString();
        }

        public string Get60Hash(string input)
        {
            int i = 0;
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                while (true)
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + i.ToString());
                    byte[] hashBytes = md5.ComputeHash(inputBytes);
                    if (hashBytes[0] == 0 && hashBytes[1] == 0 && hashBytes[2] == 0) break;
                    i++;
                }
            }
            return i.ToString();
        }
    }
}
