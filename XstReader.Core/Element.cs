using System;
using System.Collections.Generic;
using System.Linq;
using XstReader.Utils.BTree;
using XstReader.XstData.Layouts.Common.NDB;
using XstReader.XstData.Properties;

namespace XstReader
{
    public abstract class Element
    {
        internal virtual XstFile XstFile { get; }
        internal NID Nid { get; set; }  // Where element data is held

        private List<EpropertyTag> NotFoundProperties { get; } = new List<EpropertyTag>();
        private Dictionary<EpropertyTag, Property> DictProperties { get; } = new Dictionary<EpropertyTag, Property>();
        private bool _AllProperties = false;

        //Asking for Properties forces Read pending properties
        public List<Property> Properties
        {
            get
            {
                if (!_AllProperties)
                {
                    var props = XstFile.ReadPropertiesExcluding(this, NotFoundProperties.Union(DictProperties.Keys));
                    foreach (var prop in props)
                        DictProperties.Add(prop.Tag, prop);
                    _AllProperties = true;
                }
                return DictProperties.Values.ToList();
            }
        }

        public Property GetProperty(UInt16 tag)
            => GetProperty((EpropertyTag)tag);

        internal Property GetProperty(EpropertyTag tag)
        {
            if (!DictProperties.ContainsKey(tag) && !NotFoundProperties.Contains(tag) && !_AllProperties)
            {
                //Find property. If found -> DicProperties.Add; Else -> NotFoundProperties.Add
                var prop = XstFile.ReadProperty(this, tag);
                if (prop != null)
                    DictProperties.Add(tag, prop);
                else
                    NotFoundProperties.Add(tag);
                return prop;
            }
            if (DictProperties.ContainsKey(tag))
                return DictProperties[tag];
            return null;
        }
    }
}
