using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XstReader.XstData.Layouts.Common;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader.Utils.BTree
{
    // Terminal node in node tree
    // Key is NID, contains BIDs
    // BIDs are always held as 64-bit values, even though only 32 bits are used in ANSI files
    internal class Node : TreeNode
    {
        public EnidType Type;
        public UInt64 DataBid;
        public UInt64 SubDataBid;
        public UInt32 Parent;
    }
}
