using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using AppSharedProject.DTO;
using MemoryPack;

namespace AppSharedProject.Models.Sqlite;

[MemoryPackable]
public partial class Morador : BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Nome { get; set; }
    public byte[] Foto { get; set; }
    [ForeignKey("Unidade")]
    public Guid UnidadeId { get; set; }
    public Unidade Unidade { get; set; }
    public int IdFirebird { get; set; }
    public string? Email { get; set; }
    public string? Cpf { get; set; }
    public string? Celular { get; set; }
    public bool Admin { get; set; }
    public StatusMorador Status { get; set; }
    public bool? Arquivamento { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim { get; set; }
    [MemoryPackIgnore]
    public User User { get; set; }

    [MemoryPackConstructor]
    public Morador() { }

    public Morador(MoradorCreateDTO morador)
    {
        Id = morador.Id;
        IdFirebird = morador.IdFirebird;
        Nome = morador.Nome;
        Foto = morador.Foto != null ? Convert.FromBase64String(morador.Foto) : null;
        Celular = morador.Celular;
        Cpf = morador.Cpf;
        Email = morador.Email;
        UnidadeId = morador.UnidadeId;
        Status = morador.Status;
    }
    public enum StatusMorador
    {
        Cliente,
        Servidor,
        Novo
    }
}