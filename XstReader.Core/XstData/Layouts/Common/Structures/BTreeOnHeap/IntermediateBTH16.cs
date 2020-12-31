using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.Common.Structures.BTreeOnHeap
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct IntermediateBTH16
    {
        public fixed Byte key[16];
        public HID hidNextLevel;
    }
}
