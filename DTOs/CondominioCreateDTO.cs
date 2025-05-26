using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using AppSharedProject.Models.Firebird;
using MemoryPack;

namespace AppSharedProject.DTO;

[MemoryPackable]
public partial class CondominioCreateDTO
{
    public Guid Id { get; set; }
    [Required]
    public string Nome { get; set; }
    [Required]
    public string Cnpj { get; set; }
    [Required]
    [StringLength(15)]
    public string Ip { get; set; }
    public string? Telefone { get; set; }
    public string Cep { get; set; }
    public string Endereco { get; set; }
    public string Numero { get; set; }
    public string Uf { get; set; }

    [MemoryPackConstructor]
    public CondominioCreateDTO() { }

    // ✅ Não usado pelo MemoryPack
    public CondominioCreateDTO(Condominio condominio)
    {
        Id = Guid.NewGuid();
        Nome = condominio.Nome ?? string.Empty;
        Cnpj = condominio.Cnpj ?? string.Empty;
        Ip = string.Empty;
        Telefone = condominio.Telefone ?? string.Empty;
        Cep = condominio.Cep ?? string.Empty;
        Endereco = condominio.Endereco ?? string.Empty;
        Numero = condominio.End_num ?? string.Empty;
        Uf = condominio.End_uf ?? string.Empty;
    }
}