using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader
{
    public class XstException : Exception
    {
        public XstException(string message) : base(message)
        {
        }
    }
}
