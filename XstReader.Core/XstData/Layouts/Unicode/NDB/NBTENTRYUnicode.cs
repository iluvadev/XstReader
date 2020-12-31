using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Unicode.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NBTENTRYUnicode
    {
        public NID nid;
        public UInt32 dwPad;
        public UInt64 bidData;
        public UInt64 bidSub;
        public UInt32 nidParent;
        public UInt32 dwPadding;
    }
}
