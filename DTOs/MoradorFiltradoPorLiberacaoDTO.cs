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

        public string? Celular { get; set; }

        public string? Cpf { get; set; }

        public string? Email { get; set; }

        public bool Liberado { get; set; }

        public DateTime? DataHoraCadastro { get; set; }

        public DateTime? DataHoraAlteracao { get; set; }

        public MoradorFiltradoPorLiberacaoDTO(Morador morador, bool liberado)
        {
            Id = morador.Id;
            Nome = morador.Nome;
            Foto = morador.Foto;
            Unidade = morador.Unidade;
            Celular = morador.Celular;
            Cpf = morador.Cpf;
            Email = morador.Email;
            Liberado = liberado;
            DataHoraCadastro = morador.DataHoraCadastro;
            DataHoraAlteracao = morador.DataHoraAlteracao;
        }
    }
}
