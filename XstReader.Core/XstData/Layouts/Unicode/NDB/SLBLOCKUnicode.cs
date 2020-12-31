using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SLBLOCKUnicode
    {
        public EbType btype;
        public Byte cLevel;
        public UInt16 cEnt;
        public UInt32 dwPadding;
        // Marshal the following array manually
        //public SLENTRYUnicode[] rgentries;
    }
}
