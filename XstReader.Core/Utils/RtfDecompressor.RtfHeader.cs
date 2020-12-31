using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.Utils
{
    internal partial class RtfDecompressor
    {
        //nested types
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        private struct RtfHeader
        {
            //fields
            public UInt32 compSize;
            public UInt32 rawSize;
            public UInt32 compType;
            public UInt32 crc;
        }
    }
}
