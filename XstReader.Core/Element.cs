using System;
using System.Collections.Generic;
using System.Linq;
using XstReader.XstData.Layouts.Common.NDB;
using XstReader.XstData.Properties;

namespace XstReader
{
    public abstract class Element
    {
        internal virtual XstFile XstFile { get; }
        internal NID Nid { get; set; }  // Where element data is held

        internal ElementProperties ElementProperties { get; }
        public List<Property> Properties => ElementProperties.Properties;
        internal Property GetProperty(EpropertyTag tag) => ElementProperties.GetProperty(tag);
        public Property GetProperty(UInt16 tag) => GetProperty((EpropertyTag)tag);

        public Element()
        {
            ElementProperties = new ElementProperties(this);
        }


    }
}
