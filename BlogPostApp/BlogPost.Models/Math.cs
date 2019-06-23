using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class Math
    {
        public int Concate(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public string Concate(string arg1, string arg2)
        {
            return $"{arg1} {arg2}";
        }
    }
}
