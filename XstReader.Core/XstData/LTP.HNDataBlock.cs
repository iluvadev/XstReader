using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;

namespace XstReader.XstData
{
    internal partial class LTP
    {        
        // A heap-on-node data block
        private class HNDataBlock
        {
            public int Index;
            public byte[] Buffer;
            public UInt16[] rgibAlloc;

            // In first block only
            public EbType bClientSig;
            public HID hidUserRoot;  // HID that points to the User Root record
        }
    }
}
