﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct BLOCKTRAILERUnicode
    {
        public UInt16 cb;
        public UInt16 wSig;
        public UInt32 dwCRC;
        public UInt64 bid;
    }
}
