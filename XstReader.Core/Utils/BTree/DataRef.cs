using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.Utils.BTree
{
    // Terminal node in data tree
    // Key is BID, contains IB
    internal class DataRef : TreeNode
    {
        public UInt64 Offset;
        public int Length;
        public int InflatedLength; // Only used for Unicode4K
        public bool IsInternal { get { return (Key & 0x02) != 0; } }
    }
}
