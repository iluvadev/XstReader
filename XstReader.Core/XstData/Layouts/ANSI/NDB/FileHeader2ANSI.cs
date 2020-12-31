using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct FileHeader2ANSI
    {
        public UInt32 bidNextB;
        public UInt32 bidNextP;
        public UInt32 dwUnique;
        public fixed UInt32 rgnid[32];
        public RootANSI root;
        public fixed Byte rgbFM[128];
        public fixed Byte rgbFP[128];
        public Byte bSentinel;
        public EbCryptMethod bCryptMethod;
        public UInt16 rgbReserved;
        public UInt64 ullReserved;
        public UInt32 dwReserved;
        public UInt32 rgbReserved2;
        public fixed Byte rgbReserved3[32];
    }
}
