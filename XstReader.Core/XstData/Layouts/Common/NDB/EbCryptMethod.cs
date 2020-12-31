using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Common.NDB
{
    internal enum EbCryptMethod : byte
    {
        NDB_CRYPT_NONE = 0x00,
        NDB_CRYPT_PERMUTE = 0x01,
        NDB_CRYPT_CYCLIC = 0x02,
    }
}
