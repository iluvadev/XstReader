using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.ANSI.LTP
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TCROWIDANSI
    {
        public UInt32 dwRowID;
        public UInt16 dwRowIndex;
    }
}
