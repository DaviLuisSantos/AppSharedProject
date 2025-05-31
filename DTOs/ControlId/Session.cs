using System.Text.Json.Serialization;

namespace AppSharedProject.DTO.ControlId
{
    public class Session
    {
        [JsonPropertyName("session")]
        public string session { get; set; }
    }
}
