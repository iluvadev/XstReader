using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct NID
    {
        public UInt32 dwValue; // References use the whole four bytes
        public EnidType nidType { get { return (EnidType)(dwValue & 0x0000001f); } }  // Low order five bits of stored value
        public UInt32 nidIndex { get { return dwValue >> 5; } }
        public bool HasValue { get { return (dwValue != 0); } }

        public NID(UInt32 nid)
        {
            this.dwValue = nid;
        }

        public NID(EnidSpecial special)
        {
            this.dwValue = (UInt32)special;
        }

        public static NID TypedNID(EnidType nidType, NID nid)
        {
            // Note that type partially overwrites value
            return new NID((nid.dwValue & 0xffffffe0) | (UInt32)nidType);
        }
    }

}
