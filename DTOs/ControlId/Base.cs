using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AppSharedProject.DTO.ControlId
{
    public class Base<T>
    {
        [JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonPropertyName("values")]
        public List<T>? Values { get; set; }

        [JsonPropertyName("where")]
        public object? Where { get; set; }

        public Base(string objectName, List<T>? values = null, object? where = null)
        {
            Object = objectName;
            Values = values;
            Where = where;
        }
    }
}
