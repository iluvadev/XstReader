using System;
using System.Collections.Generic;
using System.Linq;

namespace XstReader.XstData.Properties
{
    // Property getters are used to specify which properties should be retrieved from a property context
    // or table context, and where they should be stored.
    // T is the target object, Action arguments are target object, column value 
    internal class PropertyGetters<T> : Dictionary<EpropertyTag, Action<T, dynamic>>
    {
    }
}
