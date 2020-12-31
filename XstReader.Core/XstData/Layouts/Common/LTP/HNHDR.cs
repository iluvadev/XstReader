using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.LTP
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct HNHDR
    {
        public UInt16 ibHnpm;       // The byte offset to the HN page Map record
        public Byte bSig;
        public EbType bClientSig;
        public HID hidUserRoot;  // HID that points to the User Root record
        public UInt32 rgbFillLevel;
    }
}
