using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using AppSharedProject.Models.Firebird;
using static AppSharedProject.Models.Sqlite.Unidade;
using MemoryPack;

namespace AppSharedProject.DTO
{
    [MemoryPackable]
    public partial class UnidadeCreateDTO
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; } 
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("condominioId")]
        public Guid CondominioId { get; set; }

        [JsonPropertyName("vagas")]
        public int? Vagas { get; set; }
        public int IdFirebird { get; set; }
        public StatusUnidade Status { get; set; }

        [MemoryPackConstructor]
        public UnidadeCreateDTO() { }
        public UnidadeCreateDTO(Unidade unidade)
        {
            Nome = unidade.Nome;
            Vagas = unidade.NumVagas;
            IdFirebird = unidade.Id;
        }
    }
}
