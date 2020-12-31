using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BREFUnicode
    {
        public UInt64 bid;
        public UInt64 ib;
    }
}
