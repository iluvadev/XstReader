using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.XstData.Layouts.Common.LTP
{
    // A variation on HID used where the value can be either a HID or a NID
    // It is a HID iff hidType is EnidType.HID and the wValues are not both zero
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct HNID
    {
        private UInt16 wValue1;
        private UInt16 wValue2;

        private UInt16 hidIndex { get { return (UInt16)(wValue1 >> 5); } }
        private UInt16 hidBlockIndex { get { return wValue2; } }
        private UInt16 hidIndex4K { get { return (UInt16)((wValue1 >> 5) | ((wValue2 & 0x0007) << 11)); } }
        private UInt16 hidBlockIndex4K { get { return (UInt16)(wValue2 >> 3); } }

        public bool HasValue { get { return (wValue1 != 0) || (wValue2 != 0); } }
        public bool IsHID { get { return HasValue && hidType == EnidType.HID; } }
        public EnidType hidType { get { return (EnidType)(wValue1 & 0x001f); } }
        public EnidType nidType { get { return (EnidType)(wValue1 & 0x001f); } }  // Low order five bits of stored value
        public UInt32 dwValue { get { return (UInt32)(wValue2 << 16) | wValue1; } }  // References use the whole four bytes
        public HID HID { get { return new HID(wValue1, wValue2); } }
        public NID NID { get { return new NID(dwValue); } }

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
