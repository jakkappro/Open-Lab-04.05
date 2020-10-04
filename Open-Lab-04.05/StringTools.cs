using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string ret = "";
            foreach (char ch in orig)
            {
                for (int i = 0; i < n; i++)
                {
                    ret += ch;
                }
            }
            return ret;
        }
    }
}
