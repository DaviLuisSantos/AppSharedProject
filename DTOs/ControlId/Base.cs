using System;
using System.Collections.Generic;
using System.Text;

namespace AppSharedProject.DTO.ControlId
{
    class Base<T>(string objectName, List<T>? values = null, object? where = null)
    {
        public string Object { get; set; } = objectName;
        public List<T>? Values { get; set; } = values;
        public object? Where { get; set; } = where;
    }
}
