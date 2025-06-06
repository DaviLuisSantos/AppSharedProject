using System.Text.Json.Serialization;

namespace AppSharedProject.DTO.ControlId
{
    public class UserGroupAdd
    {
        [JsonPropertyName("group_id")]
        public int GroupId { get; set; } = 1;

        [JsonPropertyName("user_id")]
        public int UserId { get; set; }

        public UserGroupAdd() { }

        public UserGroupAdd(int userId)
        {
            UserId = userId;
        }
    }
}
