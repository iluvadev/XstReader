using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.Structures.Page
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct HNPAGEMAP
    {
        public UInt16 cAlloc;
        public UInt16 cFree;
        // Marshal the following array manually
        //public UInt16[] rgibAlloc;
    }
}
