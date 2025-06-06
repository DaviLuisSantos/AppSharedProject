using System.Text.Json.Serialization;

namespace AppSharedProject.DTO.ControlId
{
    public class UserAdd
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("registration")]
        public string Registration { get; set; }

        [JsonPropertyName("begin_time")]
        public long BeginTime { get; set; }

        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        public UserAdd(int id, string name, string registration, long beginTime, long endTime)
        {
            Id = id;
            Name = name;
            Registration = registration;
            BeginTime = beginTime;
            EndTime = endTime;
        }

        // Construtor padrão (opcional, para desserialização)
        public UserAdd() { }
    }
}
