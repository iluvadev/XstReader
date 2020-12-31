using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.XstData.Layouts.Unicode4K
{
    // xst layouts that are specific to Unicode files with 4K pages
    // These are not documented in <MS-PST>, But taken instead from libpff 
    // and https://blog.mythicsoft.com/2015/07/10/ost-2013-file-format-the-missing-documentation/

    // Constants
    internal class LayoutU4KConstants
    {
        public const int BTPAGEEntryBytes = 4056;
    }
}
