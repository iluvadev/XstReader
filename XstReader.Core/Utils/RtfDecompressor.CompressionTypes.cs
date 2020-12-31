using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.Utils
{
    internal partial class RtfDecompressor
    {
        //enumerations
        private enum CompressionTypes : UInt32
        {
            //2.1.3.1.1
            Compressed = 0x75465A4C,
            UnCompressed = 0x414C454D,
        }
    }
}
