using System.Collections.Generic;
using System.Linq;
using XstReader.XstData.Properties;

namespace XstReader
{
    internal class ElementProperties
    {
        private Element Element { get; }

        private List<EpropertyTag> VisitedProperties { get; } = new List<EpropertyTag>();
        private Dictionary<EpropertyTag, Property> DictProperties { get; } = new Dictionary<EpropertyTag, Property>();
        private bool _AllProperties = false;

        public Property this[EpropertyTag tag] => GetProperty(tag);

        //Asking for Properties forces Read pending properties
        public List<Property> Properties
        {
            get
            {
                if (!_AllProperties)
                {
                    var props = Element.XstFile.ReadPropertiesExcluding(Element, VisitedProperties);
                    foreach (var prop in props)
                    {
                        SetPropertyVisited(prop.Tag);
                        DictProperties.Add(prop.Tag, prop);
                    }
                    _AllProperties = true;
                }
                return DictProperties.Values.ToList();
            }
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="element"></param>
        public ElementProperties(Element element)
        {
            Element = element;
        }


        internal Property GetProperty(EpropertyTag tag)
        {
            if (!VisitedProperties.Contains(tag))
            {
                SetPropertyVisited(tag);
                if (_AllProperties) //Are all properties visited?
                    return null;

                //Find property. 
                var prop = Element.XstFile.ReadProperty(Element, tag);
                if (prop != null)
                    DictProperties.Add(tag, prop);
                return prop;
            }
            if (DictProperties.ContainsKey(tag))
                return DictProperties[tag];
            return null;
        }
        internal void SetProperty(Property property)
        {
            if (property != null)
            {
                DictProperties[property.Tag] = property;
                SetPropertyVisited(property.Tag);
            }
        }
        internal void SetProperties(IEnumerable<Property> properties)
        {
            foreach (var prop in properties)
                SetProperty(prop);
        }

        internal void SetPropertyVisited(EpropertyTag tag)
        {
            if (!VisitedProperties.Contains(tag))
                VisitedProperties.Add(tag);
        }
        internal void SetPropertiesVisited(IEnumerable<EpropertyTag> tags)
        {
            foreach (var tag in tags)
                SetPropertyVisited(tag);
        }

        internal IEnumerable<EpropertyTag> GetUnknownProperties(IEnumerable<EpropertyTag> tags)
            => tags.Where(t => !VisitedProperties.Contains(t));

        internal void ClearProperty(EpropertyTag tag)
        {
            if (DictProperties.ContainsKey(tag))
            {
                DictProperties.Remove(tag);
                VisitedProperties.Remove(tag);
                _AllProperties = false;
            }
        }
    }
}
