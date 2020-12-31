using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct RootUnicode
    {
        public UInt32 dwReserved;
        public UInt64 ibFileEof;
        public UInt64 ibAMapLast;
        public UInt64 cbAMapFree;
        public UInt64 cbPMapFree;
        public BREFUnicode BREFNBT;
        public BREFUnicode BREFBBT;
        public Byte fAMapValid;
        public Byte bReserved;
        public UInt16 wReserved;
    }
}
