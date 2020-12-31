using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.Structures.TableContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NAMEID
    {
        public UInt32 dwPropertyID;
        private UInt16 wValue;
        public UInt16 wPropIdx;
        public bool N { get { return (wValue & 0x0001) == 1; } }
        public UInt16 wGuid { get { return (UInt16)(wValue >> 1); } }
    }
}
