using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct RootANSI
    {
        public UInt32 dwReserved;
        public UInt32 ibFileEof;
        public UInt32 ibAMapLast;
        public UInt32 cbAMapFree;
        public UInt32 cbPMapFree;
        public BREFANSI BREFNBT;
        public BREFANSI BREFBBT;
        public Byte fAMapValid;
        public Byte bReserved;
        public UInt16 wReserved;
    }
}
