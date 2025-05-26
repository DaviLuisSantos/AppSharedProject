using System.ComponentModel.DataAnnotations.Schema;

namespace DataTransfer.Models.Firebird;

[Table("MORADORES")]
public class Morador
{
    [Column("IDMORADOR")]
    public int Id { get; set; }

    [Column("NOME")]
    public string Nome { get; set; }

    [Column("FOTO")]
    public byte[]? Foto { get; set; }

    [Column("UNIDADE")]
    public string? Unidade { get; set; }
    [ForeignKey("Unidade")]
    public Unidade UnidadeNavigation { get; set; }

    [Column("CELULAR")]
    public string? Celular { get; set; }

    [Column("CPF")]
    public string? Cpf { get; set; }

    [Column("EMAIL")]
    public string? Email { get; set; }
    [Column("DATAHORACADASTRO")]
    public DateTime? DataHoraCadastro { get; set; }
    [Column("DATAHORAALTERACAO")]
    public DateTime? DataHoraAlteracao { get; set; }
    [Column("CID_DATA_VAL_INI")]
    public DateOnly? ValidadeDataInicial { get; set; }
    [Column("CID_HORA_VAL_INI")]
    public TimeOnly? ValidadeHoraInicial { get; set; }
    [Column("CID_DATA_VAL_FIM")]
    public DateOnly? ValidadeDatFinal { get; set; }
    [Column("CID_HORA_VAL_FIM")]
    public TimeOnly? ValidadeHoraFinal { get; set; }
    [Column("AUTOARQUIVAMENTO")]
    public int? AutoArquivamento { get; set; }

    public Morador(Sqlite.Morador morador)
    {
        Nome = morador.Nome;
        Foto = morador.Foto;
        Unidade = morador.Unidade.Nome;
        Celular = morador.Celular;
        Cpf = morador.Cpf;
        Email = morador.Email;
        DataHoraCadastro = morador.CreatedAt;
        DataHoraAlteracao = morador.UpdatedAt;
    }
}
