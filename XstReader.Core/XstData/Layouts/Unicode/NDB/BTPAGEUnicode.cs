using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct BTPAGEUnicode
    {
        public fixed Byte rgentries[LayoutUConstants.BTPAGEEntryBytes];
        public Byte cEnt;
        public Byte cEntMax;
        public Byte cbEnt;
        public Byte cLevel;
        public UInt32 dwPadding;
        public PAGETRAILERUnicode pageTrailer;
    }
}
