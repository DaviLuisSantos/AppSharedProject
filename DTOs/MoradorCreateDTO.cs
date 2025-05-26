using AppSharedProject.Models.Firebird;
using System.Text.Json.Serialization;
using static AppSharedProject.Models.Sqlite.Morador;
using MemoryPack;

namespace AppSharedProject.DTO;

[MemoryPackable]
public partial class MoradorCreateDTO
{

    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("foto")]
    public string? Foto { get; set; }
    [JsonPropertyName("unidadeId")]
    public Guid UnidadeId { get; set; }
    [JsonPropertyName("idFirebird")]
    public int IdFirebird { get; set; }
    [JsonPropertyName("celular")]
    public string? Celular { get; set; }
    [JsonPropertyName("cpf")]
    public string? Cpf { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("status")]
    public StatusMorador Status { get; set; }
    [JsonPropertyName("admin")]
    public bool Admin { get; set; } = false;

    [MemoryPackConstructor]
    public MoradorCreateDTO() { }
    public MoradorCreateDTO(Morador morador)
    {
        Nome = morador.Nome;
        Foto = morador.Foto != null ? Convert.ToBase64String(morador.Foto) : null;
        IdFirebird = morador.Id;
        Celular = morador.Celular;
        Cpf = morador.Cpf;
        Email = morador.Email;
    }

    public MoradorCreateDTO(Models.Sqlite.Morador morador)
    {
        Nome = morador.Nome;
        Foto = morador.Foto != null ? Convert.ToBase64String(morador.Foto) : null;
        IdFirebird = morador.IdFirebird;
        Celular = morador.Celular;
        Cpf = morador.Cpf;
        Email = morador.Email;
        UnidadeId = morador.UnidadeId;
    }

}
