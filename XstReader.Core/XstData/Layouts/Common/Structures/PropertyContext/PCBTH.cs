using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Layouts.Common.LTP;
using XstReader.XstData.Properties;

namespace XstReader.XstData.Layouts.Common.Structures.PropertyContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct PCBTH
    {
        public EpropertyTag wPropId;
        public EpropertyType wPropType;
        public HNID dwValueHnid;
    }
}
