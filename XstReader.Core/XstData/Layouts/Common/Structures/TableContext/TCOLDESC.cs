using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using XstReader.XstData.Properties;

namespace XstReader.XstData.Layouts.Common.Structures.TableContext
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TCOLDESC
    {
        public UInt32 tag;
        public EpropertyTag wPropId { get { return (EpropertyTag)(tag >> 16); } }
        public EpropertyType wPropType { get { return (EpropertyType)(tag & 0x0000ffff); } }
        public UInt16 ibData;
        public Byte cbData;
        public Byte iBit;
    }
}
