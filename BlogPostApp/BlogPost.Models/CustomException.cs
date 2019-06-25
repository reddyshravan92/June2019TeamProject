using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost.Models
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            //custom initialize
        }
    }
}
