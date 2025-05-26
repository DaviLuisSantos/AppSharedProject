using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppSharedProject.Models.Sqlite;

public class Visitante : BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string? Celular { get; set; }
    public string? Cpf { get; set; }
    public byte[]? Foto { get; set; }
    [ForeignKey("Morador")]
    public Guid MoradorId { get; set; }
    public Morador Morador { get; set; }
    public StatusVisitante Status { get; set; }

    public enum StatusVisitante
    {
        Cliente,
        Servidor
    }
}
