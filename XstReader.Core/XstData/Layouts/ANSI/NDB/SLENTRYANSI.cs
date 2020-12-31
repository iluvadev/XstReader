using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct SLENTRYANSI
    {
        public UInt32 nid;
        public UInt32 bidData;
        public UInt32 bidSub;
    }
}
