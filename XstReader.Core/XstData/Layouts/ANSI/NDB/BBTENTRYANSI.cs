using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BBTENTRYANSI
    {
        public BREFANSI BREF;
        public UInt16 cb;
        public UInt16 cRef;
    }
}
