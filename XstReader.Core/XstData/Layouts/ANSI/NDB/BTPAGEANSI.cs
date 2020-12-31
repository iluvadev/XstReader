using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.ANSI.NDB
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    unsafe internal struct BTPAGEANSI
    {
        public fixed Byte rgentries[LayoutAConstants.BTPAGEEntryBytes];
        public Byte cEnt;
        public Byte cEntMax;
        public Byte cbEnt;
        public Byte cLevel;
        public PAGETRAILERANSI pageTrailer;
    }
}
