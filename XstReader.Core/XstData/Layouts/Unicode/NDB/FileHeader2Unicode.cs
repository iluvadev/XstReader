using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct FileHeader2Unicode
    {
        public UInt64 bidUnused;
        public UInt64 bidNextP;
        public UInt32 dwUnique;
        public fixed UInt32 rgnid[32];
        public UInt64 qwUnused;
        public RootUnicode root;
        public UInt32 dwAlign;
        public fixed Byte rgbFM[128];
        public fixed Byte rgbFP[128];
        public Byte bSentinel;
        public EbCryptMethod bCryptMethod;
        public UInt16 rgbReserved;
        public UInt64 bidNextB;
        public UInt32 dwCRCFull;
        public UInt32 rgbReserved2;
        public fixed Byte rgbReserved3[32];
    }
}
