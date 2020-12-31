using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.Structures.TableContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct PtypObjectValue
    {
        public UInt32 Nid;
        public UInt32 ulSize;
    }
}
