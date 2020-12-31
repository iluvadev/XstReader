using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode.LTP
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TCROWIDUnicode
    {
        public UInt32 dwRowID;
        public UInt32 dwRowIndex;
    }
}
