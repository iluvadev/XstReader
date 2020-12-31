using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.Common.Structures.BTreeOnHeap
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BTHHEADER
    {
        public EbType btype;
        public Byte cbKey;
        public Byte cbEnt;
        public Byte bIdxLevels;
        public HID hidRoot;
    }
}
