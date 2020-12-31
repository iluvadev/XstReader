using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Properties
{
    // Values of the PidTagRecipientType property
    [Flags]
    internal enum RecipientType : Int32
    {
        Originator = 0x00000000,
        To = 0x00000001,
        Cc = 0x00000002,
        Bcc = 0x00000003,
    }
}
