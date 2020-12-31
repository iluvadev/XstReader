using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XstReader.Utils.BTree
{
    // Non-terminal tree nodes have children
    internal class TreeIntermediate : TreeNode
    {
        public List<TreeNode> Children = new List<TreeNode>();
        public ulong? fileOffset = null;
        public bool ReadDeferred { get { return fileOffset != null; } }
    }
}
