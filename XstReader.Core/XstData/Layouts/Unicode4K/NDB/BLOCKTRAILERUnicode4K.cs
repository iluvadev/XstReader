using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode4K.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BLOCKTRAILERUnicode4K
    {
        public UInt16 cb;
        public UInt16 wSig;
        public UInt32 dwCRC;
        public UInt64 bid;
        public UInt16 unknown1;
        public UInt16 cbInflated;
        public UInt32 unknown2;
    }
}
