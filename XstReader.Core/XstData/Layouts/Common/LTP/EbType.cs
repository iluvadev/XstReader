using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Common.LTP
{
    internal enum EbType : byte
    {
        bTypeX = 0x01,   // XBLOCK or XXBLOCK
        bTypeS = 0x02,   // SLBLOCK or SIBLOCK
        bTypeTC = 0x7c,   // Table Context
        bTypeBTH = 0xb5,   // BTree-on-Heap
        bTypePC = 0xbc,  // Property Context
    }
}
