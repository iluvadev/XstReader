using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Common.Structures.PropertyContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct PtypObjectProperty
    {
        public NID nid;
        public UInt32 ulSize;
    }
}
