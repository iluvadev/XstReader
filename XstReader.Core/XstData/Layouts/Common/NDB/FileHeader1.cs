using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct FileHeader1
    {
        public UInt32 dwMagic;
        public UInt32 dwCRCPartial;
        public UInt16 wMagicClient;
        public UInt16 wVer;
        public UInt16 wVerClient;
        public Byte bPlatformCreate;
        public Byte bPlatformAccess;
        public UInt32 dwReserved1;
        public UInt32 dwReserved2;
    }
}
