using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.Common.Structures.BTreeOnHeap
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct IntermediateBTH2
    {
        public fixed Byte key[2];
        public HID hidNextLevel;
    }
}
