using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct PAGETRAILERUnicode
    {
        public Eptype ptype;
        public Eptype ptypeRepeat;
        public UInt16 wSig;
        public UInt32 dwCRC;
        public UInt64 bid;
    }
}
