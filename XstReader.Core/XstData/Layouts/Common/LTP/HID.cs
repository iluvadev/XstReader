using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Common.LTP
{
    // The HID is a 32-bit value, with the following internal structure
    // non-4K: 5-bit Type; 11-bit Index; 16-bit BlockIndex
    // 4K:     5-bit Type; 14-bit Index; 13-bit BlockIndex
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct HID
    {
        private UInt16 wValue1;
        private UInt16 wValue2;

        private UInt16 hidIndex { get { return (UInt16)(wValue1 >> 5); } }
        private UInt16 hidBlockIndex { get { return wValue2; } }
        private UInt16 hidIndex4K { get { return (UInt16)((wValue1 >> 5) | ((wValue2 & 0x0007) << 11)); } }
        private UInt16 hidBlockIndex4K { get { return (UInt16)(wValue2 >> 3); } }

        public HID(UInt16 wValue1, UInt16 wValue2)
        {
            this.wValue1 = wValue1;
            this.wValue2 = wValue2;
        }

        public EnidType hidType { get { return (EnidType)(wValue1 & 0x001f); } }

        public UInt16 GetIndex(bool isUnicode4K)
        {
            return isUnicode4K ? hidIndex4K : hidIndex;
        }

        public UInt16 GetBlockIndex(bool isUnicode4K)
        {
            return isUnicode4K ? hidBlockIndex4K : hidBlockIndex;
        }
    }
}
