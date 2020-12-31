using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData
{
    internal partial class NamedProperties
    {
        private class PropSet
        {
            public string GuidName;
            public string Guid;
            public Dictionary<UInt32, string> PropDesc = null;
        }
    }
}
