using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Properties
{
    // Values of the PidTagNativeBody property
    internal enum BodyType : Int32
    {
        Undefined = 0x00000000,
        PlainText = 0x00000001,
        RTF = 0x00000002,
        HTML = 0x00000003,
        ClearSigned = 0x00000004,
    }
}
