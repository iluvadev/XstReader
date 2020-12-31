using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NBTENTRYANSI
    {
        public NID nid;
        public UInt32 bidData;
        public UInt32 bidSub;
        public UInt32 nidParent;
    }
}
