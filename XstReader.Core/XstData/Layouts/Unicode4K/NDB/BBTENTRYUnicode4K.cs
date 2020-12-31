using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Unicode.NDB;

namespace XstReader.XstData.Layouts.Unicode4K.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BBTENTRYUnicode4K
    {
        public BREFUnicode BREF;
        public UInt16 cbStored;
        public UInt16 cbInflated;
        public UInt16 cRef;
        public UInt16 wPadding;
    }
}
