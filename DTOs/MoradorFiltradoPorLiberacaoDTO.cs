using System.ComponentModel.DataAnnotations.Schema;
using AppSharedProject.Models.Firebird;

namespace AppSharedProject.DTO
{
    public class MoradorFiltradoPorLiberacaoDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public byte[]? Foto { get; set; }

        public string? Unidade { get; set; }

        public Unidade UnidadeNavigation { get; set; }

        public string? Celular { get; set; }

        public string? Cpf { get; set; }

        public string? Email { get; set; }

        public bool Admin { get; set; }

        public DateTime? DataHoraCadastro { get; set; }

        public DateTime? DataHoraAlteracao { get; set; }

        public DateOnly? ValidadeDataInicial { get; set; }

        public TimeOnly? ValidadeHoraInicial { get; set; }

        public DateOnly? ValidadeDatFinal { get; set; }

        public TimeOnly? ValidadeHoraFinal { get; set; }

        public int? AutoArquivamento { get; set; }

        public MoradorFiltradoPorLiberacaoDTO(Morador morador, bool admin)
        {
            Id = morador.Id;
            Nome = morador.Nome;
            Foto = morador.Foto;
            Unidade = morador.Unidade;
            UnidadeNavigation = morador.UnidadeNavigation;
            Celular = morador.Celular;
            Cpf = morador.Cpf;
            Email = morador.Email;
            Admin = admin;
            DataHoraCadastro = morador.DataHoraCadastro;
            DataHoraAlteracao = morador.DataHoraAlteracao;
            ValidadeDataInicial = morador.ValidadeDataInicial;
            ValidadeHoraInicial = morador.ValidadeHoraInicial;
            ValidadeDatFinal = morador.ValidadeDatFinal;
            ValidadeHoraFinal = morador.ValidadeHoraFinal;
            AutoArquivamento = morador.AutoArquivamento;
        }
    }
}
