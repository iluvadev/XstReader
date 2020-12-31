﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XstReader.XstData.Layouts.Common.Structures.Page
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct HNPAGEHDR
    {
        public UInt16 ibHnpm;       // The byte offset to the HN page Map record
    }
}
