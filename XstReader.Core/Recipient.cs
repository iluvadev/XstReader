using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XstReader.XstData.Layouts.Common.NDB;
using XstReader.XstData.Properties;

namespace XstReader
{
    public class Recipient 
    {
        internal RecipientType RecipientType { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public List<Property> Properties { get; private set; } = new List<Property>();
        internal NID Nid { get; set; }  // Where element data is held
    }
}
