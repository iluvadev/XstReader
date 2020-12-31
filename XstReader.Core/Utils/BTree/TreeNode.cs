using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.Utils.BTree
{
    // The only thing that a tree node must have is a key
    internal abstract class TreeNode
    {
        public UInt64 Key;
    }
}
