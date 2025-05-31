using System.Text.Json.Serialization;

namespace AppSharedProject.DTO.ControlId
{
    public class DeleteUsuario
    {
        [JsonPropertyName("changes")]
        public int Changed { get; set; }
    }
}
