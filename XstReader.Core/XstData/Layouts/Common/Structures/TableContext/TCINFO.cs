using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData.Layouts.Common.Structures.TableContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TCINFO
    {
        public EbType btype;    // Must be bTypeTC
        public Byte cCols;
        public UInt16 rgibTCI_4b;
        public UInt16 rgibTCI_2b;
        public UInt16 rgibTCI_1b;
        public UInt16 rgibTCI_bm;
        public HID hidRowIndex;
        public HNID hnidRows;
        public HID hidIndex;
    }
}
