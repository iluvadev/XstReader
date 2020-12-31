using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;

namespace XstReader
{
    public class Folder 
    {
        public XstFile XstFile { get; set; }
        public string Name { get; set; }
        public uint ContentCount { get; set; } = 0;
        public bool HasSubFolders { get; set; } = false;
        internal NID Nid { get; set; }  // Where element data is held
        public Folder ParentFolder { get; set; }
        public List<Folder> Folders { get; private set; } = new List<Folder>();
        public List<Message> Messages { get; private set; } = new List<Message>();

        private string _Path = null;
        public string Path => _Path ?? (_Path = (string.IsNullOrEmpty(ParentFolder?.Name)) ? Name : $"{ParentFolder.Path}\\{Name}");

        public Message AddMessage(Message m)
        {
            m.Folder = this;
            Messages.Add(m);
            return m;
        }
    }
}
