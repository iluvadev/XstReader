using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Properties
{
    // Values of the PidTagMessageFlags property
    [Flags]
    internal enum MessageFlags : Int32
    {
        mfHasAttach = 0x00000010,
    }
}
