using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData
{
    internal partial class LTP
    {        
        // Used when reading table data to normalise handling of in-line and sub node data storage
        private class RowDataBlock
        {
            public byte[] Buffer;
            public int Offset;
            public int Length;
        }
    }
}
