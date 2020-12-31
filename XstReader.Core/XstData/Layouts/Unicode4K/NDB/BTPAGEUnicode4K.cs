using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode4K.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct BTPAGEUnicode4K
    {
        public fixed Byte rgentries[LayoutU4KConstants.BTPAGEEntryBytes];
        public UInt16 cEnt;
        public UInt16 cEntMax;
        public Byte cbEnt;
        public Byte cLevel;
        public UInt16 dwPadding1;
        public UInt32 dwPadding2;
        public UInt32 dwPadding3;
        public PAGETRAILERUnicode4K pageTrailer;
    }
}
