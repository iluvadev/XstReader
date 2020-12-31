using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SLBLOCKANSI
    {
        public EbType btype;
        public Byte cLevel;
        public UInt16 cEnt;
        //public UInt32 dwPadding;    // [MS-PST] v20150904 lies, asserting that this occurs in ANSI files. A bug has been raised with Microsoft
        // Marshal the following array manually
        //public SLENTRYANSI[] rgentries;
    }
}
