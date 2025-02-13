﻿using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;

namespace Hifi.PositionalContent
{ 
    public class ChildDataType
    {
        public IDataType DataTypeDefinition { get; set; }
        public IDataEditor PropertyEditor { get; set; }
        public PropertyType PropertyType { get; set; }
        public IDataValueEditor ValueEditor { get; set; }
        public object PreValues { get; set; }
        public IDictionary<string, object> Config { get; set; }
    }
    
}
