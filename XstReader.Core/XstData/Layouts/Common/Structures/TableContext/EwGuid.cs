using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Common.Structures.TableContext
{
    internal enum EwGuid : UInt16
    {
        NAMEID_GUID_NONE = 0,
        NAMEID_GUID_MAPI = 1,
        NAMEID_GUID_PUBLIC_STRINGS = 2,
        InStream = 3,
    }
}
